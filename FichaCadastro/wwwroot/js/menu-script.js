$(document).ready(function () {
    $(".item, .sub-item").on("click", function () {

        if ($(this).hasClass("has-son")) {
            var current = $(".sub-item");
            if (current.hasClass("selected")) {
                current.removeClass("selected")
            }
            else {
                current.addClass("selected")
            }
            return;
        }
        else {
            var className = $(this).attr("id")
            document.getElementById("iframe").src = `./iframes/${className}.html`
            console.log("Ok ")
        }

    })

    $(".item, .sub-item").on("mouseover", function () {
        var current = $(this);
        current.css("box-shadow", "inset 0 0 1em #646569")
    })
    $(".item, .sub-item").on("mouseout", function () {
        var current = $(this);
        current.css("box-shadow", "0 0 1em #646569")
    })

})
