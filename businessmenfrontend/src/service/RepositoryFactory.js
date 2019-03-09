import RatesRepository from './RatesRepository'
import TransactionsRepository from './TransactionsRepository'

const repositories = {
  rates: RatesRepository,
  transactions: TransactionsRepository
  // Agregar otros repositorios
}

export const RepositoryFactory = {
  get: name => repositories[name]
}
