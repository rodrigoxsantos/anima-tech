/** @format */
/*
// Exemplo 01
var a = 5
var b = 10
console.log('Quinze é ' + (a + b) + ' e \n não ' + (2 * a + b) + ' ')
*/
//Resposta é: 15  e não 20

// Exemplo 02 - simplificando
var a = 5
var b = 10

const template = `Quinze é ${a + b} e não ${2 * a + b}`

console.log(template)
