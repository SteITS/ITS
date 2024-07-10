/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Assigns a grade based on the given number.
 * @param {number} num - The number to determine the grade.
 * @returns {string} - The grade corresponding to the given number.
 */

function assignGrade(num){
    switch(num){
        case 1 :
            return "Your grade is F";
        case 2 :
            return "Your grade is F";
        case 3:
            return "Your grade is D";
        case 4:
            return "Your grade is D";
        case 5:
            return "Your grade is C";
        case 6:
            return "Your grade is C";
        case 7:
            return "Your grade is B";
        case 8:
            return "Your grade is B";
        case 9:
            return "Your grade is A";
        case 10:
            return "Your grade is A";
    }
}

/*let st="";
st=assignGrade(2)
st=assignGrade(4)
st=assignGrade(6)
st=assignGrade(8)
st=assignGrade(10)
*/
for(let i=0;i<=10;i++){
    st=assignGrade(i);
    console.log(st);
}