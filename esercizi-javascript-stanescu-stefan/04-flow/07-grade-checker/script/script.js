/**
 * @file: script.js
 * @author: Stefan Stanescu
 * Assigns a grade based on the given numeric score.
 * @assignGrade {num} num - The numeric score to determine the grade.
 * @returns {string st}  - The grade corresponding to the given numeric score.
 */
function assignGrade(num){
    let st;
    if(100>=num && num>=90){
        st="for "+num+" you got a A";
    }else if(90>num && num>=80){
        st="for "+num+" you got a B";
    }else if(80>num && num>=70){
        st="for "+num+" you got a C";
    }else if(70>num && num>=65){
        st="for "+num+" you got a D";
    }else if(65>num && num>=60){
        st="for "+num+" you got a F";
    }else{
        st=num +" is an incorrect input"
    }
    return st;
}

for(i=55;i<=100;i++){
    st=assignGrade(i);
    console.log(st);
}