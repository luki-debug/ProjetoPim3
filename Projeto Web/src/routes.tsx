import React from 'react';
import { BrowserRouter, Switch } from 'react-router-dom';
import Login from './pages/Login';
import Home from './pages/Home';
import ConsultarSaldo from './pages/ConsutarSaldo';
import Cadastro from './pages/Cadastro';
import RecuperarSenha from './pages/RecuperarSenha';
import Perfil from './pages/Perfil';
import Investimentos from './pages/Investimentos/Investimentos';
import CompraMoedas from './pages/CompraMoedas';
import Transacoes from './pages/Transacoes';
import RouteWrapper from './Middlewares/RouteWrapper';

function Routes() {
  return (
    <BrowserRouter>
      <Switch>
        <RouteWrapper path='/' exact component={Home} isPrivate />
        <RouteWrapper path='/login' component={Login} />
        <RouteWrapper path='/cadastro' component={Cadastro} />
        <RouteWrapper path='/recuperarSenha' component={RecuperarSenha} />
        <RouteWrapper path='/saldo' component={ConsultarSaldo} isPrivate />
        <RouteWrapper path='/perfil' component={Perfil} isPrivate />
        <RouteWrapper
          path='/investimentos'
          component={Investimentos}
          isPrivate
        />
        <RouteWrapper path='/moedas' component={CompraMoedas} isPrivate />
        <RouteWrapper path='/transacoes' component={Transacoes} isPrivate />
      </Switch>
    </BrowserRouter>
  );
}

export default Routes;
