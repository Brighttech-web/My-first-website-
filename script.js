/* =====================================================
   BRIGHTDEV JAVASCRIPT
===================================================== */


/* ================= MOBILE MENU ================= */

const menuToggle = document.getElementById("menuToggle");
const navMenu = document.getElementById("navMenu");

if (menuToggle) {

    menuToggle.addEventListener("click", () => {

        navMenu.classList.toggle("show");

        if (navMenu.classList.contains("show")) {
            menuToggle.textContent = "✕";
        } else {
            menuToggle.textContent = "☰";
        }

    });

}


/* Close mobile menu after clicking a link */

document.querySelectorAll(".nav-link").forEach(link => {

    link.addEventListener("click", () => {

        navMenu.classList.remove("show");

        if (menuToggle) {
            menuToggle.textContent = "☰";
        }

    });

});


/* ================= THEME TOGGLE ================= */

const themeToggle = document.getElementById("themeToggle");

if (themeToggle) {

    themeToggle.addEventListener("click", () => {

        document.body.classList.toggle("dark-mode");

        if (document.body.classList.contains("dark-mode")) {

            themeToggle.textContent = "☾";

            localStorage.setItem("brightdev-theme", "dark");

        } else {

            themeToggle.textContent = "☀";

            localStorage.setItem("brightdev-theme", "light");

        }

    });

}


/* ================= LOAD SAVED THEME ================= */

const savedTheme = localStorage.getItem("brightdev-theme");

if (savedTheme === "dark") {

    document.body.classList.add("dark-mode");

    if (themeToggle) {
        themeToggle.textContent = "☾";
    }

}


/* ================= SCROLL REVEAL ================= */

const revealElements = document.querySelectorAll(
    ".tool-card, .step, .about-content, .about-box, .cta-container"
);

const observer = new IntersectionObserver(
    entries => {

        entries.forEach(entry => {

            if (entry.isIntersecting) {

                entry.target.style.opacity = "1";
                entry.target.style.transform = "translateY(0)";

                observer.unobserve(entry.target);

            }

        });

    },
    {
        threshold: 0.12
    }
);


revealElements.forEach(element => {

    element.style.opacity = "0";
    element.style.transform = "translateY(25px)";
    element.style.transition = "opacity 0.7s ease, transform 0.7s ease";

    observer.observe(element);

});
