//Header menu icon 
function myFunction() {
    var x = document.getElementById("myTopnav");
    if (x.className === "header_top_nav") {
        x.className += " responsive";
    } else {
        x.className = "header_top_nav";
    }
}
//Select list Sıfırla click edildikdə sıfırla sözü yerinə Default  söz yazdırmaq.
$(document).ready(function () {
    $('.dynamic-label').on('focus', function () {
        $(this).find('.default-option').hide();
    }).on('blur', function () {
        if ($(this).val() === "") {
            $(this).find('.default-option').show();
        }
    }).on('change', function () {
        if ($(this).find(':selected').hasClass('zero')) {
            $(this).val("");
            $(this).blur();
        }
    });
});



//Sifirla icon deyisilmesi
$(document).ready(function () {
    $(".extrems-form").hide();
    $(".toggle-filters .fas.fa-chevron-up").hide();

    $(".toggle-filters").click(function () {
        $(".extrems-form").slideToggle();

        $(this).parent(".dropdown-list").hide();
        $(this).closest(".custom-dropdown").find("fas").removeClass("fa-chevron-up").addClass("fa-chevron-down");
    });
});

//Form melumatlarinin sifirlanmasi
$(document).ready(function () {
    $('.conut-zero').click(function (e) {
        e.preventDefault();

        $('form select').each(function () {
            $(this).prop('selectedIndex', 0).trigger('change');
        });


        $('form input[type="checkbox"]:not(.kredit-barter input)').each(function () {
            $(this).prop('checked', false);
        });

        $('form input[type="number"]').each(function () {
            const defaultVal = $(this).data('default');
            if (defaultVal) {
                $(this).val(defaultVal);
            } else {
                $(this).val('');
            }
        });

        $('form input[type="radio"]').each(function () {
            var defaultValue = $(this).data('default');
            $(this).prop('checked', $(this).val() === defaultValue);
        });

        $('.valyuta').css('color', 'black');
        $('.valyuta option:first').css('color', 'black');

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

//Məlsulun Seçilmişlərə əlavə edilməsi silinməsi.
$(document).ready(function () {
    $(".heart-icon").on("click", function (e) {
        e.preventDefault();
        var productId = $(this).closest(".card").data("product-id");
        var isFavorite = $(this).hasClass("active");

        if (isFavorite) {
            $(this).removeClass("active favorite"); 
            removeFromFavorites(productId);
        } else {
            $(this).addClass("active favorite"); 
            addToFavorites(productId);
        }
    });

    function addToFavorites(productId) {
        $.post("/Favorites/AddToFavorites", { productId: productId }, function () {
            // Məhsulu favoritlərə əlavə edərkən, sadəcə heart-icon-u işarələyirik
            $(".card[data-product-id='" + productId + "'] .heart-icon").addClass("active favorite");
        });
    }

    function removeFromFavorites(productId) {
        $.post("/Favorites/RemoveFromFavorites", { productId: productId }, function () {
            // Məhsulu favoritlərdən silərkən, heart-icon-u deaktiv edirik və məhsulu silirik
            $(".card[data-product-id='" + productId + "'] .heart-icon").removeClass("active favorite");
            $(".card[data-product-id='" + productId + "']").remove();
        });
    }
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














