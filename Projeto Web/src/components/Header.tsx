import React, { useContext, useEffect, useState } from 'react';
import { FaMoneyBill } from 'react-icons/fa';
import { MdMenu } from 'react-icons/md';
import { Link, useLocation } from 'react-router-dom';
import { GiExitDoor } from 'react-icons/gi';

import '../styles/components/header.css';
import SidemenuModal from './SidemenuModal';
import { userContext } from '../App';
import api from '../services/api';

const Header: React.FC = () => {
  const [user, setUser] = useContext(userContext);
  const location = useLocation();
  const [openMenu, setOpenMenu] = useState(false);

  useEffect(() => {
    api
      .get(`/transacao/obter-saldo/${user.id}`)
      .then((responseSaldo) => {
        if (responseSaldo.status === 200) {
          const { Saldo } = responseSaldo.data;

          setUser({
            ...user,
            saldo: Number(Saldo).toLocaleString('pt-br', {
              style: 'currency',
              currency: 'BRL',
            }),
          });
        }
      })
      .catch((err) => console.error(err));

    const interval = setInterval(() => {
      api
        .get(`/transacao/obter-saldo/${user.id}`)
        .then((responseSaldo) => {
          if (responseSaldo.status === 200) {
            const { Saldo } = responseSaldo.data;

            setUser({
              ...user,
              saldo: Number(Saldo).toLocaleString('pt-br', {
                style: 'currency',
                currency: 'BRL',
              }),
            });
          }
        })
        .catch((err) => console.error(err));
    }, 5000);

    return () => {
      clearInterval(interval);
    };
  }, []);

  return (
    <div id='header'>
      <SidemenuModal openMenuState={[openMenu, setOpenMenu]} />
      <MdMenu className='openMenu' onClick={() => setOpenMenu(!openMenu)} />
      <div className='headerOptions'>
        <Link to='/saldo'>
          <div className='saldo'>
            <FaMoneyBill />
            <span>{user.saldo}</span>
          </div>
        </Link>
        <Link
          to='/perfil'
          className={
            location.pathname === '/perfil' ? 'perfil active' : 'perfil'
          }
        >
          Meu Perfil
        </Link>
        <a onClick={() => setUser({})}>
          <GiExitDoor className='exitSvg' />
        </a>
      </div>
    </div>
  );
};

export default Header;
