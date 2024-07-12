/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Formats a number as a string representing an amount of money in dollars.
 *
 * If the number is exactly 1,000,000, it appends a special message ":)".
 * Otherwise, it just appends "Dollars".
 *
 * @param {number} n - The amount of money to format.
 * @returns {string} The formatted money string.
 */

function money(n){
    st=""
    if (n==1000000)
        st=n+" Dollars :)";
    else
        st=n+" Dollars";
    return st;
}

str=money(Math.floor(Math.random() * 1000001));
str1=money(1000000);
console.log(str);
console.log(str1);