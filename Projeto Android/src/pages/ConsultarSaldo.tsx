import { DrawerScreenProps } from '@react-navigation/drawer';
import React, { useContext, useEffect, useState } from 'react';
import { StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { ScrollView, TextInput } from 'react-native-gesture-handler';
import { FontAwesome5 } from '@expo/vector-icons';
import Header from '../components/Header';

import DatePicker from 'react-native-datepicker';
import api from '../services/api';
import { formatNumber } from '../utils/formatNumber';
import { loggedContext } from '../../App';

const dateNow = new Date();

interface Movimentacao {
  DataHora: string;
  Descricao: string;
  Valor: number;
}

const ConsultarSaldo: React.FC<DrawerScreenProps<{}>> = ({
  navigation,
  route,
}) => {
  const [movimentacoes, setMovimentacoes] = useState<Movimentacao[]>([]);
  const [user] = useContext(loggedContext);
  const [dt1, setDt1] = useState(
    `${dateNow.getDate() < 10 ? `0${dateNow.getDate()}` : dateNow.getDate()}/${
      dateNow.getMonth() + 1 < 10
        ? `0${dateNow.getMonth() + 1}`
        : dateNow.getMonth() + 1
    }/${dateNow.getFullYear()}`
  );
  const [dt2, setDt2] = useState(
    `${dateNow.getDate() < 10 ? `0${dateNow.getDate()}` : dateNow.getDate()}/${
      dateNow.getMonth() + 1 < 10
        ? `0${dateNow.getMonth() + 1}`
        : dateNow.getMonth() + 1
    }/${dateNow.getFullYear()}`
  );
  const [saldo, setSaldo] = useState('100.00');

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

            const newMovimentacao: Movimentacao = {
              DataHora: new Date(DataHora)
                .toJSON()
                .substring(0, 19)
                .replace('T', ' '),
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
    const dateFormatted1 = `${dt1.substring(6, 10)}-${dt1.substring(
      3,
      5
    )}-${dt1.substring(0, 2)}`;

    const dateFormatted2 = `${dt2.substring(6, 10)}-${dt2.substring(
      3,
      5
    )}-${dt2.substring(0, 2)}`;

    filter(dateFormatted1, dateFormatted2);
  }, []);

  return (
    <>
      <Header openSidemenu={navigation.openDrawer} route={route.name} />
      <ScrollView style={styles.scroll} keyboardShouldPersistTaps='always'>
        <View style={styles.saldoContainer}>
          <View style={styles.movimentacoes}>
            <View style={styles.filterContainer}>
              <View style={styles.filterHeader}>
                <FontAwesome5 name='filter' style={styles.filterIcon} />
                <Text style={styles.filterText}>Período</Text>
              </View>
              <View style={styles.datesContainer}>
                <DatePicker
                  style={styles.inputDate}
                  date={dt1}
                  mode='date'
                  placeholder='select date'
                  format='DD/MM/YYYY'
                  confirmBtnText='Confirm'
                  cancelBtnText='Cancel'
                  customStyles={{
                    dateIcon: {
                      position: 'absolute',
                      left: 0,
                      top: 4,
                      marginLeft: 0,
                    },
                    dateInput: {
                      borderWidth: 0,
                      marginLeft: 36,
                    },
                  }}
                  onDateChange={(date) => {
                    const dateFormatted1 = `${date.substring(
                      6,
                      10
                    )}-${date.substring(3, 5)}-${date.substring(0, 2)}`;

                    const dateFormatted2 = `${dt2.substring(
                      6,
                      10
                    )}-${dt2.substring(3, 5)}-${dt2.substring(0, 2)}`;

                    filter(dateFormatted1, dateFormatted2);
                    setDt1(date);
                  }}
                />
                <Text style={styles.dateLabel}>à</Text>

                <DatePicker
                  style={styles.inputDate}
                  date={dt2}
                  mode='date'
                  placeholder='select date'
                  format='DD/MM/YYYY'
                  confirmBtnText='Confirmar'
                  cancelBtnText='Cancelar'
                  customStyles={{
                    dateIcon: {
                      position: 'absolute',
                      left: 0,
                      top: 4,
                      marginLeft: 0,
                    },
                    dateInput: {
                      borderWidth: 0,
                      marginLeft: 36,
                    },
                  }}
                  onDateChange={(date) => {
                    const dateFormatted1 = `${dt1.substring(
                      6,
                      10
                    )}-${dt1.substring(3, 5)}-${dt1.substring(0, 2)}`;

                    const dateFormatted2 = `${date.substring(
                      6,
                      10
                    )}-${date.substring(3, 5)}-${date.substring(0, 2)}`;

                    filter(dateFormatted1, dateFormatted2);

                    setDt2(date);
                  }}
                />
              </View>
            </View>
            <Text style={styles.saldoTitle}>Movimentações</Text>
            <View style={styles.movimentacaoItems}>
              {movimentacoes.map((movimentacao, index) => {
                return (
                  <View key={index} style={styles.movimentacaoItem}>
                    <Text style={styles.itemDate}>{movimentacao.DataHora}</Text>
                    <View style={styles.motivoContainer}>
                      <Text style={styles.itemValue}>
                        {movimentacao.Descricao}
                      </Text>
                      <Text style={styles.itemValue}>
                        R$ {formatNumber(movimentacao.Valor)}
                      </Text>
                    </View>
                  </View>
                );
              })}
            </View>
          </View>
        </View>
      </ScrollView>
    </>
  );
};

export default ConsultarSaldo;

const styles = StyleSheet.create({
  scroll: {
    backgroundColor: '#362466',
  },
  saldoContainer: {
    margin: 16,
  },
  saldo: {
    backgroundColor: '#5e4a97',
    borderRadius: 20,
    padding: 16,
    marginBottom: 16,
  },
  saldoValueContainer: {
    marginBottom: 16,
  },
  saldoTitle: {
    fontSize: 32,
    color: '#fff',
    marginBottom: 8,
  },
  saldoValue: {
    fontSize: 40,
    color: '#fff',
    marginBottom: 8,
  },
  resgatarContainer: {
    alignItems: 'center',
  },
  inputResgateContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    marginBottom: 16,
  },
  resgatarLabel: {
    fontSize: 20,
    color: '#fff',
    marginBottom: 8,
  },
  resgatarInput: {
    backgroundColor: '#fff',
    borderWidth: 1.4,
    flex: 1,
    borderColor: '#d3e2e6',
    borderRadius: 10,
    fontSize: 32,
    paddingVertical: 4,
    paddingHorizontal: 12,
    marginLeft: 16,
    textAlignVertical: 'top',
  },
  resgatarButton: {
    paddingHorizontal: 18,
    paddingVertical: 10,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#ffa200',
    borderRadius: 10,
    marginVertical: 16,
  },
  resgatarButtonText: {
    fontSize: 28,
    color: '#fff',
  },
  movimentacoes: {
    backgroundColor: '#5e4a97',
    borderRadius: 20,
    padding: 16,
  },
  filterContainer: {
    marginBottom: 16,
  },
  filterHeader: {
    flexDirection: 'row',
    alignItems: 'center',
    marginBottom: 16,
  },
  filterIcon: {
    color: '#fff',
    fontSize: 32,
    marginRight: 16,
  },
  filterText: {
    fontSize: 28,
    color: '#fff',
  },
  datesContainer: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  inputDate: {
    backgroundColor: '#fff',
    borderWidth: 1.4,
    flex: 1,
    borderColor: '#d3e2e6',
    borderRadius: 10,
    fontSize: 20,
    paddingVertical: 4,
    paddingHorizontal: 12,
    textAlignVertical: 'top',
  },
  dateLabel: {
    marginHorizontal: 16,
    color: '#fff',
    fontSize: 28,
  },
  movimentacaoItems: {
    marginHorizontal: 16,
  },
  movimentacaoItem: {
    marginBottom: 24,
  },
  motivoContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginVertical: 4,
  },
  itemDate: {
    color: '#fff',
    fontSize: 20,
  },
  itemValue: {
    color: '#fff',
    fontSize: 20,
  },
});
