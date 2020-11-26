import React, { useContext, useEffect, useState } from 'react';
import { StyleSheet, Text } from 'react-native';
import { Entypo } from '@expo/vector-icons';
import { SafeAreaView } from 'react-native-safe-area-context';
import {
  BorderlessButton,
  TouchableOpacity,
} from 'react-native-gesture-handler';
import { FontAwesome5 } from '@expo/vector-icons';
import { navigationDrawerRef } from '../utils/navigationDrawerRef';
import { loggedContext } from '../../App';
import api from '../services/api';
import { formatNumber } from '../utils/formatNumber';

interface HeaderProps {
  openSidemenu: () => void;
  route: string;
}

const Header: React.FC<HeaderProps> = ({ openSidemenu, route }) => {
  const [logged] = useContext(loggedContext);
  const [saldo, setSaldo] = useState('');

  useEffect(() => {
    api
      .get(`/transacao/obter-saldo/${logged.id}`)
      .then((responseSaldo) => {
        if (responseSaldo.status === 200) {
          const { Saldo } = responseSaldo.data;

          setSaldo(`R$ ${formatNumber(Saldo)}`);
        }
      })
      .catch((err) => console.error(err));

    const interval = setInterval(() => {
      api
        .get(`/transacao/obter-saldo/${logged.id}`)
        .then((responseSaldo) => {
          if (responseSaldo.status === 200) {
            const { Saldo } = responseSaldo.data;

            setSaldo(`R$ ${formatNumber(Saldo)}`);
          }
        })
        .catch((err) => console.error(err));
    }, 5000);

    return () => {
      clearInterval(interval);
    };
  }, []);

  return (
    <SafeAreaView style={styles.headerContainer}>
      <BorderlessButton onPress={openSidemenu}>
        <Entypo name='menu' style={styles.icon} />
      </BorderlessButton>
      <TouchableOpacity style={styles.saldoContainer}>
        <FontAwesome5 name='money-bill-alt' style={styles.saldoIcon} />
        <Text
          style={styles.textSaldo}
          onPress={() => {
            navigationDrawerRef.current?.navigate('Consultar Saldo', {});
          }}
        >
          {saldo}
        </Text>
      </TouchableOpacity>
      <TouchableOpacity
        style={styles.saldoContainer}
        onPress={() => {
          navigationDrawerRef.current?.navigate('Perfil', {});
        }}
      >
        <FontAwesome5
          name='user-alt'
          style={route === 'Perfil' ? styles.userIconSelected : styles.userIcon}
        />
      </TouchableOpacity>
    </SafeAreaView>
  );
};

export default Header;

const styles = StyleSheet.create({
  headerContainer: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between',
    paddingHorizontal: 8,
    backgroundColor: '#473088',
    paddingVertical: 8,
  },
  icon: {
    color: '#fff',
    fontSize: 48,
  },
  depositarButton: {
    padding: 8,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#fff',
    borderRadius: 10,
  },
  depositarButtonSelected: {
    padding: 8,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#ffa200',
    borderRadius: 10,
  },
  textDepositar: {
    color: '#333',
    fontSize: 20,
  },
  saldoContainer: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  saldoIcon: {
    color: '#fff',
    fontSize: 32,
    marginRight: 4,
  },
  userIcon: {
    color: '#fff',
    fontSize: 32,
    marginRight: 4,
  },
  userIconSelected: {
    color: '#ffa200',
    fontSize: 32,
    marginRight: 4,
  },
  textSaldo: {
    color: '#fff',
    fontSize: 20,
  },
});
