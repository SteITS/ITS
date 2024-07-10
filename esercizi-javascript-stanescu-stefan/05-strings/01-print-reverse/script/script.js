/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Reverses the characters in the given string and returns the reversed string.
 *
 * @param {string} st - The string to be reversed.
 * @returns {string} - The reversed string.
 */

function printReverse(st){
    return st.split('').reverse().join('');
}

let st="snake & kobra";
let st1 = printReverse(st);
console.log(st1);