/** @format */

//Função

function parImpar(num) {
  if (num % 2 == 0) {
    return `Número ${num} é par.`
  } else {
    return `Número ${num} é ímpar.`
  }
}

console.log(parImpar(4))
console.log(parImpar(7))
