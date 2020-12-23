var food = {} || food;


/*
food.showShortcontent = function () {
    $.ajax({
        url: 'https://localhost:44348/api/Food/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#shortcontent').append(`${v.shortContent}`);
            })

        }
    });
}*/

food.showAboutDescription = function () {
    $.ajax({
        url: 'https://localhost:44348/api/About/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#about').append(` <h6>${v.description}</h6>`);
            })

        }
    });
}

food.showAboutName = function () {
    $.ajax({
        url: 'https://localhost:44348/api/About/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#nameAbout').append(` <span>${v.name}</span>`);
            })

        }
    });
}


   /* CONTACT*/
food.showContactName = function () {
    $.ajax({
        url: 'https://localhost:44348/api/Contact/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#nameContact').append(` <span>${v.name}</span>`);
            })

        }
    });
}

food.showEvaluate = function () {
    $.ajax({
        url: 'https://localhost:44348/api/Contact/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#descriptionevaluate').append(` <h6>${v.evaluate}</h6>`);
            })

        }
    });
}









food.init = function () {

    food.showAboutDescription();
    food.showAboutName();
    food.showContactName();
    food.showEvaluate();


}

$(document).ready(function () {
    food.init();
});
