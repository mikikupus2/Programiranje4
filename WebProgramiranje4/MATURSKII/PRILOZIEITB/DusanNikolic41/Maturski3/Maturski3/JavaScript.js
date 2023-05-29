let zvuci = ["/Zvuk/bubanj.mp3", "/Zvuk/gitara.mp3",
    "/Zvuk/harmonika.mp3", "/Zvuk/klavir.mp3", "/Zvuk/truba.mp3", "/Zvuk/violina.mp3",]
var audio
function PlayAudio(arg) {
    console.log(arg);
    audio?.pause();
    audio = new Audio(Zvuk[arg]);
    audio.play();
}
function PauseAudio() {
    audio.pause();
    console.log("Pauza");
}

function Prikazitext(arg) {
    window.location = "#popup" + arg;
}