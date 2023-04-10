var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

const valor = Number(lines[0]);


    for (let i = 1; i <= valor; i++) {
        if (i%2 === 0) {                        
        console.log(`${i}^2 = ${Math.pow(i,2)}`)

        }
    }

