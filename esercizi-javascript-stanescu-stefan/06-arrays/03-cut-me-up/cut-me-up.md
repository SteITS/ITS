# Difference Between `slice()` and `splice()` Array Methods

## Overview

JavaScript provides various methods to manipulate arrays. Two commonly used methods are `slice()` and `splice()`. Though they might sound similar, they serve different purposes and have distinct behaviors.

## `slice()` Method

### Parameters

1. **start**: The beginning index from where to start the extraction.
2. **end** (optional): The ending index before which to end the extraction. The element at this index is not included.

### Behavior

- **Non-destructive**: Does not modify the original array but returns a new array containing the extracted elements.
- Can be used to create a shallow copy of a portion of an array.

### Example

\`\`\`javascript
let fruits = ['Apple', 'Banana', 'Cherry', 'Date', 'Fig'];

let slicedFruits = fruits.slice(1, 3);

console.log(slicedFruits); // Output: ['Banana', 'Cherry']
console.log(fruits);       // Output: ['Apple', 'Banana', 'Cherry', 'Date', 'Fig']
\`\`\`

## `splice()` Method

### Parameters

1. **start**: The index at which to start changing the array.
2. **deleteCount**: The number of elements to remove from the start index.
3. **item1, item2, ...** (optional): The elements to add to the array, beginning from the start index.

### Behavior

- **Destructive**: Modifies the original array by removing or replacing existing elements and/or adding new elements.
- Can be used to remove elements, add new elements, or replace elements in an array.

### Example

\`\`\`javascript
let vegetables = ['Carrot', 'Potato', 'Tomato', 'Cucumber', 'Peas'];

let splicedVegetables = vegetables.splice(2, 2, 'Broccoli', 'Spinach');

console.log(splicedVegetables); // Output: ['Tomato', 'Cucumber']
console.log(vegetables);        // Output: ['Carrot', 'Potato', 'Broccoli', 'Spinach', 'Peas']
\`\`\`

## Key Differences

- **Mutability**: `slice()` does not alter the original array, whereas `splice()` does.
- **Purpose**: `slice()` is used for extracting a portion of an array, and `splice()` is used for adding/removing/replacing elements within an array.
- **Return Value**: `slice()` returns a new array with the extracted elements, while `splice()` returns an array of the deleted elements (if any).
