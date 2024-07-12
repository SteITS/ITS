/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Takes a string and returns a version where all occurrences of its first character
 * are replaced with '*', except for the first character itself.
 *
 * @param {string} str - The string to fix.
 * @returns {string} The fixed string with '*' replacing all occurrences of the first character except the first one.
 */
function fixStart(str) {
    // Get the first character of the string
    const firstChar = str[0];
    // Replace all occurrences of the first character (except the first one) with '*'
    const regex = new RegExp(firstChar, 'g');
    const fixedStr = str[0] + str.slice(1).replace(regex, '*');
    return fixedStr;
}

// Example usage:
console.log(fixStart('babble')); // Outputs: 'ba**le'
console.log(fixStart('google')); // Outputs: 'goo*le'