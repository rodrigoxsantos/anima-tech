<!-- @format -->

<template>
  <div class="about">
    <h1>Lista de Episodio</h1>
    <span>{{ listEpisodios }}</span>
  </div>
</template>

<script>
  import { mapActions, mapGetters } from 'vuex'

  export default {
    name: 'Episodios',
    mounted() {
      this.getEpisodios()
    },
    methods: {
      ...mapActions('episodio', ['getEpisodios'])
    },
    computed: {
      ...mapGetters('episodio', ['listEpisodios'])
    }
  }
</script>

<style scoped>
  h1 {
    font-family: 'Jolly Lodger', cursive;
    font-size: 45px;
  }
</style>
