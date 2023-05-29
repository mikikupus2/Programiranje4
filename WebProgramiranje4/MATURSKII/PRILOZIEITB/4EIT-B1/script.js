const PromeniGlavnuSliku = (izvor_slike, adresa_fajla) => {
  let adrese = [
    "Tekst/Artemidin_Hram.txt",
    "Tekst/Faros_U_Aleksandriji.txt",
    "Tekst/Kolos_Sa_Radosa.txt",
    "Tekst/Mauzolej_U_Halikarnasu.txt",
    "Tekst/Piramide_U_Gizi.txt",
    "Tekst/Statua_Zevsa.txt",
    "Tekst/Viseci_Vrtovi.txt",
  ];
  const paragraf = document.getElementById("main-image-caption");
  const glavna_slika = document.getElementById("main-image");
  glavna_slika.src = izvor_slike;
  fetch(adrese[parseInt(adresa_fajla)])
    .then((response) => response.text())
    .then((data) => (paragraf.innerHTML = data))
    .catch(
      (error) => (paragraf.innerHTML = "Није могуће прочитати из фајла!!!")
    );
};
