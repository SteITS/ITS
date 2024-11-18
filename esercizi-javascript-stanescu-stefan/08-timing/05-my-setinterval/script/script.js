/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Re-create setInterval() using setTimeout naming your function mySetInterval
 */

function mySetInterval(callback, delay) {
    let count = 0;
    function intervalFunction() {
        if (count >= 15) { 
            return;
        }
        callback();
        count++;
        setTimeout(intervalFunction, delay);
    }
    setTimeout(intervalFunction, delay); 
}
// Testing the function
mySetInterval(() => {
    console.log("Interval executed");
}, 1000); 