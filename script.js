// Bright Dev main JavaScript

document.addEventListener("DOMContentLoaded", function () {

    console.log("Bright Dev is ready!");

    // Smooth scrolling for links that point to sections
    document.querySelectorAll('a[href^="#"]').forEach(function (link) {

        link.addEventListener("click", function (event) {

            const target = document.querySelector(
                this.getAttribute("href")
            );

            if (target) {
                event.preventDefault();

                target.scrollIntoView({
                    behavior: "smooth"
                });
            }

        });

    });

});
