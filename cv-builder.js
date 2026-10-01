const fields = {
    name: "previewName",
    job: "previewJob",
    email: "previewEmail",
    phone: "previewPhone",
    location: "previewLocation",
    summary: "previewSummary",
    education: "previewEducation",
    experience: "previewExperience",
    skills: "previewSkills",
    references: "previewReferences"
};


Object.keys(fields).forEach(function(field) {

    const input = document.getElementById(field);
    const preview = document.getElementById(fields[field]);

    input.addEventListener("input", function() {

        if (input.value.trim() === "") {

            return;

        }

        preview.textContent = input.value;

    });

});


function downloadCV() {

    window.print();

}
