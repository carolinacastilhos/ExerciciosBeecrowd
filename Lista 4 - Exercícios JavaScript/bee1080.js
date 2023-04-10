var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

var valorMaior = 0;
var posicao = 0;

for (var i = 0; i < 100; i++) {
    const valor = Number(lines[i]);      

    if (valor > valorMaior) {
        valorMaior = valor;
        posicao = i + 1;
    }
}
    
console.log(`${valorMaior}\n${posicao}`)