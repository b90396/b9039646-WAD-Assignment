

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

var slideIndex = 0;
showSlides();

function showSlides() {
    var i;
    var slides = document.getElementsByClassName("Slides");
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slideIndex++;
    if (slideIndex > slides.length) { slideIndex = 1 }
    slides[slideIndex - 1].style.display = "block";
    setTimeout(showSlides, 3500);
}

function toTop() {

    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;

}
