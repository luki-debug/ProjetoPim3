import React, { useContext, useEffect, useState } from 'react';
import { FaFilter } from 'react-icons/fa';
import { userContext } from '../App';
import Header from '../components/Header';
import Sidemenu from '../components/Sidemenu';
import api from '../services/api';

import '../styles/pages/consultar-saldo.css';

const dateNow = new Date();

interface Movimentacao {
  DataHora: string;
  Descricao: string;
  Valor: number;
}

const ConsultarSaldo: React.FC = () => {
  const [user] = useContext(userContext);
  const [movimentacoes, setMovimentacoes] = useState<Movimentacao[]>([]);

  const [dt1, setDt1] = useState(
    `${dateNow.getFullYear()}-${
      dateNow.getMonth() + 1 < 10
        ? `0${dateNow.getMonth() + 1}`
        : dateNow.getMonth() + 1
    }-${dateNow.getDate() < 10 ? `0${dateNow.getDate()}` : dateNow.getDate()}`
  );
  const [dt2, setDt2] = useState(
    `${dateNow.getFullYear()}-${
      dateNow.getMonth() + 1 < 10
        ? `0${dateNow.getMonth() + 1}`
        : dateNow.getMonth() + 1
    }-${dateNow.getDate() < 10 ? `0${dateNow.getDate()}` : dateNow.getDate()}`
  );

  const filter = (data1: string, data2: string) => {
    api
      .post(`/transacao/obter-pordata/${data1},${data2}`, {
        IdPessoa: user.id,
      })
      .then((response) => {
        if (response.status === 200) {
          const data: Array<any> = response.data;
          const newMovimentacoes: Movimentacao[] = [];

          data.forEach((item) => {
            const { DataHora, Descricao, Valor } = item;

            const newMovimentacao = {
              DataHora: new Date(DataHora).toLocaleString(),
              Descricao,
              Valor,
            };

            newMovimentacoes.push(newMovimentacao);
          });

          setMovimentacoes(newMovimentacoes);
        }
      })
      .catch((err) => {
        console.error(err);
      });
  };

  useEffect(() => {
    filter(dt1, dt2);
  }, []);

  return (
    <div id='consultarSaldo'>
      <Sidemenu />
      <div className='consultarSaldoContent'>
        <Header />
        <div className='content'>
          <div className='saldoContainer'>
            <div className='movimentacoes'>
              <div className='filterContainer'>
                <div className='filterContent'>
                  <FaFilter />
                  <span>Período</span>
                </div>
                <input
                  onChange={(event) => {
                    const newDate = event.currentTarget.value;
                    setDt1(newDate);
                    filter(newDate, dt2);
                  }}
                  value={dt1}
                  type='date'
                  id='dateStart'
                />
                <span>à</span>
                <input
                  onChange={(event) => {
                    const newDate = event.currentTarget.value;
                    setDt2(newDate);
                    filter(dt1, newDate);
                  }}
                  value={dt2}
                  type='date'
                  id='dateEnd'
                />
              </div>
              <h1 className='title'>Movimentações</h1>
              <div className='movimentacoesItems'>
                {movimentacoes.map((movimentacao, index) => {
                  return (
                    <span key={index} className='movimentacaoItem'>
                      <span className='date'>{movimentacao.DataHora}</span>
                      <span className='description'>
                        {movimentacao.Descricao}
                      </span>
                      <span className='value'>
                        {movimentacao.Valor.toLocaleString('pt-br', {
                          style: 'currency',
                          currency: 'BRL',
                        })}
                      </span>
                    </span>
                  );
                })}
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ConsultarSaldo;
