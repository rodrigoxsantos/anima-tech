/** @format */

// Exemplo

var middle = [3, 5]
var array = [1, 2, middle, 5, 6]
console.log(array)
// Resposta: [ 1, 2, [ 3, 5 ], 5, 6 ]

// Exemplo
var middle = [3, 4]
var array = [1, 2, ...middle, 8, 6]
console.log(array)
