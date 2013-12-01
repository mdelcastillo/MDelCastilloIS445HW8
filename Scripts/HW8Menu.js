$(function () {
    //Add the parent class and arrow to second tier sub-menu
    $("ul.nav li > ul").each(function () {
        var parent = $(this).parent("li");

        parent
          .addClass("parent")
          .find("> a").append("<span class='arrow-down'></span>");
    });

    //Add the parent class and arrow to third tier sub-menu
    $("ul.nav li > ul li > ul").each(function () {
        var parent = $(this).parent("li");

        parent
          .addClass("parent")
          .find("> a span").removeClass("arrow-down").addClass("arrow-right");


        //Adjust the third tier Left value
        $(this).css({
            "left": parent.parent("ul").width() - 25 + "px"
        });
    });

});