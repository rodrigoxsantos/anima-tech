<!-- @format -->

<template>
  <div id="app">
    <div id="nav">
      <router-link to="/">Personagem</router-link> |
      <router-link to="/episodios">Episódios</router-link> |
      <router-link to="/locais">Locais</router-link> |
      <router-link to="/sobre">Sobre</router-link>
    </div>
    <STYLE>A {text-decoration: none;} </STYLE>
    <router-view />
  </div>
</template>

<style>
  #app {
    font-family: 'Jolly Lodger', cursive;
    font-size: 18px;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
  }

  #nav {
    padding: 30px;
  }

  #nav a {
    font-weight: bold;
    color: #2c3e50;
  }

  #nav a.router-link-exact-active {
    color: #42b983;
  }
</style>
