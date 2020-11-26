import axios from 'axios';

const api = axios.create({
  baseURL: 'https://lumiaintegracaoapp.azurewebsites.net/api',
});

export default api;
