
$(document).ready(function () {

    // İlk başda ikinci dropdown listi deaktiv edirik
    $("#secondDropdown input, #secondDropdown i").prop("disabled", true);

    $(".custom-dropdown fas, .custom-dropdown input").click(function (e) {
        $(".dropdown-list").not($(this).siblings(".dropdown-list")).hide();

        $(this).siblings(".dropdown-list").toggle();

        let icon = $(this).siblings("fas");
        if (icon.hasClass("fa-chevron-down")) {
            icon.removeClass("fa-chevron-down").addClass("fa-chevron-up");
        } else {
            icon.removeClass("fa-chevron-up").addClass("fa-chevron-down");
        }

        e.stopPropagation();
    });


    $(".dropdown-list li").click(function () {
        if ($(this).hasClass("def")) {
            $(this).closest(".custom-dropdown").find("input[type='text']").val($(this).closest(".custom-dropdown").find("input[type='text']").attr("value"));
            $(this).siblings("li").find("input[type='checkbox']").prop("checked", false);

            // Əgər bu birinci dropdownsa, ikinci dropdownu deaktiv edirik
            if ($(this).closest(".custom-dropdown").is("#firstDropdown")) {
                $("#secondDropdown input, #secondDropdown fas").prop("disabled", true).val("Model").siblings(".dropdown-list").hide();
            }
        } else {
            let selectedValue = $(this).text().trim();  // checkbox-a görə məlumatın ətrafında boşluqlar olacaq, onları təmizləyirik
            $(this).closest(".custom-dropdown").find("input[type='text']").val(selectedValue);

            // Eyni zamanda, əgər li elementində checkbox varsa, onun statusunu dəyiş
            let checkbox = $(this).find("input[type='checkbox']");
            if (checkbox.length) {
                checkbox.prop("checked", !checkbox.prop("checked"));
            }

            // Əgər bu birinci dropdownsa, ikinci dropdownu aktiv edirik
            if ($(this).closest(".custom-dropdown").is("#firstDropdown")) {
                $("#secondDropdown input, #secondDropdown fas").prop("disabled", false);
            }
        }

        $(this).parent(".dropdown-list").hide();
        $(this).closest(".custom-dropdown").find("fas").removeClass("fa-chevron-up").addClass("fa-chevron-down");
    });

    $(document).click(function () {
        $(".dropdown-list").hide();
        $(".custom-dropdown fas").removeClass("fa-chevron-up").addClass("fa-chevron-down");
    });

});

$(document).ready(function () {
    $('.credit-input').on('click', function () {
        $(this).toggleClass('active');
    });
});

$(document).ready(function () {
    $('.conut-zero span').on('click', function () {
        // Formu sıfırlamaq
        $('form')[0].reset();

        // Bütün dropdownlarını default qiymətlərinə qaytarmaq
        $(".custom-dropdown input[type='text']").each(function () {
            var defaultValue = $(this).data("default");
            if (defaultValue) {
                $(this).val(defaultValue);
            }
        });

        // Əgər "Kredit" və "Barter" inputları "active" classını əldə edirsə onu sıfırlayırıq
        $(".kredit-barter .credit-input").removeClass('active');
    });
});


$(document).ready(function () {
    $('.toggle-filters').on('click', function () {
        $('.extra-filters').slideToggle();

        let icon = $(this).find('i');
        if (icon.hasClass("fa-chevron-down")) {
            icon.removeClass("fa-chevron-down").addClass("fa-chevron-up");
        } else {
            icon.removeClass("fa-chevron-up").addClass("fa-chevron-down");
        }
    });
});


// card love icon color deyismek
$(document).ready(function () {
    $(".heart-icon").on("click", function () {
        $(this).toggleClass("active");
    });
});

$(document).ready(function () {
    
    // giris modalının açılması
    $('#openModalBtn').on('click', function (e) {
        e.preventDefault();
        $('#myModal').css('display', 'flex');
    });

    // Telefon nömrəsi modalının açılması
    $('#openModalPhone').on('click', function (e) {
        e.preventDefault();
        $('#myModal-phone').css('display', 'flex');
    });

    // SMS mesaj modalının açılması
    $('#openModalPhone-message').on('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
        const phoneNumber = $('#phone').val();
        $('#displayedPhone').text(phoneNumber + ' nömrəsinə SMS-kod göndərildi');
        $('#myModal-phone').css('display', 'none');
        $('#phone-message').css('display', 'flex');
    });

    // Bütün modalların bağlanması
    $('.close-btn').on('click', function () {
        $('.modal').css('display', 'none');
    });

    // Geri qayıtma ikonuna click olunduqda myModal-phone modalını açmaq
    $('#phone-message .fa-chevron-left').on('click', function () {
        $('#phone-message').css('display', 'none');
        $('#myModal-phone').css('display', 'flex');
    });

     //Telefon nömrəsi inputunun formatlanması
    $('.button-phone').addClass('deactivated');
    $('#phone').on('input', function () {
        let value = $(this).val().replace(/\D/g, "").substring(0, 10);

        if (value.length <= 3) {
            value = '(' + value;
        } else if (value.length <= 6) {
            value = '(' + value.substring(0, 3) + ')' + value.substring(3);
        } else if (value.length <= 8) {
            value = '(' + value.substring(0, 3) + ')' + value.substring(3, 6) + '-' + value.substring(6);
        } else if (value.length <= 10) {
            value = '(' + value.substring(0, 3) + ')' + value.substring(3, 6) + '-' + value.substring(6, 8) + '-' + value.substring(8);
        }

        $(this).val(value);

        // Əgər input dəyəri tam doldurulubsa, düyməni aktivləşdiririk. Əks halda, deaktivləşdiririk
        if ($(this).val().length === 14) {
            $('.button-phone').removeClass('deactivated');
        } else {
            $('.button-phone').addClass('deactivated');
        }
    });

});















