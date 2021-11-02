/** @format */

// Realiza uma busca por uma ocorrência entre uma expressão regular e uma String.
var valores = [5, 8, 10, 22, 38, 45, 60, 90, 100, 120]

function search(num) {
  for (i = 0; i < 6; i++) {
    if (num == valores[i]) {
      return i
    }
  }
  return -1
}

function binSearch(num) {
  let inicio, fim
  let meio
  let passos = 0
  inicio = 0
  fim = 9

  while (inicio < fim) {
    meio = parseInt((inicio + fim) / 2)
    passos = passos + 1
    if (num == valores[meio]) {
      console.log('Achei em ' + passos + ' passos!')
      return meio
    } else {
      if (num > valores[meio]) {
        inicio = meio + 1
      } else {
        fim = meio - 1
      }
    }
  }
  console.log('Nao achei em ' + passos + ' passos!')
  return -1
}

console.log(search(10))

console.log(search(50))

console.log(binSearch(10))
console.log(binSearch(90))