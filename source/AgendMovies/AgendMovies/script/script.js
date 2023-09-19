let header = document.querySelector('header');

window.addEventListener('scroll', () => {
    header.classList.toggle('shadow', window.scrollY > 0);
});





var swiper = new Swiper(".home", {
    spaceBetween: 30,
    centeredSlides: true,
    autoplay: {
        delay: 5000,
        disableOnInteraction: false,
    },
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },

});

// var swiper = new swiper(".embreve-container", {
//   spaceBetween: 20,
//   loop: true,
//   autoplay: {
//     delay: 55000,
//     disableOnInteraction: false,
//   },
//   centeredSlides: true,
//   breakpoints: {
//     0: {
//       slidesPerView: 2,
//     },
//     568: {
//       slidesPerView: 3,
//     },
//     768: {
//       slidesPerView: 4,
//     },
//     968: {
//       slidesPerView: 5,
//     },
//   },
// }),


function menuShow() {
    let menuMobile = document.querySelector('.menu-trocadetela');
    if (menuMobile.classList.contains('open')) {
        menu.Mobile.classList.remove('open');

    }
    else {
        menuMobile.classList.add('open')

    }
}
