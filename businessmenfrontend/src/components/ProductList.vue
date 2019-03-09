<template>
  <div>
    <b-card header-tag="header" footer-tag="footer" header-bg-variant="info" header-text-variant="white">
      <h6 slot="header" class="mb-0">Lista de productos.</h6>
      <div>
        <div class="row pt-2">
          <div class="col-lg-12">
            <b-table bordered hover
              :items="transactionsList"
              :fields="fields"
              :current-page="currentPage"
              :per-page="perPage"
            >
              <template slot="id" slot-scope="data">
                <!-- `data.value` is the value after formatted by the Formatter -->
                <b-button variant="info" size="sm" :to="{ name: 'tiempos', params: { id: data.item.sku } }">Ver Resumen</b-button>
              </template>
            </b-table>
          </div>
        </div>
        <b-row>
          <b-col md="6" class="my-1">
            <b-pagination
              :total-rows="transactionsList.length"
              :per-page="perPage"
              v-model="currentPage"
              class="my-0"
            />
          </b-col>
        </b-row>
      </div>
    </b-card>
  </div>
</template>

<script>
import { mapActions, mapGetters } from 'vuex'

export default {
  name: 'ProductList',
  data: function () {
    return {
      currentPage: 1,
      perPage: 5,
      fields: [
        {
          key: 'sku',
          label: 'Codigo',
          sortable: true
          // Variant applies to the whole column, including the header and footer
          // variant: 'danger'
        },
        {
          key: 'amount',
          label: 'Valor',
          sortable: true
          // Variant applies to the whole column, including the header and footer
          // variant: 'danger'
        },
        {
          key: 'currency',
          label: 'Moneda',
          sortable: true
        }]
    }
  },
  created: function () {
    this.$store.dispatch('cargarTransactions')
  },
  computed: {
    ...mapGetters(['transactionsList'])
  },
  methods: {
    ...mapActions(['cargarTransactions'])
  }
}
</script>
