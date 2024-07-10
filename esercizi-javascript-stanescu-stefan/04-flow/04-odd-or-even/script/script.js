/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Prints whether numbers from 0 to 20 are even or odd.
 * The loop iterates from 0 to 20. For each number, it checks if the number is even or odd
 * by using the modulus operator. It then prints a message indicating whether the number
 * is even or odd.
 */
for(let i=0;i<=20;i++){
    if(i%2===0){
        console.log(i+" is even")
    }else{
        console.log(i+" is odd")
    }
}