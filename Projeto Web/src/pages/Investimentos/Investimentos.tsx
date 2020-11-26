import React, { useContext, useEffect, useState } from 'react';

import '../../styles/pages/investimentos/investimentos.css';

import Sidemenu from '../../components/Sidemenu';
import Header from '../../components/Header';
import { userContext } from '../../App';
import api from '../../services/api';
import { RouteComponentProps } from 'react-router-dom';

interface Disponivel {
  IdHistoricoInvestimento: number;
  IdCarteira: number;
  TipoMoeda: number;
  ValorInvestido: number;
  DtInicio: string;
  DtFim: string;
}

interface Retido {
  IdHistoricoInvestimento: number;
  DtInicio: string;
  TipoMoeda: number;
  ValorInvestido: number;
}

interface Card {
  id: number;
  TipoMoeda: number;
  ValorInvestido: number;
}

const Investimentos: React.FC<RouteComponentProps> = ({ history }) => {
  const [user, setUser] = useContext(userContext);
  const [opcao, setOpcao] = useState(1);
  const [disponiveis, setDisponiveis] = useState<Disponivel[]>([]);
  const [retidos, setRetidos] = useState<Retido[]>([]);
  const [patrimonio, setPatrimonio] = useState(-1);
  const cards: Card[] = [
    {
      id: 1,
      TipoMoeda: 2,
      ValorInvestido: 2000,
    },
    {
      id: 2,
      TipoMoeda: 1,
      ValorInvestido: 2000,
    },
    {
      id: 3,
      TipoMoeda: 2,
      ValorInvestido: 1500,
    },
    {
      id: 4,
      TipoMoeda: 1,
      ValorInvestido: 1500,
    },
    {
      id: 5,
      TipoMoeda: 2,
      ValorInvestido: 1000,
    },
    {
      id: 6,
      TipoMoeda: 1,
      ValorInvestido: 1000,
    },
    {
      id: 7,
      TipoMoeda: 2,
      ValorInvestido: 500,
    },
    {
      id: 8,
      TipoMoeda: 1,
      ValorInvestido: 500,
    },
  ];

  useEffect(() => {
    loadData();
  }, []);

  const loadData = () => {
    api
      .get(`/investimento/obter-disponivel/${user.id}`)
      .then((response) => {
        if (response.status === 200) {
          const data = response.data;

          const newDisponiveis: Disponivel[] = [];

          data.map((item: any) => {
            const {
              _carteira,
              IdHistoricoInvestimento,
              ValorInvestido,
              DtInicio,
              DtFim,
            } = item;

            const disponivel: Disponivel = {
              IdHistoricoInvestimento,
              DtFim: DtFim,
              DtInicio: DtInicio,
              IdCarteira: _carteira.IdCarteira,
              TipoMoeda: _carteira.TipoMoeda,
              ValorInvestido,
            };

            newDisponiveis.push(disponivel);
          });

          setDisponiveis(newDisponiveis);
        }
      })
      .catch((err) => {
        console.error(err);
      });

    api
      .get(`/investimento/obter-retido/${user.id}`)
      .then((response) => {
        if (response.status === 200) {
          const data = response.data;

          const newRetidos: Retido[] = [];

          data.map((item: any) => {
            const {
              _carteira,
              IdHistoricoInvestimento,
              ValorInvestido,
              DtInicio,
            } = item;

            const newRetido: Retido = {
              IdHistoricoInvestimento,
              DtInicio,
              TipoMoeda: _carteira.TipoMoeda,
              ValorInvestido,
            };

            newRetidos.push(newRetido);
          });

          setRetidos(newRetidos);
        }
      })
      .catch((err) => {
        console.error(err);
      });

    api
      .get(`investimento/${user.id}`)
      .then((response) => {
        if (response.status === 200) {
          const { PatrimonioTotal } = response.data;

          setPatrimonio(PatrimonioTotal);
        }
      })
      .catch((err) => {
        console.error(err);
      });
  };

  const handleResgate = (disponivel: Disponivel) => {
    api
      .put(`/investimento/resgatar-valor/${user.id}`, {
        _carteira: {
          IdCarteira: disponivel.IdCarteira,
          TipoMoeda: disponivel.TipoMoeda,
        },
        ValorInvestido: disponivel.ValorInvestido,
        DtFim: disponivel.DtFim,
      })
      .then((response) => {
        if (response.status === 200) {
          loadData();

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
        }
      })
      .catch((err) => {
        console.error(err);
      });
  };

  const handleInvestimento = (card: Card) => {
    if (window.confirm('Deseja mesmo fazer esse investimento?')) {
      api
        .post('/investimento', {
          _carteira: {
            _pessoa: {
              IdPessoa: user.id,
            },
            TipoMoeda: card.TipoMoeda,
          },
          ValorInvestido: card.ValorInvestido,
        })
        .then((response) => {
          if (response.status === 200) {
            loadData();
            setOpcao(3);

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
          }
        })
        .catch((err) => {
          alert(err.response.data.Message);
          console.error(err);
        });
    }
  };

  return (
    <div id='investimentos'>
      <Sidemenu />
      <div className='investimentosContent'>
        <Header />
        <div className='content'>
          <div className='ativosContainer'>
            <div className='abas'>
              <span
                className={opcao === 1 ? 'aba active' : 'aba'}
                onClick={() => setOpcao(1)}
              >
                Investir
              </span>
              <span
                className={opcao === 2 ? 'aba active' : 'aba'}
                onClick={() => setOpcao(2)}
              >
                Investimento Disponível
              </span>
              <span
                className={opcao === 3 ? 'aba active' : 'aba'}
                onClick={() => setOpcao(3)}
              >
                Investimento Retido
              </span>
            </div>
            <div className='cardsContainer'>
              {opcao === 1 && (
                <>
                  {cards.map((card) => {
                    return (
                      <div
                        key={card.id}
                        onClick={() => handleInvestimento(card)}
                        className='card'
                      >
                        <h1 className='cardTitle'>
                          {card.TipoMoeda === 2 ? 'Bitcoin' : 'Ethereum'}
                        </h1>
                        <span className='cardValor'>
                          {card.ValorInvestido.toLocaleString('pt-br', {
                            style: 'currency',
                            currency: 'BRL',
                          })}
                        </span>
                        <p className='cardDescription'>
                          {card.TipoMoeda === 2
                            ? 'Descrição Bitcoin'
                            : 'Descrição Ethereum'}
                        </p>
                      </div>
                    );
                  })}
                </>
              )}
              {opcao === 2 && (
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
                      {disponiveis.map((disponivel) => {
                        return (
                          <tr key={disponivel.IdHistoricoInvestimento}>
                            <td>{disponivel.DtInicio}</td>
                            <td>
                              {disponivel.ValorInvestido.toLocaleString(
                                'pt-br',
                                {
                                  style: 'currency',
                                  currency: 'BRL',
                                }
                              )}
                            </td>
                            <td>
                              {disponivel.TipoMoeda === 2
                                ? 'Bitcoin'
                                : 'Ethereum'}
                            </td>
                            <td>
                              <button onClick={() => handleResgate(disponivel)}>
                                Resgatar
                              </button>
                            </td>
                          </tr>
                        );
                      })}
                    </tbody>
                  </table>
                </>
              )}
              {opcao === 3 && (
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
                      {retidos.map((retido) => {
                        return (
                          <tr key={retido.IdHistoricoInvestimento}>
                            <td>{retido.DtInicio}</td>
                            <td>
                              {retido.ValorInvestido.toLocaleString('pt-br', {
                                style: 'currency',
                                currency: 'BRL',
                              })}
                            </td>
                            <td>
                              {retido.TipoMoeda === 2 ? 'Bitcoin' : 'Ethereum'}
                            </td>
                          </tr>
                        );
                      })}
                    </tbody>
                  </table>
                </>
              )}
            </div>
            <div className='patrimonio'>
              <span className='label'>Patrimônio total:</span>
              <span className='value'>
                {patrimonio !== -1
                  ? patrimonio.toLocaleString('pt-br', {
                      style: 'currency',
                      currency: 'BRL',
                    })
                  : '--'}
              </span>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Investimentos;
