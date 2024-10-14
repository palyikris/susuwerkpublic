const canvas = document.querySelector("canvas");
const ctx = canvas.getContext("2d");

const madar = {
  x: 50,
  y: canvas.height / 2,
  width: 30,
  height: 50,
  img: new Image("./flappybird.png"),
  vy: 0,
  ay: 300
};

ctx.fillStyle = "red";
ctx.drawImage(madar.img, madar.x, madar.y, madar.width, madar.height);

draw();

function draw() {}
