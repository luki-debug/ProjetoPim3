import React, { useContext, useState } from 'react';
import {
  Alert,
  Image,
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
} from 'react-native';
import { ScrollView, TextInput } from 'react-native-gesture-handler';
import { loggedContext } from '../../App';

import logoImage from '../images/lumiaLogo.png';
import api from '../services/api';

const Cadastro: React.FC = () => {
  const [user, setUser] = useContext(loggedContext);
  const [fisica, setFisica] = useState(true);

  const autentica = () => {
    setCreating(true);

    if (fisica) {
      const dateBirth = new Date(nascimento).toISOString();

      api
        .post('/pessoafisica', {
          Nome: nome,
          CPF: cpf,
          RG: rg,
          DataNascimento: dateBirth.substring(0, dateBirth.length - 5),
          Logradouro: logradouro,
          Numero: numero,
          Cidade: cidade,
          Estado: estado,
          Email: email,
          Telefone: telefone,
          Senha: senha,
          CEP: cep,
        })
        .then((response) => {
          if (response.status === 200) {
            const id = response.data;

            setCreating(false);

            setUser({ ...user, logged: true, fisica: true, id });
          }
        })
        .catch((err) => {
          console.error(err);

          Alert.alert('Ops', 'Parece que algo deu errado.', [
            {
              text: 'OK',
            },
          ]);

          setCreating(false);
        });
    } else {
      api
        .post('/pessoajuridica', {
          RazaoSocial: razao,
          CNPJ: cnpj,
          Logradouro: logradouro,
          Numero: numero,
          Cidade: cidade,
          Estado: estado,
          Email: email,
          Telefone: telefone,
          Senha: senha,
          CEP: cep,
        })
        .then((response) => {
          if (response.status === 200) {
            const id = response.data;

            setCreating(false);

            setUser({ ...user, logged: true, fisica: false, id });
          }
        })
        .catch((err) => {
          console.error(err);

          Alert.alert('Ops', 'Parece que algo deu errado.', [
            {
              text: 'OK',
            },
          ]);

          setCreating(false);
        });
    }
  };

  const [cep, setCep] = useState('');
  const [cidade, setCidade] = useState('');
  const [estado, setEstado] = useState('');
  const [nome, setNome] = useState('');
  const [cpf, setCpf] = useState('');
  const [rg, setRg] = useState('');
  const [nascimento, setNascimento] = useState('');
  const [razao, setRazao] = useState('');
  const [cnpj, setCnpj] = useState('');
  const [logradouro, setLogradouro] = useState('');
  const [numero, setNumero] = useState('');
  const [telefone, setTelefone] = useState('');
  const [email, setEmail] = useState('');
  const [senha, setSenha] = useState('');

  const [creating, setCreating] = useState(false);

  return (
    <ScrollView
      style={styles.scroll}
      contentContainerStyle={styles.loginContainer}
      keyboardShouldPersistTaps='always'
    >
      <View style={styles.loginCard}>
        <Image resizeMode='contain' style={styles.image} source={logoImage} />
        <Text style={styles.textTitle}>Cadastrar</Text>
        <Text style={styles.textSubtitle}>Abra sua conta</Text>
        <View style={styles.inputContainer}>
          <Text style={styles.label}>Pessoa</Text>
        </View>
        <View style={styles.optionsContainer}>
          <TouchableOpacity
            style={fisica ? styles.buttonOptionActive : styles.buttonOption}
            onPress={() => setFisica(true)}
          >
            <Text style={styles.buttonOptionText}>Física</Text>
          </TouchableOpacity>
          <TouchableOpacity
            style={fisica ? styles.buttonOption : styles.buttonOptionActive}
            onPress={() => setFisica(false)}
          >
            <Text style={styles.buttonOptionText}>Jurídica</Text>
          </TouchableOpacity>
        </View>
        {fisica ? (
          <>
            <View style={styles.inputContainer}>
              <Text style={styles.label}>Nome</Text>
              <TextInput
                value={nome}
                onChangeText={(text) => setNome(text)}
                style={styles.input}
              ></TextInput>
            </View>
            <View style={styles.inputContainer}>
              <Text style={styles.label}>CPF</Text>
              <TextInput
                value={cpf}
                onChangeText={(text) => setCpf(text)}
                style={styles.input}
              ></TextInput>
            </View>
            <View style={styles.inputContainer}>
              <Text style={styles.label}>RG</Text>
              <TextInput
                value={rg}
                onChangeText={(text) => setRg(text)}
                style={styles.input}
              ></TextInput>
            </View>
            <View style={styles.inputContainer}>
              <Text style={styles.label}>Data de Nascimento</Text>
              <TextInput
                value={nascimento}
                onChangeText={(text) => setNascimento(text)}
                style={styles.input}
              ></TextInput>
            </View>
          </>
        ) : (
          <>
            <View style={styles.inputContainer}>
              <Text style={styles.label}>Razão Social</Text>
              <TextInput
                value={razao}
                onChangeText={(text) => setRazao(text)}
                style={styles.input}
              ></TextInput>
            </View>
            <View style={styles.inputContainer}>
              <Text style={styles.label}>CNPJ</Text>
              <TextInput
                value={cnpj}
                onChangeText={(text) => setCnpj(text)}
                style={styles.input}
              ></TextInput>
            </View>
          </>
        )}
        <View style={styles.inputContainer}>
          <Text style={styles.label}>CEP</Text>
          <TextInput
            value={cep}
            onChangeText={(text) => {
              const newCep = text;
              setCep(newCep);

              if (newCep.length === 8) {
                fetch(`https://brasilapi.com.br/api/cep/v1/${newCep}`)
                  .then((res) => res.json())
                  .then((data) => {
                    const {
                      street: newAddress,
                      city: newCity,
                      state: newState,
                    } = data;

                    if (newCity && newCity !== '') {
                      setCidade(newCity);
                    }
                    if (newAddress && newAddress !== '') {
                      setLogradouro(newAddress);
                    }
                    if (newState && newState !== '') {
                      setEstado(newState);
                    }
                  });
              }
            }}
            style={styles.input}
          ></TextInput>
        </View>
        <View style={styles.inputContainer}>
          <Text style={styles.label}>Logradouro</Text>
          <TextInput
            value={logradouro}
            onChangeText={(text) => setLogradouro(text)}
            style={styles.input}
          ></TextInput>
        </View>
        <View style={styles.inputContainer}>
          <Text style={styles.label}>Numero</Text>
          <TextInput
            value={numero}
            onChangeText={(text) => setNumero(text)}
            style={styles.input}
          ></TextInput>
        </View>
        <View style={styles.inputContainer}>
          <Text style={styles.label}>Cidade</Text>
          <TextInput
            value={cidade}
            onChangeText={(text) => setCidade(text)}
            style={styles.input}
          ></TextInput>
        </View>
        <View style={styles.inputContainer}>
          <Text style={styles.label}>Estado</Text>
          <TextInput
            value={estado}
            onChangeText={(text) => setEstado(text)}
            style={styles.input}
          ></TextInput>
        </View>
        <View style={styles.inputContainer}>
          <Text style={styles.label}>Telefone</Text>
          <TextInput
            value={telefone}
            onChangeText={(text) => setTelefone(text)}
            style={styles.input}
          ></TextInput>
        </View>
        <View style={styles.inputContainer}>
          <Text style={styles.label}>Email</Text>
          <TextInput
            value={email}
            onChangeText={(text) => setEmail(text)}
            style={styles.input}
          ></TextInput>
        </View>
        <View style={styles.inputContainer}>
          <Text style={styles.label}>Senha</Text>
          <TextInput
            value={senha}
            onChangeText={(text) => setSenha(text)}
            style={styles.input}
            secureTextEntry={true}
          ></TextInput>
        </View>

        <TouchableOpacity
          style={styles.buttonEnter}
          onPress={creating ? undefined : autentica}
        >
          <Text style={styles.buttonText}>
            {creating ? '...' : 'Cadastrar'}
          </Text>
        </TouchableOpacity>
      </View>
    </ScrollView>
  );
};

export default Cadastro;

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
    paddingBottom: 16,
    justifyContent: 'space-around',
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
    color: '#333',
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
  buttonOption: {
    paddingHorizontal: 18,
    paddingVertical: 10,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#333',
    borderRadius: 10,
    marginVertical: 16,
    marginHorizontal: 4,
  },
  buttonOptionActive: {
    paddingHorizontal: 18,
    paddingVertical: 10,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#473088',
    borderRadius: 10,
    marginVertical: 16,
    marginHorizontal: 4,
  },
  buttonOptionText: {
    flexWrap: 'wrap',
    fontSize: 20,
    color: '#fff',
  },
});
