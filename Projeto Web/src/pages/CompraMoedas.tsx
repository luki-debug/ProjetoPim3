import React, { useContext, useEffect, useState } from 'react';
import Header from '../components/Header';
import Sidemenu from '../components/Sidemenu';
import { BiBitcoin } from 'react-icons/bi';

import '../styles/pages/moedas.css';
import lumiaLogo from '../images/lumiaIcon.png';
import * as VanillaTiltModule from '../utils/vanilla-tilt.min.js';
import api from '../services/api';
import { userContext } from '../App';
const VanillaTilt = VanillaTiltModule.VanillaTilt;

const CompraMoedas: React.FC = () => {
  const [user, setUser] = useContext(userContext);
  const [bitcoin, setBitcoin] = useState(true);
  const [bitcoinPrice, setBitcoinPrice] = useState('Carregando...');
  const [etheriumPrice, setEtheriumPrice] = useState('Carregando...');
  const [valueToBuy, setValueToBuy] = useState('');
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    VanillaTilt();

    const interval = setInterval(() => {
      fetch('https://economia.awesomeapi.com.br/all/BTC-BRL,ETH-BRL')
        .then((res) => res.json())
        .then((data) => {
          const { BTC, ETH } = data;

          setBitcoinPrice(
            Number(BTC.bid).toLocaleString('pt-br', {
              style: 'currency',
              currency: 'BRL',
            })
          );
          setEtheriumPrice(
            Number(ETH.bid).toLocaleString('pt-br', {
              style: 'currency',
              currency: 'BRL',
            })
          );
        });
    }, 1000);

    return () => {
      clearInterval(interval);
    };
  }, []);

  const handleBuy = () => {
    setLoading(true);
    api
      .put('/comprarmoeda', {
        _pessoa: {
          IdPessoa: user.id,
        },
        Saldo: valueToBuy,
        TipoMoeda: bitcoin ? 2 : 1,
      })
      .then((response) => {
        if (response.status === 200) {
          setLoading(false);
        }
        setValueToBuy('');

        alert('Sucesso!');
      })
      .catch((err) => {
        console.error(err);
        setLoading(false);

        alert('Erro!');
      });
  };

  return (
    <div id='moedas'>
      <Sidemenu />
      <div className='moedasContent'>
        <Header />
        <div className='content'>
          <div className='moedasContainer'>
            <h1 className='title'>Selecione uma moeda</h1>
            <div className='options'>
              <div
                data-tilt
                className={bitcoin ? 'item active' : 'item'}
                onClick={() => setBitcoin(true)}
              >
                <h2 className='title'>Bitcoin</h2>
                <BiBitcoin className='image' />
                <p className='cotacao'>{bitcoinPrice}</p>
              </div>
              <div
                data-tilt
                className={bitcoin ? 'item' : 'item active'}
                onClick={() => setBitcoin(false)}
              >
                <h2 className='title'>Ethereum</h2>
                <img src={lumiaLogo} alt='Etherium' className='image' />
                <p className='cotacao'>{etheriumPrice}</p>
              </div>
            </div>
            <input
              value={valueToBuy}
              onInput={(event) => setValueToBuy(event.currentTarget.value)}
              type='number'
              placeholder='100.00'
            />
            <button onClick={loading ? undefined : handleBuy}>Comprar</button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default CompraMoedas;
