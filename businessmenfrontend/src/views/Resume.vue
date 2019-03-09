<template>
  <div>
    <total></total>
    <hr>
    <produc-list></produc-list>
  </div>
</template>

<script>
import ProducList from '@/components/ProductList'
import Total from '@/components/Total'

export default {
  name: 'resume',
  components: {
    'produc-list': ProducList,
    'total': Total
  }
}
</script>
