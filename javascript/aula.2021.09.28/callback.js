/** @format */

// Exemplo 01
/*
function primeiroBloco(){
    setTimeout(function(){
        console.log('Esse é o primeiro bloco após 5 segundos!')
    }, 5000)
}
function segundoBloco(){
    console.log('Esse é o segundo bloco de comandos!')
}
*/

//primeiroBloco()
//segundoBloco()

//Exemplo 02
function exibirMensagemNaOrdem(mensagem, callback) {
  console.log(mensagem)
  callback()
}
exibirMensagemNaOrdem('Essa é a primeira mensagem na ordem', function () {
  console.log('Essa é a segunda mensagem na ordem ')
})
