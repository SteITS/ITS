/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Reverses the characters in the given string and returns the reversed string.
 *
 * @param {string} st - The string to be reversed.
 * @returns {string} - The reversed string.
 */

function Reverse(st){
    let str = "";
    for (let i = st.length-1; i >= 0 ; i--) {
        str += st[i];
        
    }
    return str;
}

let st="snomekoP era snakE & kobrA";
let st1 = Reverse(st);
console.log(st1);