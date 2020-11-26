import React, { useContext, useEffect, useState } from 'react';
import { FaSearch } from 'react-icons/fa';
import { userContext } from '../App';
import Header from '../components/Header';
import Sidemenu from '../components/Sidemenu';
import api from '../services/api';

import '../styles/pages/transacoes.css';

interface Historico {
  IdHistorico: number;
  DataHora: string;
  TipoTransacao: string;
  Valor: string;
}

const Transacoes: React.FC = () => {
  const [user] = useContext(userContext);
  const [opcao, setOpcao] = useState(1);
  const [historico, setHistorico] = useState<Historico[]>([]);
  const [vencimento, setVencimento] = useState('');
  const [valor, setValor] = useState('');
  const [numeracao, setNumeracao] = useState('');
  const [metodo, setMetodo] = useState('none');
  const [descricao, setDescricao] = useState('');
  const [vencimentoToSend, setVencimentoToSend] = useState('');

  const buscaHistorico = () => {
    api
      .post(`/transacao/obter-todos`, { IdPessoa: user.id })
      .then((response) => {
        if (response.status === 200) {
          const data: Array<any> = response.data;
          const newHistorico: Historico[] = [];

          data.forEach((item) => {
            const { IdHistorico, DataHora, TipoTransacao, Valor } = item;

            const newItem: Historico = {
              IdHistorico,
              DataHora: new Date(DataHora).toLocaleString(),
              TipoTransacao,
              Valor: Number(Valor).toLocaleString('pt-br', {
                style: 'currency',
                currency: 'BRL',
              }),
            };
            newHistorico.push(newItem);
          });

          setHistorico(newHistorico);
        }
      })
      .catch((err) => {
        console.error(err);
      });
  };

  useEffect(() => {
    buscaHistorico();
  }, []);

  const buscaBoleto = (codigo: string) => {
    api
      .get(`/transacao/obter-boleto/${codigo}`)
      .then((response) => {
        if (response.status === 200) {
          const { Valor, dtVencimento } = response.data;

          setValor(Valor);
          setVencimento(String(dtVencimento).substring(0, 10));
          setVencimentoToSend(dtVencimento);
        }
      })
      .catch((err) => {
        console.error(err);
      });
  };

  const handlePayment = () => {
    if (metodo !== 'none') {
      let vencimentoToPay = vencimentoToSend;
      if (vencimentoToPay === '') {
        if (vencimento !== '') {
          vencimentoToPay = `${vencimento}T00:00:00`;
        } else {
          alert('Vencimento não informado');
          return;
        }
      }

      api
        .post('/transacao', {
          _carteira: {
            _pessoa: {
              IdPessoa: user.id,
            },
            TipoMoeda: metodo === 'bitcoin' ? 2 : 1,
          },
          Valor: valor,
          dtVencimento: vencimentoToPay,
          Descricao: descricao,
        })
        .then((response) => {
          if (response.status === 200) {
            buscaHistorico();

            alert('Sucesso!');

            setVencimento('');
            setDescricao('');
            setNumeracao('');
            setValor('');
          }
        })
        .catch((err) => {
          alert(err.response.data.Message);
          console.error(err);
        });
    } else {
      alert('Indique o método.');
    }
  };

  return (
    <div id='transacoes'>
      <Sidemenu />
      <div className='transacoesContent'>
        <Header />
        <div className='content'>
          <div className='transacoesContainer'>
            <div className='abas'>
              <span
                className={opcao === 1 ? 'aba active' : 'aba'}
                onClick={() => setOpcao(1)}
              >
                Fatura de pagamento
              </span>
              <span
                className={opcao === 2 ? 'aba active' : 'aba'}
                onClick={() => setOpcao(2)}
              >
                <FaSearch />
                Histórico
              </span>
            </div>
            <div className='pagamentoContainer'>
              {opcao === 1 ? (
                <>
                  <label>Numeração do boleto</label>
                  <input
                    value={numeracao}
                    onInput={(event) => {
                      const value = event.currentTarget.value;

                      if (value.length === 10) {
                        buscaBoleto(value);
                      }

                      setNumeracao(value);
                    }}
                    type='number'
                    placeholder='Numeração do boleto'
                  />
                  <div className='inputsContainer'>
                    <div className='inputBox'>
                      <label>Valor</label>
                      <input
                        value={valor}
                        onInput={(event) => setValor(event.currentTarget.value)}
                        className='inputValue'
                        type='number'
                        placeholder='Valor R$'
                      />
                    </div>
                    <div className='inputBox'>
                      <label>Vencimento</label>
                      <input
                        value={vencimento}
                        onChange={(event) =>
                          setVencimento(event.currentTarget.value)
                        }
                        className='inputDate'
                        type='date'
                        placeholder='Data de Vencimento'
                      />
                    </div>
                  </div>
                  <label>Descrição</label>
                  <input
                    value={descricao}
                    onInput={(event) => setDescricao(event.currentTarget.value)}
                    type='text'
                    placeholder='Pequena descrição...'
                  />
                  <div className='selectDiv'>
                    <select
                      defaultValue='none'
                      onChange={(event) => setMetodo(event.currentTarget.value)}
                    >
                      <option value='none'>Método de pagamento...</option>
                      <option value='bitcoin'>Bitcoin</option>
                      <option value='etherium'>Etherium</option>
                    </select>
                  </div>
                  <button onClick={handlePayment} className='pagar'>
                    Pague agora
                  </button>{' '}
                </>
              ) : (
                <>
                  <table>
                    <thead>
                      <tr>
                        <th>Data</th>
                        <th>Valor</th>
                        <th>Descrição</th>
                      </tr>
                    </thead>
                    <tbody>
                      {historico.map((item) => {
                        return (
                          <tr key={item.IdHistorico}>
                            <td>{item.DataHora}</td>
                            <td>{item.Valor}</td>
                            <td>{item.TipoTransacao}</td>
                          </tr>
                        );
                      })}
                    </tbody>
                  </table>
                </>
              )}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Transacoes;
