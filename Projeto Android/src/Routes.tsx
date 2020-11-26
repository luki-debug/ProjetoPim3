import React, { useContext, useEffect, useState } from 'react';
import CustomDrawer from './components/CustomDrawer';
import {
  createDrawerNavigator,
  DrawerScreenProps,
} from '@react-navigation/drawer';
import { NavigationContainer } from '@react-navigation/native';
import Header from './components/Header';
import { navigationDrawerRef } from './utils/navigationDrawerRef';
import Login from './pages/Login';
import Cadastro from './pages/Cadastro';
import RecuperarSenha from './pages/RecuperarSenha';
import ConsultarSaldo from './pages/ConsultarSaldo';
import Investimentos from './pages/Investimentos';
import Home from './pages/Home';
import Perfil from './pages/Perfil';
import CompraMoedas from './pages/CompraMoedas';
import Transacoes from './pages/Transacoes';
import { loggedContext } from '../App';

const { Navigator, Screen } = createDrawerNavigator();

const Routes = () => {
  const [logged] = useContext(loggedContext);
  const [lastLogged, setLastLogged] = useState(false);

  useEffect(() => {
    if (logged.logged) {
      if (!lastLogged) {
        setLastLogged(true);
        navigationDrawerRef.current?.navigate('Início');
      }
    } else {
      setLastLogged(false);
      navigationDrawerRef.current?.navigate('Login');
    }
  }, [logged]);

  return (
    <NavigationContainer ref={navigationDrawerRef}>
      <Navigator
        initialRouteName={logged.logged ? 'Início' : 'Login'}
        drawerContent={CustomDrawer}
      >
        <Screen
          name='Início'
          options={{
            unmountOnBlur: true,
          }}
          component={Home}
        />
        <Screen name='Consultar Saldo' component={ConsultarSaldo} />
        <Screen
          name='Investimentos'
          options={{
            unmountOnBlur: true,
          }}
          component={Investimentos}
        />
        <Screen name='Compra de Moedas' component={CompraMoedas} />
        <Screen name='Fazer transações/pagar contas' component={Transacoes} />

        <Screen name='Perfil' component={Perfil} />
        <Screen
          name='Login'
          options={{
            gestureEnabled: false,
            swipeEnabled: false,
            unmountOnBlur: true,
          }}
          component={Login}
        />
        <Screen
          name='Cadastro'
          options={{
            gestureEnabled: false,
            swipeEnabled: false,
            unmountOnBlur: true,
          }}
          component={Cadastro}
        />
        <Screen
          name='RecuperarSenha'
          options={{
            gestureEnabled: false,
            swipeEnabled: false,
            unmountOnBlur: true,
          }}
          component={RecuperarSenha}
        />
      </Navigator>
    </NavigationContainer>
  );
};

export default Routes;
