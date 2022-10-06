// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
showmodal = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#newstaticBackdrop .modal-body").html(res);
            $("#newstaticBackdrop .modal-title").html(title);
            $("#newstaticBackdrop").modal('show');
        }
    })
}
showlogin = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#newstaticBackdrop .modal-body").html(res);
            $("#newstaticBackdrop .modal-title").html(title);
            $("#newstaticBackdrop").modal('show');
        }
    })
}