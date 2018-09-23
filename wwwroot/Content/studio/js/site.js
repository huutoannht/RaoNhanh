$(function () {
    $('.partialContents').each(function (index, item) {
        var url = $(item).data("url");
        if (url && url.length > 0) {
            $(item).load(url);
        };
    })
    $('a.category').click(function () {
        var url = $(this).data("url");
        if (url && url.length > 0) {
            $(item).load(url);
        };
    })
})