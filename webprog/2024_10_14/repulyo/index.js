const canvas = document.querySelector("canvas");
const ctx = canvas.getContext("2d");

// Application state
const plane = {
  x: 0,
  y: 20,
  width: 60,
  height: 30,
  vx: 0,
  img: new Image()
};
const parcel = {
  x: 0,
  y: plane.y + plane.height,
  width: 30,
  height: 30,
  vx: 0,
  vy: 0,
  ay: 0,
  img: new Image()
};
const house = {
  x: 400,
  y: canvas.height - 120,
  width: 100,
  height: 100,
  img: new Image()
};
let gameState = 0; // 0-start, 1-moving, 2-dropping, 3-hit, 4-missed

// ================= Game loop =====================

// Time-based animation (from the lecture slide)
let lastFrameTime = performance.now();

function next(currentTime = performance.now()) {
  const dt = (currentTime - lastFrameTime) / 1000; // seconds
  lastFrameTime = currentTime;

  update(dt); // Update current state
  render(); // Rerender the frame

  requestAnimationFrame(next);
}

function update(dt) {
  plane.x += plane.vx * dt;
  parcel.x += parcel.vx * dt;
  parcel.y += parcel.vy * dt;
  parcel.vy += parcel.ay * dt;

  if (isCollision(parcel, house)) {
    gameState = 3;
    parcel.vx = 0;
    parcel.vy = 0;
    parcel.ay = 0;
  }

  if (parcel.y > canvas.height) {
    gameState = 4;
    parcel.vx = 0;
    parcel.vy = 0;
    parcel.ay = 0;
  }
}

function render() {
  // ctx.fillStyle = "lightblue";
  // ctx.fillRect(0, 0, canvas.width, canvas.height);

  // ctx.fillStyle = "white";
  // ctx.fillRect(plane.x, plane.y, plane.width, plane.height);

  // ctx.fillStyle = "orange";
  // ctx.fillRect(parcel.x, parcel.y, parcel.width, parcel.height);

  // ctx.fillStyle = "red";
  // ctx.fillRect(house.x, house.y, house.width, house.height);

  ctx.clearRect(0, 0, canvas.width, canvas.height);

  ctx.drawImage(plane.img, plane.x, plane.y, plane.width, plane.height);
  ctx.drawImage(parcel.img, parcel.x, parcel.y, parcel.width, parcel.height);
  ctx.drawImage(house.img, house.x, house.y, house.width, house.height);

  if (gameState === 3) {
    ctx.font = "50px Arial";
    ctx.fillStyle = "white";
    ctx.fillText("Delivered!", 20, 200);
  }

  if (gameState === 4) {
    ctx.font = "50px Arial";
    ctx.fillStyle = "white";
    ctx.fillText("Missed!", 20, 200);
  }
}

document.addEventListener("click", function(e) {
  if (gameState === -1) {
    gameState = 0;
  }
  if (gameState === 0) {
    plane.vx = 200;
    parcel.vx = 200;
    gameState = 1;
  } else if (gameState === 1) {
    parcel.ay = 300;
    gameState = 2;
  } else if (gameState === 3 || gameState === 4) {
    plane.x = 0;
    plane.vx = 0;
    parcel.x = 0;
    parcel.y = plane.y + plane.height;
    parcel.vx = 0;
    parcel.vy = 0;
    parcel.ay = 0;
    gameState = -1;
  }
});

// Start the loop
plane.img.src = "plane.png";
house.img.src = "house.png";
parcel.img.src = "parcel.png";
next();

// =============== Utility functions =================

function isCollision(box1, box2) {
  return !(
    box2.y + box2.height < box1.y ||
    box1.x + box1.width < box2.x ||
    box1.y + box1.height < box2.y ||
    box2.x + box2.width < box1.x
  );
}
