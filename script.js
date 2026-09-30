// Bright Dev - Main JavaScript

// Mobile menu
const menuBtn = document.querySelector(".menu-btn");
const navLinks = document.querySelector(".nav-links");

if (menuBtn) {
    menuBtn.addEventListener("click", () => {
        navLinks.classList.toggle("active");
    });
}

// Close mobile menu when a link is clicked
document.querySelectorAll(".nav-links a").forEach(link => {
    link.addEventListener("click", () => {
        navLinks.classList.remove("active");
    });
});

// Smooth scrolling
document.querySelectorAll('a[href^="#"]').forEach(link => {
    link.addEventListener("click", function (e) {
        const target = document.querySelector(this.getAttribute("href"));

        if (target) {
            e.preventDefault();

            target.scrollIntoView({
                behavior: "smooth"
            });
        }
    });
});

// Contact button
const contactButtons = document.querySelectorAll(".contact-btn");

contactButtons.forEach(button => {
    button.addEventListener("click", () => {
        const contactSection = document.querySelector("#contact");

        if (contactSection) {
            contactSection.scrollIntoView({
                behavior: "smooth"
            });
        }
    });
});

// Current year in footer
const year = document.querySelector("#year");

if (year) {
    year.textContent = new Date().getFullYear();
}

// Simple scroll animation
const sections = document.querySelectorAll("section");

const observer = new IntersectionObserver(
    entries => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add("show");
            }
        });
    },
    {
        threshold: 0.15
    }
);

sections.forEach(section => {
    observer.observe(section);
});
/* ==============================
   BRIGHT DEV CV BUILDER
================================ */

function generateCV() {

    const name = document.getElementById("cvName").value.trim();
    const job = document.getElementById("cvJob").value.trim();
    const phone = document.getElementById("cvPhone").value.trim();
    const email = document.getElementById("cvEmail").value.trim();
    const location = document.getElementById("cvLocation").value.trim();

    const summary = document.getElementById("cvSummary").value.trim();
    const education = document.getElementById("cvEducation").value.trim();
    const experience = document.getElementById("cvExperience").value.trim();
    const skills = document.getElementById("cvSkills").value.trim();
    const certifications = document.getElementById("cvCertifications").value.trim();
    const languages = document.getElementById("cvLanguages").value.trim();

    if (!name) {
        alert("Please enter your full name.");
        return;
    }

    const preview = document.getElementById("cvPreview");

    preview.innerHTML = `
        <div class="cv-document">

            <h1>${escapeHTML(name)}</h1>

            ${job ? `<div class="job-title">${escapeHTML(job)}</div>` : ""}

            <div class="cv-contact">
                ${phone ? `📞 ${escapeHTML(phone)} ` : ""}
                ${email ? ` | ✉️ ${escapeHTML(email)} ` : ""}
                ${location ? ` | 📍 ${escapeHTML(location)}` : ""}
            </div>

            ${summary ? `
                <h2>PROFESSIONAL SUMMARY</h2>
                <p>${escapeHTML(summary)}</p>
            ` : ""}

            ${education ? `
                <h2>EDUCATION</h2>
                <p>${escapeHTML(education)}</p>
            ` : ""}

            ${experience ? `
                <h2>WORK EXPERIENCE</h2>
                <p>${escapeHTML(experience)}</p>
            ` : ""}

            ${skills ? `
                <h2>SKILLS</h2>
                <p>${escapeHTML(skills)}</p>
            ` : ""}

            ${certifications ? `
                <h2>CERTIFICATIONS</h2>
                <p>${escapeHTML(certifications)}</p>
            ` : ""}

            ${languages ? `
                <h2>LANGUAGES</h2>
                <p>${escapeHTML(languages)}</p>
            ` : ""}

        </div>
    `;

    document.getElementById("downloadCV").style.display = "block";

    preview.scrollIntoView({
        behavior: "smooth",
        block: "start"
    });
}


function escapeHTML(text) {

    const div = document.createElement("div");

    div.textContent = text;

    return div.innerHTML;
}


function downloadCV() {

    const cv = document.getElementById("cvPreview");

    if (!cv.innerText.trim()) {
        alert("Please generate your CV first.");
        return;
    }

    const printWindow = window.open("", "_blank");

    printWindow.document.write(`
        <!DOCTYPE html>
        <html>
        <head>

            <title>My CV - Bright Dev</title>

            <style>

                body {
                    font-family: Arial, sans-serif;
                    margin: 40px;
                    color: #222;
                }

                .cv-document h1 {
                    margin: 0;
                    font-size: 30px;
                }

                .job-title {
                    margin: 5px 0 15px;
                    color: #555;
                    font-weight: bold;
                }

                .cv-contact {
                    font-size: 13px;
                    color: #555;
                    padding-bottom: 15px;
                    border-bottom: 2px solid #222;
                }

                h2 {
                    font-size: 17px;
                    margin-top: 25px;
                    border-bottom: 1px solid #ddd;
                    padding-bottom: 5px;
                }

                p {
                    line-height: 1.6;
                    white-space: pre-line;
                    font-size: 14px;
                }

                @media print {
                    body {
                        margin: 25px;
                    }
                }

            </style>

        </head>

        <body>

            ${cv.innerHTML}

            <script>
                window.onload = function() {
                    window.print();
                };
            <\/script>

        </body>
        </html>
    `);

    printWindow.document.close();
}
