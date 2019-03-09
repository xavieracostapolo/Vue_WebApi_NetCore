import Vue from 'vue'
import Vuex from 'vuex'
import { RepositoryFactory } from './service/RepositoryFactory'

Vue.use(Vuex)

export const CARGAR_TRANSACTIONS = 'CARGAR_TRANSACTIONS'
export const CARGAR_RATES = 'CARGAR_RATES'
export const CARGAR_TOTAL = 'CARGAR_TOTAL'

const RatesRepository = RepositoryFactory.get('rates')
const TransactionsRepository = RepositoryFactory.get('transactions')

export default new Vuex.Store({
  state: {
    transactionsList: [],
    ratesList: [],
    totalTrx: 0
  },
  getters: {
    transactionsList (state) {
      return state.transactionsList
    },
    ratesList (state) {
      return state.ratesList
    },
    totalTransaction (state) {
      return state.totalTrx
    }
  },
  mutations: {
    [CARGAR_TRANSACTIONS]: function (state, list) {
      state.transactionsList = list
    },
    [CARGAR_RATES]: function (state, list) {
      state.ratesList = list
    },
    [CARGAR_TOTAL]: function (state, total) {
      state.totalTrx = total
    }
  },
  actions: {
    cargarTransactions: (context) => {
      return new Promise((resolve, reject) => {
        TransactionsRepository.get()
          .then(res => {
            if (res.status === 200) {
              context.commit(CARGAR_TRANSACTIONS, res.data)
              resolve(res)
            } else {
              reject(res)
            }
          })
          .catch(e => {
            console.log(e)
            reject(e)
          })
      })
    },
    cargarRates: (context) => {
      return new Promise((resolve, reject) => {
        RatesRepository.get()
          .then(res => {
            if (res.status === 200) {
              context.commit(CARGAR_RATES, res.data)
              resolve(res)
            } else {
              reject(res)
            }
          })
          .catch(e => {
            console.log(e)
            reject(e)
          })
      })
    },
    cargarTransactionsBySku: (context, sku) => {
      return new Promise((resolve, reject) => {
        TransactionsRepository.getBySku(sku)
          .then(res => {
            if (res.status === 200) {
              context.commit(CARGAR_TRANSACTIONS, res.data)
              resolve(res)
            } else {
              reject(res)
            }
          })
          .catch(e => {
            console.log(e)
            reject(e)
          })
      })
    },
    cargarTotal: (context, sku) => {
      return new Promise((resolve, reject) => {
        TransactionsRepository.getBySkuTotal(sku)
          .then(res => {
            if (res.status === 200) {
              context.commit(CARGAR_TOTAL, res.data)
              resolve(res)
            } else {
              reject(res)
            }
          })
          .catch(e => {
            console.log(e)
            reject(e)
          })
      })
    }
  }
})
