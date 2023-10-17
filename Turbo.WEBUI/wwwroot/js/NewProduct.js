$(document).ready(function () {
    $(".container input[type='checkbox']").change(function () {
        if ($(this).prop("checked")) {
            $(".container input[type='checkbox']").not(this).prop("checked", false);
        }
    });
});

$('.custom-file-input').on('change', function () {
    var fileName = $(this).val();

    readURL(this);
});

let count = 0;

function readURL(input) {
    if (input.files && input.files[0]) {
        let reader = new FileReader();
        reader.onload = function (e) {
            const imageUrl = e.target.result;
            $(input).prev().css("background-image", `url(${imageUrl})`).html("");
            count++;
        }
        reader.readAsDataURL(input.files[0]);
    }
}


$('#plus').on('change', function () {
    readURLS(this);
});
function readURLS(input) {
    const files = input.files;
    for (let i = 0; i < files.length; i++) {
        let reader = new FileReader();
        reader.onload = function (e) {
            count++;
            if (count <= 3) {
                $(`.image-${count}`).css("background-image", `url(${e.target.result})`).html("");
            } else {
                $(".new-description").hide();
                const image = $("<img>").addClass("new-car").attr("src", e.target.result);
                const label = $("<label>").attr("for", `image-${count}`).append(image);
                $('.image-form').append(label);
            }
        }
        reader.readAsDataURL(files[i]);
    }
}



function removeImage(element) {
    $(element).siblings("img").remove(); 
    $(element).siblings("input").val("");  
}
