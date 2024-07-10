let gr;

function addNumber(num1,num2){
    let lr = num1+num2;
    gr = num1+num2;
    console.log("Local result in function: "+lr);
    console.log("Global result in function: "+gr);
}

addNumber(8,4)
console.log("Global result: "+gr);
console.log("Local result: "+lr); //lr is not defined;