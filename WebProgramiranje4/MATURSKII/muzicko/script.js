let zvuci = ["audio.wav","audio.wav","audio.wav","audio.wav","audio.wav","audio.wav",]
var audio
function PlayAudio(arg){
    console.log(arg);
    audio?.pause();
    audio = new Audio(zvuci[arg]);
    audio.play();
}
function PauseAudio(){
    audio.pause();
    console.log("Pauza");
}