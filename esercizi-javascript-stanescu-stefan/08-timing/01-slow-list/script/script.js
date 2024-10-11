/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Array of 30 elemements, logs each row once every 200ms, using setInterval() and setTimeout()
 */

const guiltyGearCharacters = [
    "Sol Badguy", "Ky Kiske", "May", "Axl Low", "Chipp Zanuff", "Potemkin", "Faust",
    "Millia Rage", "Zato-1", "Ramlethal Valentine", "Leo Whitefang", "Nagoriyuki",
    "Giovanna", "Anji Mito", "I-No", "Goldlewis Dickinson", "Jack-O'", "Happy Chaos",
    "Baiken", "Testament", "Bridget", "Sin Kiske", "Bedman?", "Asuka R#", 
    "Johnny", "Slayer", "Jam Kuradoberi", "Dizzy", "Venom", "Elphelt Valentine"
];

function printCharactersWithInterval() {
    let index = 0;
    setInterval(() => {
        if(index < guiltyGearCharacters.length){
            console.log(guiltyGearCharacters[index]);
            index++;
        }
    },200);
}

function printCharactersWithTimeout() {
    for (let i = 0; i < guiltyGearCharacters.length; i++) {
        setTimeout(() => {
            console.log(guiltyGearCharacters[i]);
        }, i*200);
        
    }
}

setTimeout(printCharactersWithInterval,5);

setTimeout(printCharactersWithTimeout, 7500)