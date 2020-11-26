import { DrawerScreenProps } from '@react-navigation/drawer';
import React, { useContext, useEffect, useState } from 'react';
import {
  StyleSheet,
  TouchableOpacity,
  View,
  Text,
  Picker,
  TextInput,
  Alert,
} from 'react-native';
import { ScrollView } from 'react-native-gesture-handler';
import { FontAwesome5 } from '@expo/vector-icons';
import Header from '../components/Header';
import { loggedContext } from '../../App';
import api from '../services/api';
import { formatNumber } from '../utils/formatNumber';

interface Historico {
  IdHistorico: number;
  DataHora: string;
  TipoTransacao: string;
  Valor: string;
}

const Transacoes: React.FC<DrawerScreenProps<{}>> = ({ navigation, route }) => {
  const [user, setUser] = useContext(loggedContext);
  const [opcao, setOpcao] = useState(1);
  const [metodo, setMetodo] = useState('');
  const [historico, setHistorico] = useState<Historico[]>([]);
  const [vencimento, setVencimento] = useState('');
  const [valor, setValor] = useState('');
  const [numeracao, setNumeracao] = useState('');
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
              DataHora: new Date(DataHora)
                .toJSON()
                .substring(0, 19)
                .replace('T', ' '),
              TipoTransacao,
              Valor: `R$ ${formatNumber(Valor)}`,
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
    if (metodo !== '') {
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

            Alert.alert('Sucesso!', 'Pagamento realizado.', [
              {
                text: 'OK',
              },
            ]);

            setVencimento('');
            setDescricao('');
            setNumeracao('');
            setValor('');
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
    } else {
      Alert.alert('Ops', 'Indique o método.', [
        {
          text: 'OK',
        },
      ]);
    }
  };

  return (
    <>
      <Header openSidemenu={navigation.openDrawer} route={route.name} />
      <ScrollView style={styles.scroll} keyboardShouldPersistTaps='always'>
        <View style={styles.saldoContainer}>
          <View style={styles.abas}>
            <TouchableOpacity
              onPress={() => setOpcao(1)}
              style={opcao === 1 ? styles.abaActive : styles.aba}
            >
              <Text style={styles.textAba}>Fatura de pagamento</Text>
            </TouchableOpacity>
            <TouchableOpacity
              onPress={() => setOpcao(2)}
              style={opcao === 2 ? styles.abaActive : styles.aba}
            >
              <FontAwesome5 name='search' style={styles.icon} />
              <Text style={styles.textAba}>Histórico</Text>
            </TouchableOpacity>
          </View>

          <View style={styles.pagamentoContainer}>
            {opcao === 1 ? (
              <>
                <View style={styles.inputContainer}>
                  <Text style={styles.label}>Numeração do boleto</Text>
                  <TextInput
                    value={numeracao}
                    onChangeText={(text) => {
                      if (text.length === 10) {
                        buscaBoleto(text);
                      }

                      setNumeracao(text);
                    }}
                    style={styles.input}
                  />
                </View>
                <View style={styles.inputContainer}>
                  <Text style={styles.label}>Valor</Text>
                  <TextInput
                    value={String(valor)}
                    onChangeText={(text) => setValor(text)}
                    keyboardType='numeric'
                    placeholder='Valor R$'
                    style={styles.input}
                  ></TextInput>
                </View>
                <View style={styles.inputContainer}>
                  <Text style={styles.label}>Vencimento</Text>
                  <TextInput
                    value={vencimento}
                    onChangeText={(text) => setVencimento(text)}
                    placeholder='Data de Vencimento'
                    style={styles.input}
                  />
                </View>
                <View style={styles.inputContainer}>
                  <Text style={styles.label}>Descrição</Text>
                  <TextInput
                    value={descricao}
                    onChangeText={(text) => setDescricao(text)}
                    style={styles.input}
                    placeholder='Pequena descrição...'
                  />
                </View>

                <View style={styles.pickerContainer}>
                  <Picker
                    style={styles.picker}
                    selectedValue={metodo}
                    onValueChange={(value) => setMetodo(value)}
                  >
                    <Picker.Item label='Método de pagamento...' value='' />
                    <Picker.Item label='Bitcoin' value='bitcoin' />
                    <Picker.Item label='Ethereum' value='ethereum' />
                  </Picker>
                </View>

                <TouchableOpacity
                  onPress={handlePayment}
                  style={styles.pagueButton}
                >
                  <Text style={styles.pagueButtonText}>Pague agora</Text>
                </TouchableOpacity>
              </>
            ) : (
              <>
                <View style={styles.table}>
                  <View style={styles.tableHeaderContainer}>
                    <Text style={styles.tableHeader}>Data</Text>
                    <Text style={styles.tableHeader}>Valor</Text>
                    <Text style={styles.tableHeader}>Descrição</Text>
                  </View>
                  {historico.map((item) => {
                    return (
                      <View key={item.IdHistorico} style={styles.tableRow}>
                        <Text style={styles.tableData}>{item.DataHora}</Text>
                        <Text style={styles.tableData}>{item.Valor}</Text>
                        <Text style={styles.tableData}>
                          {item.TipoTransacao}
                        </Text>
                      </View>
                    );
                  })}
                </View>
              </>
            )}
          </View>
        </View>
      </ScrollView>
    </>
  );
};

export default Transacoes;

const styles = StyleSheet.create({
  scroll: {
    backgroundColor: '#362466',
  },
  saldoContainer: {
    margin: 16,
  },
  abas: {
    flexDirection: 'row',
    marginTop: 16,
    justifyContent: 'center',
    marginBottom: 16,
  },
  aba: {
    flexDirection: 'row',
    flex: 1,
    backgroundColor: '#5e4a97',
    borderRadius: 10,
    paddingVertical: 8,
    paddingHorizontal: 16,
    marginHorizontal: 8,
    justifyContent: 'center',
    alignItems: 'center',
  },
  abaActive: {
    flexDirection: 'row',
    flex: 1,
    backgroundColor: '#ffa200',
    borderRadius: 10,
    paddingVertical: 8,
    paddingHorizontal: 16,
    marginHorizontal: 8,
    justifyContent: 'center',
    alignItems: 'center',
  },
  textAba: {
    textAlign: 'center',
    fontSize: 20,
    color: '#fff',
  },
  icon: {
    fontSize: 20,
    color: '#fff',
    marginRight: 8,
  },
  pagamentoContainer: {
    marginHorizontal: 8,
    padding: 16,
    borderRadius: 10,
    backgroundColor: '#5e4a97',
    alignItems: 'center',
  },
  inputContainer: {
    justifyContent: 'center',
    alignItems: 'flex-start',
    width: '100%',
  },
  label: {
    color: '#fff',
    marginBottom: 8,
    fontSize: 16,
  },
  input: {
    backgroundColor: '#fff',
    borderWidth: 1.4,
    width: '100%',
    borderColor: '#d3e2e6',
    borderRadius: 10,
    height: 56,
    paddingVertical: 18,
    paddingHorizontal: 24,
    marginBottom: 16,
    textAlignVertical: 'top',
  },
  pickerContainer: {
    width: '100%',
    borderColor: '#fff',
    borderWidth: 3,
    borderRadius: 20,
    marginBottom: 16,
    marginTop: 16,
    paddingHorizontal: 16,
  },
  picker: {
    width: '100%',
    color: '#fff',
    paddingVertical: 18,
    paddingHorizontal: 24,
  },
  pagueButton: {
    paddingHorizontal: 18,
    paddingVertical: 10,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#ffa200',
    borderRadius: 10,
    marginVertical: 16,
  },
  pagueButtonText: {
    fontSize: 24,
    color: '#fff',
  },
  table: {
    width: '100%',
  },
  tableRow: {
    flexDirection: 'row',
    justifyContent: 'space-between',
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
  tableData: {
    paddingHorizontal: 4,
    fontSize: 14,
    color: '#fff',
    flexDirection: 'row',
    flex: 1,
  },
});
