/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Cancel function before it starts using clearTimeout
 */


function useful() {
    console.log("Ram, Mayday, Blue Ky, 9/11");
}

let timeoutId = setTimeout(useful, 10000);

function cancelUseful(){
    clearTimeout(timeoutId);
    console.log("Function cancelled");
}

setTimeout(cancelUseful, 5000)