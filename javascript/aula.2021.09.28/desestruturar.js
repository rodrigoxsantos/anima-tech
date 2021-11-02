/** @format */

var a, b, rest
;[a, b, ...rest] = [1, 2, 3, 4, 5]
console.log(a)
console.log(b)
console.log(rest)

//
var c, d, rest2
;({ c, d } = { c: 1, d: 2 })

console.log(c)

console.log(d)
// 'rest2' não irá recebe nada -> undefined
console.log(rest2)
