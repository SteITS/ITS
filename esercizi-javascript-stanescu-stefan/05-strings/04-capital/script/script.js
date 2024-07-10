/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Capitalizes the first letter of each word in the given string.
 *
 * @param {string} st - The string to be capitalized.
 * @returns {string} - The string with the first letter of each word capitalized.
 */

function capital(st){
    st=st.split(" ");
    let fin = "";
    for(i=0; i<st.length;i++){
        st[i]=st[i].charAt(0).toUpperCase() + st[i].slice(1);
        fin=fin + st[i] + " ";
    }
        return fin;
}

let st = "ciao questa e' una prova";
st=capital(st);
console.log(st);