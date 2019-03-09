import Repository from './Repository'

const resource = '/transactions'

export default {
  get () {
    return Repository.get(`${resource}/`)
  },
  getBySku (sku) {
    return Repository.get(`${resource}/${sku}`)
  },
  getBySkuTotal (sku) {
    return Repository.get(`${resource}/GetSumTotal/${sku}`)
  }
}
