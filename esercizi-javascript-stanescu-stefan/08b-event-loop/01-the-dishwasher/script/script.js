/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 *  Simulation of a dishwashing system with three stacks of dirty dishes and one clean stack.
 */


let dirtyStack1 = Array.from({ length: Math.floor(Math.random() * 41) + 10 }, (_, i) => `Plate 1-${i + 1}`);
let dirtyStack2 = Array.from({ length: Math.floor(Math.random() * 41) + 10 }, (_, i) => `Plate 2-${i + 1}`);
let dirtyStack3 = Array.from({ length: Math.floor(Math.random() * 41) + 10 }, (_, i) => `Plate 3-${i + 1}`);
let cleanStack = []; 


let dirtyStacks = [dirtyStack1, dirtyStack2, dirtyStack3];

function washDishes() {
    let washedDishes = 0;

    for (let stack of dirtyStacks) {
        if (stack.length > 0 && washedDishes < 2) {
            const dish = stack.pop();
            cleanStack.push(dish);
            console.log(`Washed ${dish}`);
            washedDishes++;
        }
    }

    if (washedDishes < 2) {
        console.log("Not enough dishes in dirty stacks to wash two at a time.");
    }
}

function displayStacks() {
    console.log("Dirty Stack 1:", dirtyStack1);
    console.log("Dirty Stack 2:", dirtyStack2);
    console.log("Dirty Stack 3:", dirtyStack3);
    console.log("Clean Stack:", cleanStack);
    console.log("----------");
}

// Function to run the washing simulation
function runSimulation() {
    function washNextBatch() {
        // Check if all dirty stacks are empty
        const allClean = dirtyStacks.every(stack => stack.length === 0);
        if (allClean) {
            console.log("All dishes are now clean!");
            displayStacks(); // Final display after all dishes are clean
            return;
        }

        washDishes();
        displayStacks();

        const delay = Math.floor(Math.random() * 1000) + 500;
        setTimeout(washNextBatch, delay);
    }

    washNextBatch(); 
}


runSimulation();