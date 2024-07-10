/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Returns a greeting in the specified language.
 * @param {string} ct - The language code for the greeting ("en" for English, "it" for Italian, "ro" for Romanian).
 * @returns {string} - A greeting in the specified language. Defaults to English if the language code is not recognized.
 */

function helloWorld(ct){
    switch(ct){
        case "en":
            return "Hello,World";
        case "it":
            return "Ciao,Mondo";
        case "ro":
            return "Buna,Lume";
        default:
            return "Hello,World";
    }
}

let st = "";
st=helloWorld("en",st);
console.log(st);
st=helloWorld("ro",st);
console.log(st);
st=helloWorld("it",st);
console.log(st);
st=helloWorld("ru",st);
console.log(st);