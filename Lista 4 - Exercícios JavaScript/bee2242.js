var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

// const vogais = (letra) => ['a', 'e', 'i', 'o', 'u'].includes(letra);

// let risada = lines.shift().trim().split('');

// let risadaVogais = risada.filter((x) => vogais(x));
// let invertido = [...risadaVogais];
// risadaVogais = risadaVogais.join('');
// invertido.reverse();
// invertido = invertido.join('');

// if (risadaVogais === invertido) {
//     console.log('S');
// }
// else {
//     console.log('N');
// }


function isVowel(character) {
    switch (character) {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            return true;
        default:
            return false;                
    }
}

function isPalindrome(text) {
    text = toArray(text);
    const middle = Math.floor(text.length/2);
    const firstPos = 0;
    const lastPos = text.length -1;
    for (let i = firstPos, j=lastPos; i < middle; i++, j--) {
        if ((text)[i] != text[j]) {
            return false;
        }
    }
}

function toArray(text) {
    return [...text];
}

laught = [...lines[0]]; //... este operador serve para fazer uma cópia para um vetor
parsed = "";
laught.forEach((c) => {
    if (isVowel(c)) parsed += c;
});

console.log(isPalindrome(parsed) ? "S" : "N");

// sonarLint extensão para avisar boas práticas