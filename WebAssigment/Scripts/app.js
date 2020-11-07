

$("#clear").click(e => {
    $("#banner").hide(500);
});

function loading() {
    $("[data-loading]").hide();
}

function closeLoading() {
    $("[data-loading]").show();
}