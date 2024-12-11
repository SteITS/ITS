let noisesArray = ['quack', 'sneeze', 'boom'];
let resultArray = [];

noisesArray.forEach(noise => {
    for (let i = 0; i < noise.length; i++) {
        let modifiedNoise = noise.slice(0, i) + noise[i].toUpperCase() + noise.slice(i + 1);
        modifiedNoise += '!'.repeat(i + 1);

        resultArray.push(modifiedNoise);
    }
});

console.log(resultArray);
