var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

const [valorA, valorB, valorC] = lines[0].split(' ').map(Number);

const delta = Math.pow(valorB,2) - (4*valorA*valorC);

if (delta < 0 || valorA === 0) {
    console.log(`Impossivel calcular`)
}else{
    const raiz1 = (-valorB + Math.sqrt(delta))/(2*valorA);
    const raiz2 = (-valorB - Math.sqrt(delta))/(2*valorA);
    console.log(`R1 = ${raiz1.toFixed(5)}`)
    console.log(`R2 = ${raiz2.toFixed(5)}`)   
}

