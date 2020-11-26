import { DrawerScreenProps } from '@react-navigation/drawer';
import React, { useContext, useEffect, useState } from 'react';
import {
  StyleSheet,
  View,
  Text,
  Image,
  TouchableOpacity,
  Alert,
} from 'react-native';
import { ScrollView, TextInput } from 'react-native-gesture-handler';
import { FontAwesome } from '@expo/vector-icons';
import Header from '../components/Header';

import lumiaIcon from '../images/lumiaIcon.png';
import { loggedContext } from '../../App';
import { formatNumber } from '../utils/formatNumber';
import api from '../services/api';

const CompraMoedas: React.FC<DrawerScreenProps<{}>> = ({
  navigation,
  route,
}) => {
  const [user, setUser] = useContext(loggedContext);
  const [bitcoin, setBitcoin] = useState(true);

  const [bitcoinPrice, setBitcoinPrice] = useState('Carregando...');
  const [etheriumPrice, setEtheriumPrice] = useState('Carregando...');
  const [valueToBuy, setValueToBuy] = useState('');
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    const interval = setInterval(() => {
      fetch('https://economia.awesomeapi.com.br/all/BTC-BRL,ETH-BRL')
        .then((res) => res.json())
        .then((data) => {
          const { BTC, ETH } = data;

          setBitcoinPrice(formatNumber(BTC.bid) as string);
          setEtheriumPrice(formatNumber(ETH.bid) as string);
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

        Alert.alert('Sucesso!', 'Compra realizada.', [
          {
            text: 'OK',
          },
        ]);
      })
      .catch((err) => {
        console.error(err);
        setLoading(false);

        Alert.alert('Ops', 'Parece que algo deu errado.', [
          {
            text: 'OK',
          },
        ]);
      });
  };

  return (
    <>
      <Header openSidemenu={navigation.openDrawer} route={route.name} />
      <ScrollView style={styles.scroll} keyboardShouldPersistTaps='always'>
        <View style={styles.compraContainer}>
          <Text style={styles.title}>Selecione uma moeda</Text>
          <View style={styles.cardsContainer}>
            <TouchableOpacity
              onPress={() => setBitcoin(true)}
              style={bitcoin ? styles.cardActive : styles.card}
            >
              <Text style={styles.cardTitle}>Bitcoin</Text>
              <FontAwesome name='bitcoin' style={styles.icon} />
              <Text style={styles.cardValue}>R$ {bitcoinPrice}</Text>
            </TouchableOpacity>
            <TouchableOpacity
              onPress={() => setBitcoin(false)}
              style={bitcoin ? styles.card : styles.cardActive}
            >
              <Text style={styles.cardTitle}>Ethereum</Text>
              <Image
                resizeMode='contain'
                source={lumiaIcon}
                style={styles.image}
              />
              <Text style={styles.cardValue}>R$ {etheriumPrice}</Text>
            </TouchableOpacity>
          </View>

          <View style={styles.inputContainer}>
            <Text style={styles.label}>Valor</Text>
            <TextInput
              value={valueToBuy}
              onChangeText={(text) => setValueToBuy(text)}
              style={styles.input}
              placeholder='100.00'
              keyboardType='numeric'
            />
          </View>

          <TouchableOpacity
            onPress={loading ? undefined : handleBuy}
            style={styles.buttonEnter}
          >
            <Text style={styles.buttonText}>{loading ? '...' : 'Comprar'}</Text>
          </TouchableOpacity>
        </View>
      </ScrollView>
    </>
  );
};

export default CompraMoedas;

const styles = StyleSheet.create({
  scroll: {
    backgroundColor: '#362466',
    flex: 1,
  },
  compraContainer: {
    margin: 16,
    alignItems: 'center',
  },
  title: {
    color: '#fff',
    fontSize: 28,
    marginBottom: 8,
  },
  cardsContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    width: '100%',
    marginVertical: 16,
  },
  card: {
    borderRadius: 20,
    padding: 16,
    backgroundColor: '#5e4a97',
    width: '47%',
    alignItems: 'center',
  },
  cardActive: {
    borderRadius: 20,
    padding: 16,
    backgroundColor: '#ffa200',
    width: '47%',
    alignItems: 'center',
  },
  cardTitle: {
    fontSize: 24,
    color: '#fff',
    marginBottom: 16,
  },
  icon: {
    fontSize: 100,
    width: 75,
    color: '#fff',
  },
  image: {
    height: 100,
    width: 100,
  },
  cardValue: {
    marginTop: 16,
    fontSize: 18,
    color: '#fff',
  },
  inputContainer: {
    justifyContent: 'center',
    alignItems: 'flex-start',
    width: '100%',
  },
  label: {
    color: '#fff',
    fontSize: 28,
    marginBottom: 8,
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
  buttonEnter: {
    paddingHorizontal: 18,
    paddingVertical: 10,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#ffa200',
    borderRadius: 10,
    marginVertical: 16,
  },
  buttonText: {
    fontSize: 28,
    color: '#fff',
  },
});
