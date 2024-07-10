/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Prints the multiplication table from 0 to 10.
 * 
 * The outer loop iterates from 0 to 10, representing the first number in the multiplication.
 * The inner loop iterates from 1 to 10, representing the second number in the multiplication.
 * For each pair of numbers, their product is printed to the console.
 */

for(let i=0;i<=10;i++){
    for(let j=1;j<=10;j++){
        console.log(i*j)
    }
}