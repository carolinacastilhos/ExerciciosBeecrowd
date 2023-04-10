var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

const [valorA, valorB, valorC] = lines[0].split(' ').map(Number);

var maior = valorA
if (valorB > maior) {
    maior = valorB
}
if (valorC > maior) {
    maior = valorC
}

var menor = valorA
if (valorB < menor) { 
    menor = valorB
}
if (valorC < menor) {
    menor = valorC
}

var meio = valorA + valorB + valorC - maior - menor 

console.log(menor)
console.log(meio)
console.log(maior)
console.log()
console.log(valorA)
console.log(valorB)
console.log(valorC)

//console.log(`${menor}\n${meio}\n${maior}\n\n${valorA}\n${valorB}\n${valorC}`)

