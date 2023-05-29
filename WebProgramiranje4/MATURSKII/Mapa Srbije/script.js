let zvuci = [
    "https://upload.wikimedia.org/wikipedia/commons/transcoded/d/dd/National_anthem_of_Serbia%2C_performed_by_the_United_States_Navy_Band.wav/National_anthem_of_Serbia%2C_performed_by_the_United_States_Navy_Band.wav.mp3",
    "https://upload.wikimedia.org/wikipedia/commons/transcoded/d/df/Lijepa_nasa_domovino_instrumental.ogg/Lijepa_nasa_domovino_instrumental.ogg.mp3",
    "https://upload.wikimedia.org/wikipedia/en/transcoded/d/dd/Bosnia_and_Herzegovina%27s_national_anthem.ogg/Bosnia_and_Herzegovina%27s_national_anthem.ogg.mp3",
    "https://upload.wikimedia.org/wikipedia/commons/7/79/Hungarian_national_anthem%2C_performed_by_the_United_States_Navy_Band_%281997_arrangement%29.mp3",
    "https://upload.wikimedia.org/wikipedia/commons/transcoded/a/a2/National_Anthem_of_Montenegro.ogg/National_Anthem_of_Montenegro.ogg.mp3",
    "https://upload.wikimedia.org/wikipedia/commons/transcoded/5/52/Hymni_i_Flamurit_instrumental.ogg/Hymni_i_Flamurit_instrumental.ogg.mp3",
    "https://upload.wikimedia.org/wikipedia/commons/transcoded/4/4f/Mila_Rodino_instrumental.ogg/Mila_Rodino_instrumental.ogg.mp3",
    "https://upload.wikimedia.org/wikipedia/commons/transcoded/7/77/Desteapta-te%2C_romane%21.ogg/Desteapta-te%2C_romane%21.ogg.mp3",
    "https://upload.wikimedia.org/wikipedia/en/b/b6/North_Macedonia%27s_national_anthem_%28instrumental%29.ogg"]
let audio
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