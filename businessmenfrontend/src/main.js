import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import Vue2Filters from 'vue2-filters'

import Vue from 'vue'
import BootstrapVue from 'bootstrap-vue'
import App from './App.vue'
import router from './router'
import store from './store'

Vue.config.productionTip = false

Vue.use(BootstrapVue)
Vue.use(Vue2Filters)

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
