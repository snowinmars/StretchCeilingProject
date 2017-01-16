(function () {
    var carousel = $(".carousel-inner");
    carousel.children().first().addClass("active");
    carousel.carousel();

    var cellings = $(".cellingNavTab");
    cellings.children().first().addClass("active");

    $("#myTabExample a:last").tab("show");
})();