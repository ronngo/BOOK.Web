var home1 = {} || home1;

home1.showManufactory = function () {
    $.ajax({
        url: 'https://localhost:44398/api/manufactory/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#Manufactories').append(`<a href="#" class="list-group-item">${v.name}</a>`);
            })

        }
    });
}



home1.initNavManu = function () {
    $.ajax({
        url: 'https://localhost:44398/api/manufactory/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#subNavManu ul').append(`<li class="nav-item">
                                            <a class="nav-link" href="#">${v.name}</a>
                                        </li>`);
            })

        }
    });
}




home1.init = function () {
    home1.showManufactory();
   
   
}

$(document).ready(function () {
    home1.init();
    
});
