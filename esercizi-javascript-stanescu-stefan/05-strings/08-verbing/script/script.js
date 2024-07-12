/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Adds 'ing' to the end of a given string if its length is at least 3 and it doesn't already end with 'ing'.
 * If the string already ends with 'ing', it adds 'ly' instead.
 * If the string length is less than 3, it returns the string unchanged.
 *
 * @param {string} st - The input string to modify.
 * @returns {string} The modified string with 'ing' or 'ly' added as appropriate.
 */
function verbing(st){
    if(st.length>=3){
        if((st.charAt(st.length-3)+st.charAt(st.length-2)+st.charAt(st.length-1))!="ing"){
            st=st+"ing";
        }else{
            st=st+"ly";
        }
    }
    return st;
}

st=verbing("swim");
st1=verbing("swimming");
console.log(st)
console.log(st1)