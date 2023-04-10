var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input;

const valor = Number(lines[0]);

var valor1 = 1;

for (var i = 0; i < valor*2; i++) {
    console.log(`${valor1} ${valor1**2 + (i%2)} ${valor1**3 + (i%2)}`);
    valor1 += i%2;
}