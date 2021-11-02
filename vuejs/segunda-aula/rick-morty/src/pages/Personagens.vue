<!-- @format -->

<template>
  <b-container fluid class="back-ground">
    <b-row>
      <h1>Lista de Personages</h1>
      <SearchPersonagem />
    </b-row>
    <CardPersonagem />
  </b-container>
</template>

<script>
  import { mapActions, mapGetters } from 'vuex'
  import CardPersonagem from '../components/CardPersonagem.vue'
  import SearchPersonagem from '../components/SearchPersonagem.vue'

  export default {
    name: 'Personagens',
    components: { CardPersonagem, SearchPersonagem },
    mounted() {
      this.getPersonagens().then(() => {})
    },
    methods: {
      ...mapActions('personagem', ['getPersonagens'])
    },
    computed: {
      ...mapGetters('personagem', ['listPersonagens'])
    }
  }
</script>
<style scoped>
  .back-ground {
    background-color: #8bc6ec;
    background-image: linear-gradient(135deg, #8bc6ec 0%, #9599e2 100%);
  }
  h1 {
    font-family: 'Jolly Lodger', cursive;
    font-size: 45px;
  }

  .title__home {
    color: black;
    margin-top: 16px;
  }
</style>
