<!-- @format -->

<template>
  <div>
    <h1>Lista Locais</h1>
    <span>{{ listLocais }}</span>
  </div>
</template>

<script>
  import { mapActions, mapGetters } from 'vuex'

  export default {
    name: 'Locais',
    mounted() {
      this.getLocais()
    },
    methods: {
      ...mapActions('local', ['getLocais'])
    },
    computed: {
      ...mapGetters('local', ['listLocais'])
    }
  }
</script>

<style scoped>
  h1 {
    font-family: 'Jolly Lodger', cursive;
    font-size: 45px;
  }
</style>
