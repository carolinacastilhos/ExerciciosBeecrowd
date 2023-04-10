var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

const numeroTeste = Number(lines[0]);

var somaIn = 0;
var somaOut = 0;

for (let i = 1; i <= numeroTeste; i++) {
    var num = Number(lines[i]);
    
    if (num >= 10 && num <= 20 ) {
        somaIn += 1;
    }
    else {
        somaOut += 1;
    }
   
}

console.log(`${somaIn} in`);
console.log(`${somaOut} out`);