import React from 'react';

import '../styles/components/sidemenu.css';

import logoImage from '../images/lumiaLogo.png';
import { Link, useLocation } from 'react-router-dom';
import {
  FaBarcode,
  FaBitcoin,
  FaHome,
  FaPiggyBank,
  FaUserAlt,
  FaWallet,
} from 'react-icons/fa';

const Sidemenu: React.FC = ({ children }) => {
  const location = useLocation();

  return (
    <div id='sidemenu' className='sidemenu'>
      {children}
      <img src={logoImage} alt='Logo' />
      <div className='optionsContainer'>
        <div className='menuItems'>
          <Link to='/perfil' className='menuItem perfil'>
            <FaUserAlt />
            <span className='menuItemLabel'>Meu Perfil</span>
            <span></span>
          </Link>
          <Link
            to=''
            className={
              location.pathname === '/'
                ? 'menuItem inicio active'
                : 'menuItem inicio'
            }
          >
            <FaHome />
            <span className='menuItemLabel'>Início</span>
            <span></span>
          </Link>
          <Link
            to='saldo'
            className={
              location.pathname === '/saldo'
                ? 'menuItem saldo active'
                : 'menuItem saldo'
            }
          >
            <FaWallet />
            <span className='menuItemLabel'>Consultar Saldo</span>
            <span></span>
          </Link>
          <Link
            to='/investimentos'
            className={
              location.pathname === '/investimentos'
                ? 'menuItem investimentos active'
                : 'menuItem investimentos'
            }
          >
            <FaPiggyBank />
            <span className='menuItemLabel'>Investimentos</span>
            <span></span>
          </Link>
          <Link
            to='/moedas'
            className={
              location.pathname === '/moedas'
                ? 'menuItem compra active'
                : 'menuItem compra'
            }
          >
            <FaBitcoin />
            <span className='menuItemLabel'>Compra de Moedas</span>
            <span></span>
          </Link>
          <Link
            to='/transacoes'
            className={
              location.pathname === '/transacoes'
                ? 'menuItem transacoes active'
                : 'menuItem transacoes'
            }
          >
            <FaBarcode />
            <span className='menuItemLabel'>Fazer transações/pagar contas</span>
            <span></span>
          </Link>
        </div>
      </div>
    </div>
  );
};

export default Sidemenu;
