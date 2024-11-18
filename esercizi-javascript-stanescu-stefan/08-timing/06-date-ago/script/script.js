/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * getDateAgo(date, days) that returns the day of the month
 * n days ago from the given date
 */

function getDateAgo(date, days) {
    const resultDate = new Date(date); 
    resultDate.setDate(resultDate.getDate() - days); 
    return resultDate.getDate(); 
}

// Testing the function
const today = new Date();

console.log("Today is:", today);
console.log("1 day ago:", getDateAgo(today, 1));
console.log("2 days ago:", getDateAgo(today, 2)); 
console.log("30 days ago:", getDateAgo(today, 30)); 
console.log("5 days in the future:", getDateAgo(today, -5));