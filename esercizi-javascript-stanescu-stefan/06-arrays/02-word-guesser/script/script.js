const word = ["C","A","T"];
let toGuess = ["_","_","_"];
let guessed ="Guessed letters: "

console.log(toGuess);
let tries = 6;
let j = 0;
while (tries != 0){
    if (j==3){
        alert("You won, The word is CAT");
        break
    }
    let uInput = prompt("Guess a letter, you have "+tries+" tries");
    uInput=uInput.toUpperCase();
    guessed=guessed+uInput+","
    console.log(guessed);
    tries--;
    for(let i = 0; i<word.length; i++){
        if(word[i]==uInput){
            toGuess[i]=uInput;
            alert("Guessed correctly");
            console.log(toGuess);
            j++;
        }
    }
}
if (j<3){
    alert("You lost");
}



