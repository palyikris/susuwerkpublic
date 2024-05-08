function toggleAccessibility() {
    var body = document.body;
    var isHighContrast = body.classList.toggle("body_high-contrast");
  
    localStorage.setItem("highContrast", isHighContrast);
  }
  
  function applyHighContrastMode() {
    var body = document.body;
    var isHighContrast = localStorage.getItem("highContrast") === "true";
  
    if (isHighContrast) {
      body.classList.add("body_high-contrast");
    } else {
      body.classList.remove("body_high-contrast");
    }
  }

  applyHighContrastMode();