$(document).ready(function() {
    $(window).bind("scroll", function(e) {
        var top = $(window).scrollTop();
        if (top > 144) { //Khoảng cách đã đo được
            console.log('đã chạy');
            $(".sidebar_left").addClass("fix-box");
        } else {
            $(".sidebar_left").removeClass("fix-box");
        }
    });
});