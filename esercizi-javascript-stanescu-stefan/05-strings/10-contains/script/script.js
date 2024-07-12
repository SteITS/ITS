/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Checks if the first string contains the second string.
 *
 * @param {string} str1 - The string to be searched.
 * @param {string} str2 - The string to search for.
 * @returns {boolean} True if the first string contains the second string, otherwise false.
 */
function aConstainsb(st,wo) {

    return st.includes(wo);
}

bool=aConstainsb("Another hello world","bab");
console.log(bool);
bool=aConstainsb("Another hello world","world");
console.log(bool);