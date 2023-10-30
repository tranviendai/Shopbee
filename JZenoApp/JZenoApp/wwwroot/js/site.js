// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ChangeImage(UploadImage, previewImg) {
    console.log(true);
    if (UploadImage.files && UploadImage.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(previewImg).attr('src', e.target.result);
        }
        reader.readAsDataURL(UploadImage.files[0]);
    }
}

function RemoveImage(imageRemove) {
    imageRemove.remove();
}

function ResetImage() {
    const imgReset = document.getElementById("previewImg");
    imgReset.remove();
}

$(function () {
    // Multiple images preview in browser
    var imagesPreview = function (input, placeToInsertImagePreview) {
        if (input.files) {
            $("#img-not-found").remove();
            var filesAmount = input.files.length;

            for (i = 0; i < filesAmount; i++) {
                var reader = new FileReader();

                reader.onload = function (event) {
                    $($.parseHTML('<img class="img-create" alt="Thêm Sản Phẩm" id="previewImg" width="200px" height="200px" style="margin: 2px;" onclick="RemoveImage(this)">')).attr('src', event.target.result).appendTo(placeToInsertImagePreview);
                }

                reader.readAsDataURL(input.files[i]);
            }
        }

    };

    $('#gallery-photo-add').on('change', function () {
        imagesPreview(this, 'div.gallery');
    });
});