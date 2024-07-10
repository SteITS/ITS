/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Compares two numbers and prints which one is greater.
 * @param {number} num1 - The first number to compare.
 * @param {number} num2 - The second number to compare.
 */

function greaterNum(num1,num2){
    if(num1>num2){
        console.log(num1+" is greater than "+num2)
    }else{
        console.log(num2+" is greater than "+num1)
    }
}

greaterNum(8,4)
greaterNum(10,22)