import { useNavigation } from '@react-navigation/native';
import React, { useEffect, useState } from 'react';
import { StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { ScrollView, TextInput } from 'react-native-gesture-handler';
import api from '../services/api';

const RecuperarSenha: React.FC = () => {
  const [emailSended, setEmailSended] = useState(false);
  const navigation = useNavigation();

  const [editable, setEditable] = useState(false);

  useEffect(() => {
    setTimeout(() => {
      setEditable(true);
    }, 100);
  }, []);

  const handleSubmit = () => {
    api
      .post('/email', { Email: email })
      .then((response) => {
        setEmailSended(true);
      })
      .catch((err) => {
        console.error(err);
      });
  };

  const [email, setEmail] = useState('');

  const backToLogin = () => {
    navigation.navigate('Login');
  };

  return (
    <ScrollView
      style={styles.scroll}
      contentContainerStyle={styles.loginContainer}
      keyboardShouldPersistTaps='always'
    >
      <View style={styles.loginCard}>
        {!emailSended ? (
          <>
            <Text style={styles.textTitle}>Recuperar senha</Text>
            <Text style={styles.textSubtitle}>
              Digite seu email para recuperar a senha.
            </Text>
            <View style={styles.inputContainer}>
              <Text style={styles.label}>Email</Text>
              <TextInput
                editable={editable}
                value={email}
                placeholder='Email'
                onChangeText={(text) => setEmail(text)}
                style={styles.input}
              />
            </View>
            <TouchableOpacity style={styles.buttonEnter} onPress={handleSubmit}>
              <Text style={styles.buttonText}>Enviar</Text>
            </TouchableOpacity>
          </>
        ) : (
          <>
            <Text style={styles.textTitle}>Enviado!</Text>
            <Text style={styles.textSubtitle}>Verifique seu email.</Text>
            <TouchableOpacity style={styles.buttonEnter} onPress={backToLogin}>
              <Text style={styles.buttonText}>Login</Text>
            </TouchableOpacity>
          </>
        )}
      </View>
    </ScrollView>
  );
};

export default RecuperarSenha;

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
