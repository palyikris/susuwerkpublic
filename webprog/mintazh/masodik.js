function generateColor() {
  const hue = document.getElementById("hue").value;
  const sat = document.getElementById("sat").value;
  const light = document.getElementById("light").value;

  const color = `hsl(${hue}, ${sat}%, ${light}%)`;
  document.getElementById("colorString").value = color;
  document.querySelector("body").style.backgroundColor = color;
}

const sliders = document.querySelectorAll("input[type='range']");
sliders.forEach(slider => {
  slider.addEventListener("input", generateColor);
});
