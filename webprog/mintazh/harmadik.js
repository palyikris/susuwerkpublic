function action(event) {
  if (event.target.tagName === "BUTTON") {
    console.log(event.target.textContent);
    console.log(event.target.getAttribute("data-toggle"));
    console.log(
      event.target.parentElement.parentElement.children[0].textContent
    );
    event.target.parentElement.parentElement.children[1].hidden = false;
    const children = event.target.parentElement.parentElement.children;
    Array.from(children).map(child => {
      if (
        child.getAttribute("class") === event.target.getAttribute("data-toggle")
      ) {
        child.hidden = false;
      } else {
        if (child.getAttribute("class")) {
          child.hidden = true;
        }
      }
    });
  }
}

const contacts = document.getElementById("contacts");
contacts.addEventListener("click", action);
