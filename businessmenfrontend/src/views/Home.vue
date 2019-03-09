<template>
  <div class="home">
    <product-list></product-list>
  </div>
</template>

<script>
// @ is an alias to /src
import ProductList from '@/components/ProductList'

export default {
  name: 'home',
  components: {
    'product-list': ProductList
  }
}
</script>
