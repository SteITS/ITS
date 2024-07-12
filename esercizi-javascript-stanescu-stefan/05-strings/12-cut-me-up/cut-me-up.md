# Differences between `slice()`, `substring()`, and `substr()`

## `slice()`

### Parameters
1. `start`: The zero-based index at which to begin extraction. If negative, it is treated as `str.length + start`.
2. `end` (optional): The zero-based index before which to end extraction. If omitted, extracts to the end of the string. If negative, it is treated as `str.length + end`.

### Behavior
- Extracts a section of a string and returns it as a new string.
- Does not modify the original string.

### Example
```javascript

let str = "Hello, world!";
let result = str.slice(7, 12); // "world"
console.log(result); // Outputs: "world"

let result2 = str.slice(-6, -1); // "world"
console.log(result2); // Outputs: "world"

substring()
```
Parameters

    start: The zero-based index at which to begin extraction.
    end (optional): The zero-based index before which to end extraction. If omitted, extracts to the end of the string.

Behavior

    Extracts characters from start to end (not including end).
    If start is greater than end, it swaps the two arguments.
    Treats negative values as 0.

Example

javascript

let str = "Hello, world!";
let result = str.substring(7, 12); // "world"
console.log(result); // Outputs: "world"

let result2 = str.substring(12, 7); // "world"
console.log(result2); // Outputs: "world"

let result3 = str.substring(-5, 5); // "Hello"
console.log(result3); // Outputs: "Hello"

substr()
Parameters

    start: The zero-based index at which to begin extraction. If negative, it is treated as str.length + start.
    length (optional): The number of characters to extract. If omitted, extracts to the end of the string.

Behavior

    Extracts a specified number of characters from a string, starting from start.
    Does not modify the original string.
    substr() is considered a legacy function and may not be available in all JavaScript environments.

Example

javascript

let str = "Hello, world!";
let result = str.substr(7, 5); // "world"
console.log(result); // Outputs: "world"

let result2 = str.substr(-6, 5); // "world"
console.log(result2); // Outputs: "world"

Summary

    slice(start, end): Uses both positive and negative indices. If negative, counts from the end of the string.
    substring(start, end): Swaps start and end if start is greater than end. Treats negative values as 0.
    substr(start, length): Uses a start index and length to determine the substring. If negative, counts from the end of the string. Considered a legacy method.