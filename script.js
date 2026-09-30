/* =========================
   BRIGHT DEV 2.0
   JAVASCRIPT
========================= */

const modal = document.getElementById("modal");
const closeBtn = document.getElementById("closeBtn");

const suggestBtn = document.getElementById("suggestBtn");
const contactSuggestion = document.getElementById("contactSuggestion");

const suggestForm = document.getElementById("suggestForm");


/* OPEN MODAL */

function openModal() {
    modal.classList.add("active");
}


/* CLOSE MODAL */

function closeModal() {
    modal.classList.remove("active");
}


suggestBtn.addEventListener("click", openModal);

contactSuggestion.addEventListener("click", openModal);

closeBtn.addEventListener("click", closeModal);


/* CLOSE WHEN CLICKING OUTSIDE */

modal.addEventListener("click", function(event) {

    if (event.target === modal) {
        closeModal();
    }

});


/* SUGGESTION FORM */

suggestForm.addEventListener("submit", function(event) {

    event.preventDefault();

    const toolName = document.getElementById("toolName").value;
    const toolReason = document.getElementById("toolReason").value;

    if (toolName && toolReason) {

        alert(
            "Thanks for your suggestion! 🚀\n\n" +
            "Tool: " + toolName
        );

        suggestForm.reset();

        closeModal();
    }

});


/* CLOSE MODAL WITH ESCAPE */

document.addEventListener("keydown", function(event) {

    if (event.key === "Escape") {
        closeModal();
    }

});
