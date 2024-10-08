const input = document.getElementById("counter");
input.value = 0;

const min = -5;
const max = 5;

function sub() {
  if (parseInt(input.value) === min) {
    document.getElementById("sub").disabled = true;
    return;
  }
  document.getElementById("add").disabled = false;

  let initVal = parseInt(input.value);
  input.value = initVal - 1;
}

function add() {
  if (parseInt(input.value) === max) {
    document.getElementById("add").disabled = true;
    return;
  }
  document.getElementById("sub").disabled = false;

  let initVal = parseInt(input.value);
  input.value = initVal + 1;
}

// --------------------------------------------

const words = ["fekete", "fehér", "igen", "nem"];
const randInd = Math.floor(Math.random() * 4);
const word = words[randInd];
const lines = document.getElementById("lines");
const letters = document.getElementById("letters");
const mistakes = document.getElementById("mistakes");
const foundDom = document.getElementById("found");
const result = document.getElementById("result");
let nOfMistakes = 3;
mistakes.textContent = nOfMistakes;
console.log(word);

for (let i = 0; i < word.length; i++) {
  span = document.createElement("span");
  span.classList.add(word[i]);
  lines.appendChild(span);
}

function guess() {
  const letter = letters.value;
  if (word.indexOf(letter) !== -1) {
    result.textContent = "Gratula!";
    spans = document.getElementsByClassName(letter);
    Array.from(spans).map(span => {
      span.textContent = span.className;
      span.classList.add("foundSpan");
    });

    foundSpans = document.getElementsByClassName("foundSpan");
    if (Array.from(foundSpans).length === word.length) {
      result.textContent = "Nyertél!!";
      letters.style.display = "none";
    }
  } else {
    result.textContent = "Ne add fel!";
    nOfMistakes--;
    if (nOfMistakes === -1) {
      mistakes.style.display = "none";
      result.textContent = "Vesztettél:(";
      letters.style.display = "none";
    }
    mistakes.textContent = nOfMistakes;
  }
  letters.value = "";
}

letters.addEventListener("input", guess);
