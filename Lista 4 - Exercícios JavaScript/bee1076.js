var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

//arestas = quantidade de movimentos 
//grafo: representação geométrica de relacionamentos 
//não haverá ciclo - se houvesse, pensaríamos em caminho mínimo.
// neste caso, de não haver ciclo, todo caminho terá ida e volta


const inicio = parseInt(lines[0]);
const [v, a] = lines[1].split("\n");

const vertices = parseInt(v);
const arestas = parseInt(a);
let indexLinha = 2;

function lerProximaAresta() {
    aresta = linha = lines[indexLinha].split(" ");
    indexLinha++;
    return {
        in: parseInt(aresta[0]),
        out: parseInt(aresta[1]),

    };
}

let matriz = new Array(vertices);

for(let i = 0; i<matriz.length; i++) {
    matriz[i] = new Array(vertices);
}

function 

// let grafo = new Array(vertices);
// grafo.map((pos) => new Array(vertices));


// for (let i = 0; i< arestas; i++) {
//     conexao = lerProximaAresta();
// }


// console.log(`vertices: ${vertices} | arestas: ${arestas}`);

// const tamanho = 5;