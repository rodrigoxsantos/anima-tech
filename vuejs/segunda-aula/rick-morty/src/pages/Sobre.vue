<!-- @format -->

<template>
  <div id="sobre">
    <h1>Sobre</h1>
    <h2>O que é isso?</h2>
    <p>
      A API Rick and Morty é uma API REST (ish) e GraphQL baseada no programa de
      televisão
      <a
        href="https://www.adultswim.com/videos/rick-and-morty"
        target="_blank"
        rel="nofollow noopener noreferrer"
        ><font style="vertical-align: inherit;"
          ><font style="vertical-align: inherit;">Rick and Morty</font></font
        ></a
      >
      . Você terá acesso a cerca de centenas de personagens, imagens, locais e
      episódios. A API de Rick e Morty está repleta de informações canônicas,
      conforme visto no programa de TV.
    </p>
    <p>
      <a href="https://rickandmortyapi.com/documentation/"
        ><font style="vertical-align: inherit;"
          ><font style="vertical-align: inherit;"
            >Verifique a documentação para começar</font
          ></font
        ></a
      >
    </p>

    <h2>Por que você construiu isso?</h2>
    <p>
      Porque estávamos realmente interessados ​​na ideia de escrever um projeto
      de código aberto e também porque Rick e Morty é nosso programa favorito
      naquele momento, então por que não?
    </p>
    <h2>Coisas técnicas</h2>
    <p>
      Usamos Node e MongoDB para servir a API. Todos os dados são formatados em
      json e todo o projeto está hospedado no Digital Ocean e Netlify .
    </p>
    <h2>Direito autoral</h2>
    <p>
      Rick and Morty é criado por Justin Roiland e Dan Harmon para Adult Swim .
      Os dados e imagens são usados ​​sem reclamação de propriedade e pertencem
      aos seus respectivos proprietários.
    </p>
  </div>
</template>

<script>
  export default {
    name: 'Sobre'
  }
</script>

<style scoped>
  h1 {
    font-family: 'Jolly Lodger', cursive;
    font-size: 45px;
  }
</style>
