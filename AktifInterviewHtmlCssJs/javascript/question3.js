const inputString = "Hello, World!";

function reverseString(inputString) {
    let returnedString = "";
    for (let i = inputString.length - 1; i >= 0; i--) {
        let char = inputString[i];
        returnedString += char;
    }

    return returnedString;
}

console.log(reverseString(inputString));