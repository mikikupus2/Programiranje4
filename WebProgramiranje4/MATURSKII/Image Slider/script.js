let slideIndex = 1;
let timeout;
const currentSlide = (n) => {
  clearTimeout(timeout);
  showSlides((slideIndex = n));
};

const showSlides = () => {
  let i;
  let slides = document.getElementsByClassName("mySlides");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  slideIndex++;
  if (slideIndex > slides.length) {
    slideIndex = 1;
  }
  slides[slideIndex - 1].style.display = "block";
  timeout = setTimeout(showSlides, 3000);
};
showSlides(slideIndex);
