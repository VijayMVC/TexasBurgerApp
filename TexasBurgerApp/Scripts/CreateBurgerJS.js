$(document).ready(function () {


    var Burger = {

        Bun: {
            ID: null,
            Name: null
        },
        Meat: {
            1: {
                ID: null,
                Name: null
            },
            2: {
                ID: null,
                Name: null
            }
        },
        Green: {
            1: {
                ID: null,
                Name: null
            },
            2: {
                ID: null,
                Name: null
            },
            3: {
                ID: null,
                Name: null
            }
        },
        Cheese: {
            1: {
                ID: null,
                Name: null
            },
            2: {
                ID: null,
                Name: null
            },
            3: {
                ID: null,
                Name: null
            }
        },
        Sauce: {
            1: {
                ID: null,
                Name: null
            },
            2: {
                ID: null,
                Name: null
            },
            3: {
                ID: null,
                Name: null
            }
        },
        Drink: {
            ID: null,
            Name: null
        }
    };


    //Change selected based on click
    $('.bunDisplay').on('click', function (e) {
        e.preventDefault();

        $("#selected-heading").html($(this).data('ing-name'));
        $("#selected-price").html($(this).data('ing-price'));
        var srcString = "/Content/ingridients-images/" + $(this).data('ing-id') + "_" + $(this).data('ing-name') + ".png";
        $("#selected-image").attr("src", srcString);
        $("#selected-btn").attr("data-ing-id", $(this).data('ing-id'));
        $("#selected-btn").attr("data-ing-name", $(this).data('ing-name'));

        if (Burger.Bun.ID == $(this).data('ing-id')) {
            $("#unselect-btn").removeClass('btn-secondary disabled');
        } else {
            $("#unselect-btn").addClass('btn-secondary disabled').html("- Fjern");
        }
    });

    var bunInt = 0;
    //Add selected to burger array based on btn click
    $('#selected-btn').on('click', function (e) {
        e.preventDefault();

        var bunID = $(this).attr("data-ing-id");
        var bunName = $(this).attr("data-ing-name");

        Burger.Bun.ID = bunID;
        Burger.Bun.Name = bunName;

        bunInt = 1;
        $("div[data-ing-id='" + bunID + "']").addClass("selected-bun");

        $('#bun-counter').html(bunInt);

        $(this).addClass("d-none");
        $("#unselect-btn").removeClass("d-none").removeClass("btn-secondary disabled");
        console.log(Burger);
    });
    //Remove selected from burger array based on btn click
    $('body').on('click', '#unselect-btn', function (e) {
        e.preventDefault();
        if (bunInt == 1) {
            $('.bun-item').remove();
        }
        bunInt = 0;
        $("div[data-ing-id='" + Burger.Bun.ID + "']").removeClass("selected-bun");

        $('#bun-counter').html(bunInt);

        $(this).addClass("d-none");
        $("#selected-btn").removeClass("d-none");

        Burger.Bun.ID = null;
        Burger.Bun.Name = null;
        console.log(Burger);
    });




    ////Change selected based on click
    //$('.ingDisplays').on('click', function (e) {
    //    e.preventDefault();

    //    $("#selected-heading").html($(this).data('ing-name'));
    //    $("#selected-price").html($(this).data('ing-price'));
    //    var srcString = "/Content/ingridients-images/" + $(this).data('ing-id') + "_" + $(this).data('ing-name') + ".png";
    //    $("#selected-image").attr("src", srcString);
    //    $("#selected-btn").attr("data-ing-id", $(this).data('ing-id'));
    //    $("#selected-btn").attr("data-ing-name", $(this).data('ing-name'));

    //    if (Burger.Bun.ID == $(this).data('ing-id')) {
    //        $("#unselect-btn").removeClass('btn-secondary disabled');
    //    } else {
    //        $("#unselect-btn").addClass('btn-secondary disabled').html("- Fjern");
    //    }
    //});

    //var bunInt = 0;
    ////Add selected to burger array based on btn click
    //$('#selected-btn').on('click', function (e) {
    //    e.preventDefault();

    //    var bunID = $(this).attr("data-ing-id");
    //    var bunName = $(this).attr("data-ing-name");

    //    Burger.Bun.ID = bunID;
    //    Burger.Bun.Name = bunName;

    //    bunInt = 1;
    //    $("div[data-ing-id='" + bunID + "']").addClass("selected-bun");

    //    $('#bun-counter').html(bunInt);

    //    $(this).addClass("d-none");
    //    $("#unselect-btn").removeClass("d-none").removeClass("btn-secondary disabled");
    //    console.log(Burger);
    //});
    ////Remove selected from burger array based on btn click
    //$('body').on('click', '#unselect-btn', function (e) {
    //    e.preventDefault();
    //    if (bunInt == 1) {
    //        $('.bun-item').remove();
    //    }
    //    bunInt = 0;
    //    $("div[data-ing-id='" + Burger.Bun.ID + "']").removeClass("selected-bun");

    //    $('#bun-counter').html(bunInt);

    //    $(this).addClass("d-none");
    //    $("#selected-btn").removeClass("d-none");

    //    Burger.Bun.ID = null;
    //    Burger.Bun.Name = null;
    //    console.log(Burger);
    //});



});