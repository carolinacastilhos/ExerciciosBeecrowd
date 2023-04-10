var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

const valorA = Number(lines[0]);
const valorB = Number(lines[1]);

if (valorA > valorB) {
    var menor = valorB;
    var maior = valorA;
}
else {
    var menor = valorA;
    var maior = valorB;
}

soma = 0;

for (var i = menor; i <= maior; i++) {
    if (i%13 != 0){
        soma += i;
    }

}

console.log(soma)

