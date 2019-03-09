import axios from 'axios'

const baseDomain = 'https://localhost:5001'
const baseURL = `${baseDomain}/api`

export default axios.create({
  baseURL,
  headers: {
    'Accept': 'application/json',
    'Content-Type': 'application/json'
  }
})
