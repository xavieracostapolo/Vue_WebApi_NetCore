import Repository from './Repository'

const resource = '/rates'

export default {
  get () {
    return Repository.get(`${resource}/`)
  }
}
