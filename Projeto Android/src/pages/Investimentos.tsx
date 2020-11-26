import { DrawerScreenProps } from '@react-navigation/drawer';
import React, { useContext, useEffect, useState } from 'react';
import { Alert, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { ScrollView } from 'react-native-gesture-handler';
import Header from '../components/Header';
import { loggedContext } from '../../App';
import api from '../services/api';
import { formatNumber } from '../utils/formatNumber';

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

const Investimentos: React.FC<DrawerScreenProps<{}>> = ({
  navigation,
  route,
}) => {
  const [option, setOption] = useState(1);
  const [user, setUser] = useContext(loggedContext);
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
                  saldo: formatNumber(Saldo),
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

  const realizaInvestimento = (card: Card) => {
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
          setOption(3);

          api
            .get(`/transacao/obter-saldo/${user.id}`)
            .then((responseSaldo) => {
              if (responseSaldo.status === 200) {
                const { Saldo } = responseSaldo.data;

                setUser({
                  ...user,
                  saldo: formatNumber(Saldo),
                });
              }
            })
            .catch((err) => console.error(err));
        }
      })
      .catch((err) => {
        Alert.alert('Ops', err.response.data.Message, [
          {
            text: 'OK',
          },
        ]);
        console.error(err);
      });
  };

  const handleInvestimento = (card: Card) => {
    Alert.alert(
      'Confirmação',
      'Deseja mesmo fazer esse investimento?',
      [
        {
          text: 'CANCELAR',
          style: 'cancel',
        },
        {
          text: 'SIM',
          onPress: () => {
            realizaInvestimento(card);
          },
        },
      ],
      { cancelable: false }
    );
  };

  return (
    <>
      <Header openSidemenu={navigation.openDrawer} route={route.name} />
      <ScrollView style={styles.scroll} keyboardShouldPersistTaps='always'>
        <View style={styles.container}>
          <TouchableOpacity
            onPress={() => setOption(1)}
            style={option === 1 ? styles.abaButtonActive : styles.abaButton}
          >
            <Text style={styles.abaLabel}>Investir</Text>
          </TouchableOpacity>
          <TouchableOpacity
            onPress={() => setOption(2)}
            style={option === 2 ? styles.abaButtonActive : styles.abaButton}
          >
            <Text style={styles.abaLabel}>Investimento Disponível</Text>
          </TouchableOpacity>
          <TouchableOpacity
            onPress={() => setOption(3)}
            style={option === 3 ? styles.abaButtonActive : styles.abaButton}
          >
            <Text style={styles.abaLabel}>Investimento Retido</Text>
          </TouchableOpacity>
          <ScrollView
            nestedScrollEnabled={true}
            style={styles.cardsContainer}
            contentContainerStyle={{ paddingBottom: 16 }}
          >
            {option === 1 && (
              <>
                {cards.map((card) => {
                  return (
                    <TouchableOpacity
                      onPress={() => handleInvestimento(card)}
                      key={card.id}
                      style={styles.card}
                    >
                      <Text style={styles.cardTitle}>
                        {card.TipoMoeda === 2 ? 'Bitcoin' : 'Ethereum'}
                      </Text>
                      <Text style={styles.cardSubtitle}>
                        R$ {formatNumber(card.ValorInvestido)}
                      </Text>
                      <Text style={styles.cardDescription}>
                        {card.TipoMoeda === 2
                          ? 'Descrição Bitcoin'
                          : 'Descrição Ethereum'}
                      </Text>
                    </TouchableOpacity>
                  );
                })}
              </>
            )}

            {option === 2 && (
              <View style={styles.tableContainer}>
                <View style={styles.table}>
                  <View style={styles.tableHeaderContainer}>
                    <Text style={styles.tableHeader}>Data</Text>
                    <Text style={styles.tableHeader}>Valor</Text>
                    <Text style={styles.tableHeader}>Descrição</Text>
                    <Text style={styles.tableHeader}></Text>
                  </View>

                  {disponiveis.map((disponivel) => {
                    return (
                      <View
                        key={disponivel.IdHistoricoInvestimento}
                        style={styles.tableRow}
                      >
                        <View style={styles.tableDateContainer}>
                          <Text style={styles.tableData}>
                            {disponivel.DtInicio.substring(0, 10)}
                          </Text>
                          <Text style={styles.tableData}>
                            {disponivel.DtInicio.substring(11, 19)}
                          </Text>
                        </View>
                        <Text style={styles.tableData}>
                          R$ {formatNumber(disponivel.ValorInvestido)}
                        </Text>
                        <Text style={styles.tableData}>
                          {disponivel.TipoMoeda === 2 ? 'Bitcoin' : 'Ethereum'}
                        </Text>
                        <TouchableOpacity style={styles.buttonResgatar}>
                          <Text
                            style={styles.buttonResgatarText}
                            onPress={() => handleResgate(disponivel)}
                          >
                            Resgatar
                          </Text>
                        </TouchableOpacity>
                      </View>
                    );
                  })}
                </View>
              </View>
            )}

            {option === 3 && (
              <View style={styles.tableContainer}>
                <View style={styles.table}>
                  <View style={styles.tableHeaderContainer}>
                    <Text style={styles.tableHeader}>Data</Text>
                    <Text style={styles.tableHeader}>Valor</Text>
                    <Text style={styles.tableHeader}>Descrição</Text>
                  </View>
                  {retidos.map((retido) => {
                    return (
                      <View
                        key={retido.IdHistoricoInvestimento}
                        style={styles.tableRow}
                      >
                        <View style={styles.tableDateContainer}>
                          <Text style={styles.tableData}>
                            {retido.DtInicio.substring(0, 10)}
                          </Text>
                          <Text style={styles.tableData}>
                            {retido.DtInicio.substring(11, 19)}
                          </Text>
                        </View>
                        <Text style={styles.tableData}>
                          R$ {formatNumber(retido.ValorInvestido)}
                        </Text>
                        <Text style={styles.tableData}>
                          {retido.TipoMoeda === 2 ? 'Bitcoin' : 'Ethereum'}
                        </Text>
                      </View>
                    );
                  })}
                </View>
              </View>
            )}
          </ScrollView>
          <Text style={styles.patrimonioLabel}>Patrimônio total:</Text>
          <Text style={styles.patrimonioValue}>
            {patrimonio !== -1 ? `R$ ${formatNumber(patrimonio)}` : '--'}
          </Text>
        </View>
      </ScrollView>
    </>
  );
};

export default Investimentos;

const styles = StyleSheet.create({
  scroll: {
    backgroundColor: '#362466',
  },
  container: {
    alignItems: 'center',
    padding: 16,
  },
  title: {
    fontSize: 32,
    color: '#fff',
  },
  subtitle: {
    fontSize: 24,
    color: '#fff',
  },
  ativoCount: {
    fontSize: 32,
    color: '#ffa200',
  },
  ativoValue: {
    fontSize: 32,
    color: '#fff',
    marginBottom: 16,
  },
  abaButton: {
    backgroundColor: '#5e4a97',
    borderRadius: 10,
    paddingVertical: 4,
    paddingHorizontal: 8,
    marginBottom: 8,
    width: '100%',
    alignItems: 'center',
  },
  abaButtonActive: {
    backgroundColor: '#ffa200',
    borderRadius: 10,
    paddingVertical: 4,
    paddingHorizontal: 8,
    marginBottom: 8,
    width: '100%',
    alignItems: 'center',
  },
  abaLabel: {
    fontSize: 24,
    textAlign: 'center',
    color: '#fff',
  },
  cardsContainer: {
    width: '100%',
    backgroundColor: '#5e4a97',
    borderRadius: 10,
    height: 430,
    paddingTop: 16,
  },
  card: {
    borderRadius: 10,
    backgroundColor: '#5e4a97',
    marginHorizontal: 16,
    marginBottom: 16,
    padding: 16,

    elevation: 10,
  },
  cardTitle: {
    fontSize: 32,
    color: '#ffa200',
  },
  cardSubtitle: {
    fontSize: 24,
    color: '#fff',
  },
  cardDescription: {
    marginTop: 8,
    fontSize: 18,
    color: '#fff',
  },
  patrimonioLabel: {
    marginTop: 16,
    fontSize: 24,
    color: '#fff',
  },
  patrimonioValue: {
    marginTop: 8,
    fontSize: 32,
    color: '#fff',
  },
  tableContainer: {
    width: '100%',
    alignItems: 'center',
  },
  table: {
    width: '95%',
  },
  tableRow: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    marginVertical: 12,
  },
  tableHeaderContainer: {
    flexDirection: 'row',
    justifyContent: 'space-around',
    marginBottom: 8,
  },
  tableHeader: {
    fontSize: 20,
    color: '#fff',
  },
  tableDateContainer: {
    paddingHorizontal: 3,
    flex: 1,
  },
  tableData: {
    paddingHorizontal: 3,
    fontSize: 14,
    color: '#fff',
    flexDirection: 'row',
    flex: 1,
  },
  buttonResgatar: {
    paddingHorizontal: 4,
    paddingVertical: 6,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#ffa200',
    borderRadius: 10,
    marginVertical: 16,
  },
  buttonResgatarText: {
    fontSize: 16,
    color: '#fff',
  },
});
