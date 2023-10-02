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
            const image = $("<img>").addClass("new-car").attr("src", e.target.result);
            $(input).prev().html(image);
            count++;
        }
        reader.readAsDataURL(input.files[0]);
    }
}

$('#plus').on('change', function () {
    readURLS(this);
});

function readURLS(input) {
    if (input.files && input.files[0]) {
        let reader = new FileReader();

        reader.onload = function (e) {
            count++;
            if (count === 1) {
                const image = $("<img>").addClass("new-car").attr("src", e.target.result);
                $(".image-1").append(image);
            } else if (count === 2) {
                const image = $("<img>").addClass("new-car").attr("src", e.target.result);
                $(".image-2").append(image);
            } else if (count === 3) {
                const image = $("<img>").addClass("new-car").attr("src", e.target.result);
                $(".image-3").append(image);
            } else if (count > 3) {
                $(".new-description").hide();
                const image = $("<img>").addClass("new-car").attr("src", e.target.result);
                const label = $("<label>").attr("for", `image-${count}`).append(image);
                $('.image-form').append(label);
            }
        }

        reader.readAsDataURL(input.files[0]);
    }
}


