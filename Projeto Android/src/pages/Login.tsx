import React, { useContext, useEffect, useState } from 'react';
import {
  Image,
  StyleSheet,
  Text,
  TextInput,
  TouchableOpacity,
  View,
} from 'react-native';
import { BorderlessButton, ScrollView } from 'react-native-gesture-handler';

import logoImage from '../images/lumiaLogo.png';
import { loggedContext } from '../../App';
import api from '../services/api';
import { formatNumber } from '../utils/formatNumber';
import { navigationDrawerRef } from '../utils/navigationDrawerRef';

const Login: React.FC = () => {
  const [correctPassword, setCorrectPassword] = useState(true);
  const [, setLogged] = useContext(loggedContext);
  const [loading, setLoading] = useState(false);

  const [login, setLogin] = useState('');
  const [senha, setSenha] = useState('');
  const [editable, setEditable] = useState(false);

  useEffect(() => {
    setTimeout(() => {
      setEditable(true);
    }, 100);
    setLogged({ id: 0, logged: false });
  }, []);

  const autentica = () => {
    setLoading(true);
    api
      .post('/login', {
        Email: login,
        Senha: senha,
      })
      .then((response) => {
        if (response.status === 200) {
          const { Id, Tipo } = response.data;

          setLogged({
            id: Id,
            logged: true,
            fisica: Tipo === 'Fisica',
          });
        }
      })
      .catch((err) => {
        setCorrectPassword(false);
      })
      .finally(() => {
        setLoading(false);
      });
  };

  return (
    <ScrollView
      style={styles.scroll}
      contentContainerStyle={styles.loginContainer}
      keyboardShouldPersistTaps='always'
    >
      <View style={styles.loginCard}>
        <Image resizeMode='contain' style={styles.image} source={logoImage} />
        <Text style={styles.textTitle}>Bem Vindo!</Text>
        <Text style={styles.textSubtitle}>Acesse a sua conta</Text>
        <View style={styles.inputContainer}>
          <Text style={styles.label}>Login</Text>
          <TextInput
            editable={editable}
            style={styles.input}
            onChangeText={(text) => {
              setLogin(text);
            }}
          />
        </View>
        <View style={styles.inputContainer}>
          <Text style={styles.label}>Senha</Text>
          <TextInput
            value={senha}
            onChangeText={(text) => setSenha(text)}
            style={styles.input}
            secureTextEntry={true}
          />
        </View>
        <View style={styles.optionsContainer}>
          <BorderlessButton
            onPress={() => {
              navigationDrawerRef.current?.navigate('RecuperarSenha');
            }}
          >
            <Text style={styles.option1}>Esqueci a senha</Text>
          </BorderlessButton>
          <BorderlessButton
            onPress={() => {
              navigationDrawerRef.current?.navigate('Cadastro');
            }}
          >
            <Text style={styles.option}>Abra sua conta</Text>
          </BorderlessButton>
        </View>
        {!correctPassword && (
          <Text style={styles.incorrect}>Login ou senha incorretos.</Text>
        )}

        <TouchableOpacity
          style={styles.buttonEnter}
          onPress={loading ? undefined : autentica}
        >
          <Text style={styles.buttonText}>{loading ? '...' : 'Entrar'}</Text>
        </TouchableOpacity>
      </View>
    </ScrollView>
  );
};

export default Login;

const styles = StyleSheet.create({
  scroll: {
    flex: 1,
    backgroundColor: '#0ff',
  },
  loginContainer: {
    justifyContent: 'center',
    alignItems: 'center',
    flexGrow: 1,
    backgroundColor: '#473088',
    width: '100%',
    paddingBottom: 32,
    paddingTop: 64,
  },
  loginCard: {
    width: '90%',
    padding: 32,
    alignItems: 'center',
    justifyContent: 'center',
    backgroundColor: '#fff',
    borderRadius: 20,
  },
  image: {
    width: '100%',
    height: 200,
  },
  textTitle: {
    fontSize: 42,
    color: '#333',
  },
  textSubtitle: {
    fontSize: 24,
    color: '#333',
    marginBottom: 16,
  },
  incorrect: {
    color: '#f00',
  },
  inputContainer: {
    justifyContent: 'center',
    alignItems: 'flex-start',
    width: '100%',
  },
  optionsContainer: {
    flexDirection: 'row',
    alignItems: 'center',
    paddingVertical: 16,
    justifyContent: 'space-between',
    width: '100%',
  },
  option1: {
    fontSize: 16,
    marginRight: 8,
  },
  option: {
    fontSize: 16,
  },
  label: {
    color: '#8fa7b3',
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
    backgroundColor: '#473088',
    borderRadius: 10,
    marginVertical: 16,
  },
  buttonText: {
    fontSize: 28,
    color: '#fff',
  },
});
