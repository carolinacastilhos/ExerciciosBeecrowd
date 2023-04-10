var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

const [valorA, valorB] = lines[0].split(' ').map(Number);

if (valorA%valorB === 0 || valorB%valorA === 0) {
    console.log(`Sao Multiplos`)
}
else {
    console.log(`Nao sao Multiplos`)
}