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
str1="Mary, James, and John";
str2="James";
str3="Philip";
bool=aConstainsb(str1,str2);
if (bool == true){
    console.log(str2+" is part of the group");
}else{
    console.log(str2+" is NOT part of the group");
}

bool=aConstainsb(str1,str3);
if (bool == true){
    console.log(str3+" is part of the group");
}else{
    console.log(str3+" is NOT part of the group");
}
