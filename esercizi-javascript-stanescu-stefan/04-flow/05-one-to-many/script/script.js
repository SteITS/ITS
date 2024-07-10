/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Returns a string that correctly pluralizes the given noun based on the number provided.
 * @param {number} num - The number of items.
 * @param {string} noun - The noun to be pluralized.
 * @returns {string} - A string that combines the number and the correctly pluralized noun.
 */

function oneToMany(num,noun){
    let st;
    if(num>1){
        st=num+" "+noun+"s";
    }
    else{
        st= num+" "+noun;
    }
    return st;
}

let st
st=oneToMany(2,"cat");
console.log(st);
st=oneToMany(1,"snake")
console.log(st)
st=oneToMany(5,"rabbit")
console.log(st)