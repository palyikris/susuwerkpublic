document.addEventListener('DOMContentLoaded', function() {
    const darkModeCheckbox = document.getElementById('dark-mode-checkbox');
    const body = document.body;

    darkModeCheckbox.addEventListener('change', function() {
        if (this.checked) {
            body.classList.add('dark-mode');
        } else {
            body.classList.remove('dark-mode');
        }
    });
});
