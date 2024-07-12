/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Takes two strings and returns the concatenation of the two strings (separated by a space)
 * with the first two characters of each string swapped.
 *
 * @param {string} str1 - The first string to mix up.
 * @param {string} str2 - The second string to mix up.
 * @returns {string} The mixed up string with swapped first two characters of each input string.
 */
function mixUp(str1, str2) {
    const firstPartStr1 = str1.slice(0, 2);
    const firstPartStr2 = str2.slice(0, 2);

    const restStr1 = str1.slice(2);
    const restStr2 = str2.slice(2);

    return firstPartStr2 + restStr1 + " " + firstPartStr1 + restStr2;
}

console.log(mixUp('hello', 'world'));
console.log(mixUp('ab', 'cd')); 