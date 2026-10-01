// BrightDev Image Resizer

const imageInput = document.getElementById("imageInput");
const preview = document.getElementById("preview");
const resizeBtn = document.getElementById("resizeBtn");
const downloadBtn = document.getElementById("downloadBtn");

const widthInput = document.getElementById("width");
const heightInput = document.getElementById("height");

let originalImage = new Image();
let resizedImageData = null;

// Select image
if (imageInput) {
    imageInput.addEventListener("change", function () {
        const file = this.files[0];

        if (!file) return;

        if (!file.type.startsWith("image/")) {
            alert("Please select a valid image.");
            return;
        }

        const reader = new FileReader();

        reader.onload = function (event) {
            originalImage.onload = function () {
                // Put original dimensions into the inputs
                widthInput.value = originalImage.width;
                heightInput.value = originalImage.height;

                // Show preview
                preview.src = event.target.result;
                preview.style.display = "block";
            };

            originalImage.src = event.target.result;
        };

        reader.readAsDataURL(file);
    });
}


// Resize image
if (resizeBtn) {
    resizeBtn.addEventListener("click", function () {

        if (!originalImage.src) {
            alert("Please select an image first.");
            return;
        }

        const newWidth = parseInt(widthInput.value);
        const newHeight = parseInt(heightInput.value);

        if (!newWidth || !newHeight || newWidth <= 0 || newHeight <= 0) {
            alert("Please enter valid width and height.");
            return;
        }

        const canvas = document.createElement("canvas");
        const ctx = canvas.getContext("2d");

        canvas.width = newWidth;
        canvas.height = newHeight;

        ctx.drawImage(
            originalImage,
            0,
            0,
            newWidth,
            newHeight
        );

        resizedImageData = canvas.toDataURL("image/png");

        // Show resized image
        preview.src = resizedImageData;

        // Enable download button
        if (downloadBtn) {
            downloadBtn.style.display = "inline-block";
        }

        alert("Image resized successfully!");
    });
}


// Download resized image
if (downloadBtn) {
    downloadBtn.addEventListener("click", function () {

        if (!resizedImageData) {
            alert("Please resize the image first.");
            return;
        }

        const link = document.createElement("a");

        link.href = resizedImageData;
        link.download = "brightdev-resized-image.png";

        document.body.appendChild(link);
        link.click();
        document.body.removeChild(link);
    });
}
