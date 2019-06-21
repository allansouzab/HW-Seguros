var navbarInverse = document.getElementById('navbar-inverse');
//var navbarBrand = document.getElementById('navbar-brand');
var navbarAbout = document.getElementById('about');
var navbarServices = document.getElementById('services');
var navbarContact = document.getElementById('contact');
var navbarCot = document.getElementById('cotacoes');

var numPx = '50';

window.addEventListener('scroll', function () {
    if (window.scrollY > numPx) {
        navbarInverse.classList.add('mudaCorNavbar');
        //navbarBrand.classList.add('mudaCorText');
        navbarAbout.classList.add('mudaCorText');
        navbarServices.classList.add('mudaCorText');
        navbarContact.classList.add('mudaCorText');
        navbarCot.classList.add('mudaCorText');
    } else {
        navbarInverse.classList.remove('mudaCorNavbar');
        //navbarBrand.classList.remove('mudaCorText');
        navbarAbout.classList.remove('mudaCorText');
        navbarServices.classList.remove('mudaCorText');
        navbarContact.classList.remove('mudaCorText');
        navbarCot.classList.remove('mudaCorText');
    }
});