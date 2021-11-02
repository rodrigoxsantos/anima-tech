/** @format */

class Retangulo {
  constructor(altura, largura) {
    this.altura = altura
    this.largura = largura
  }

  calculaArea() {
    return this.altura * this.largura
  }

  get area() {
    return this.calculaArea()
  }
}

const objeto = new Retangulo(5, 5)

console.log(objeto)
console.log(`Área do objeto = ${objeto.area}`)
