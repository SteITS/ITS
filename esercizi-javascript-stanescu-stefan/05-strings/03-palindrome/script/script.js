/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * A palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward (ignoring spaces, punctuation, and capitalization).
 *
 * @param {string} st - The string to be checked.
 * @returns {boolean} - Returns true if the string is a palindrome, otherwise false.
 */

function isPalindrome(st){
    let str = "";
    for (let i = st.length-1; i >= 0 ; i--) {
        str += st[i];
        
    }
    if(st==str){
        return true;
    }else
        return false;
}

let st="civic";
let st1="rezzacapa";
console.log(isPalindrome(st));
console.log(isPalindrome(st1));