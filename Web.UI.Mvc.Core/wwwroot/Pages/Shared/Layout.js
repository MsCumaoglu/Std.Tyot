$(document).ready(function () {
    var width = $(window).width();
    if (width > 1200) {
        $("#main-nav").addClass(".col-lg-7");
        $("#account-nav").addClass(".col-lg-2");
    } else {
        $("#main-nav").addClass(".col-md-8");
        $("#account-nav").addClass(".col-md-1");
    }
});
