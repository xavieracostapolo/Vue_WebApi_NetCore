<template>
  <div>
    <b-card header-tag="header" footer-tag="footer" header-bg-variant="info" header-text-variant="white">
      <h6 slot="header" class="mb-0">Amount</h6>
      <h2>Valor total: <b-badge>{{ totalTransaction | currency('€') }}</b-badge></h2>
    </b-card>
  </div>
</template>

<script>
import { mapActions, mapGetters } from 'vuex'

export default {
  name: 'Total',
  created: function () {
    this.$store.dispatch('cargarTotal', this.$route.params.id)
  },
  computed: {
    ...mapGetters(['totalTransaction'])
  },
  methods: {
    ...mapActions(['cargarTotal'])
  }
}
</script>
