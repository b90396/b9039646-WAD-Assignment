// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function dropDown() {

    var ddMenu = document.getElementById("navbar");
    var menuIcon = document.getElementById("burgMenu");

    if (ddMenu.style.display === "block")
    {
        ddMenu.style.display = "none";
        menuIcon.style.transform = 'rotate(' + 0 + 'deg)';
    } else
    {
        ddMenu.style.display = "block";
        menuIcon.style.transform = 'rotate(' + 90 + 'deg)';
    }

}