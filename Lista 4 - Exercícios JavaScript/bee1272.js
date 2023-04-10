var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

const valor = Number(lines[0]);

for(let i = 1; i <= valor; i += 1) {
  const entrada = lines[i].split(' ')
  const mensagem = entrada.map(x => x[0] || '').filter(x => x).join('');
  console.log(mensagem)
}