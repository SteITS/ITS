// Helper functions
function squareNumber(num) {
    return num * num;
}

function halfNumber(num) {
    return num / 2;
}

function percentage(part, whole) {
    return (part / whole) * 100;
}

function circleArea(radius) {
    return Math.PI * radius * radius;
}

// Function to update the solution div
function displayResult(result) {
    const solutionDiv = document.getElementById("solution");
    solutionDiv.textContent = `Result: ${result}`;
}

// Add event listeners for the buttons
document.getElementById("square-button").addEventListener("click", () => {
    const num = parseFloat(document.getElementById("square-input").value);
    const result = squareNumber(num);
    displayResult(result);
});

document.getElementById("half-button").addEventListener("click", () => {
    const num = parseFloat(document.getElementById("half-input").value);
    const result = halfNumber(num);
    displayResult(result);
});

document.getElementById("percent-button").addEventListener("click", () => {
    const part = parseFloat(document.getElementById("percent-input-1").value);
    const whole = parseFloat(document.getElementById("percent-input-2").value);
    const result = percentage(part, whole);
    displayResult(`${result.toFixed(2)}%`);
});

document.getElementById("circle-button").addEventListener("click", () => {
    const radius = parseFloat(document.getElementById("circle-input").value);
    const result = circleArea(radius);
    displayResult(`Area: ${result.toFixed(2)}`);
});

// Add keypress listeners
document.addEventListener("keyup", (event) => {
    if (event.key === "Enter") {
        const squareInput = document.getElementById("square-input");
        const halfInput = document.getElementById("half-input");
        const percentInput1 = document.getElementById("percent-input-1");
        const percentInput2 = document.getElementById("percent-input-2");
        const circleInput = document.getElementById("circle-input");

        if (document.activeElement === squareInput) {
            const result = squareNumber(parseFloat(squareInput.value));
            displayResult(result);
        } else if (document.activeElement === halfInput) {
            const result = halfNumber(parseFloat(halfInput.value));
            displayResult(result);
        } else if (document.activeElement === percentInput1 || document.activeElement === percentInput2) {
            const part = parseFloat(percentInput1.value);
            const whole = parseFloat(percentInput2.value);
            const result = percentage(part, whole);
            displayResult(`${result.toFixed(2)}%`);
        } else if (document.activeElement === circleInput) {
            const result = circleArea(parseFloat(circleInput.value));
            displayResult(`Area: ${result.toFixed(2)}`);
        }
    }
});
