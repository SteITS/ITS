/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Replaces the first 'not'...'bad' substring in a sentence with 'good' if 'bad' follows 'not'.
 *
 * @param {string} sentence - The input string to process.
 * @returns {string} The modified string with 'not'...'bad' replaced by 'good', or the original string if no replacement is made.
 */
function notBad(st) {
    const notIndex = st.indexOf('not');
    const badIndex = st.indexOf('bad');
    
    if (notIndex !== -1 && badIndex !== -1 && badIndex > notIndex) {
        return st.slice(0, notIndex) + 'good' + st.slice(badIndex + 3);
    }
    
    return st;
}

// Example usage:
console.log(notBad('This dinner is not that bad!')); 
console.log(notBad('This movie is not so bad!'));    
console.log(notBad('This dinner is bad!'));          
console.log(notBad('It is not bad at all.'));        
console.log(notBad('This is not good.'));