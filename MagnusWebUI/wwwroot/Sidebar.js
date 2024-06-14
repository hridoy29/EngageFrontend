function sidebarchange() {
    $(".card.sidebarcard").css("width", "250px");
    $(".card.sidebarcard").css("z-index", "3");
    $(".card.sidebarcard").css("overflow", "unset");
    //$("div#sidebar").css("width", "20%");
    $(".card.sidebarcard .list-group").css("opacity", "1");
    $(".card.sidebarcard .list-group").css("transition", "2s");
    $("#sidebar").css("width", "250px");
    $(".preloader").css("margin-left", "-250px");
    //$("li.list-group-item").css("margin-top", "-13px");
    //$("#btn close").removeAttr("hidden");
    //$("#btn close").css("z-index", "2");
    //$(".list-group-item").removeAttr("hidden");
    $(".homepage-Engage").css("margin-left", "250px");
}
function sidebarclose() {
    $(".card.sidebarcard").css("width", "0");
    $("#sidebar").css("width", "0px");
    $(".preloader").css("margin-left", "0px");
    $(".card.sidebarcard").css("overflow", "hidden");
    //$("div#sidebar").css("width", "10%");
    $("#btn close").prop("hidden", true);
    //$(".list-group-item").prop("hidden", true);
    //$("li.list-group-item").css("margin-top", "-0px");
    $('ul.list-group.list-group-flush').css("margin-top", "0px");
    $(".card.sidebarcard .list-group").css("opacity", "0");
    $(".card.sidebarcard .list-group").css("transition", "0.2s");
    $(".homepage-Engage").css("margin-left", "0px");
}
$(document).on('click', function (event) {
    if (!$(event.target).closest('.card.sidebarcard').length) {
        sidebarclose();
    }
});

window.scrollToView = (res) => {
    document.getElementById(res).scrollIntoView({ behavior: 'smooth' })
   
};

function ClearCache() {
    caches.delete("blazor-resources-/").then(function (e) {
        console.log("'blazor-resources-/' cache deleted");
    });
}