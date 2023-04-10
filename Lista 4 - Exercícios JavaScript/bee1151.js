var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input;

const valor = Number(lines[0]);

var num1 = 0;
var num2 = 1;
var output = "";

for (var i = 0; i < valor; i++) {
    if (i === valor-1) {
        output += num1;      
    }
    else {
        output += num1 + " ";        
    }

    var num3 = Number(num1+num2);
    num1 = num2;
    num2 = num3;
}

console.log(output)
