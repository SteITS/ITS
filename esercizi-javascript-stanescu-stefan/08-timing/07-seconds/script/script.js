/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * getSecondsToday() returns the number of seconds from the beginning of today
 * getSecondsToTomorrow() returns the number of seconds till tomorrow
 */

function getSecondsToday() {
    const now = new Date();
    const startOfDay = new Date(now.getFullYear(), now.getMonth(), now.getDate());
    const secondsToday = Math.floor((now - startOfDay) / 1000);
    return secondsToday;
}

function getSecondsToTomorrow() {
    const now = new Date();
    const startOfTomorrow = new Date(now.getFullYear(), now.getMonth(), now.getDate() + 1);
    const secondsToTomorrow = Math.floor((startOfTomorrow - now) / 1000);
    return secondsToTomorrow;
}

console.log("Seconds from the beginning of today:", getSecondsToday());
console.log("Seconds until the beginning of tomorrow:", getSecondsToTomorrow());