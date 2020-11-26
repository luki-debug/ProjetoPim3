import { DrawerScreenProps } from '@react-navigation/drawer';
import React, { useContext, useEffect, useState } from 'react';
import { StyleSheet, TouchableOpacity, Text, View, Alert } from 'react-native';
import { ScrollView, TextInput } from 'react-native-gesture-handler';
import { FontAwesome5 } from '@expo/vector-icons';
import Header from '../components/Header';
import { loggedContext } from '../../App';
import api from '../services/api';

const Perfil: React.FC<DrawerScreenProps<{}>> = ({ navigation, route }) => {
  const [user] = useContext(loggedContext);

  const [nome, setNome] = useState('');
  const [cpf, setCpf] = useState('');
  const [rg, setRg] = useState('');
  const [nascimento, setNascimento] = useState('');
  const [razao, setRazao] = useState('');
  const [cnpj, setCnpj] = useState('');
  const [logradouro, setLogradouro] = useState('');
  const [numero, setNumero] = useState('');
  const [cep, setCep] = useState('');
  const [cidade, setCidade] = useState('');
  const [estado, setEstado] = useState('');
  const [telefone, setTelefone] = useState('');
  const [email, setEmail] = useState('');
  const [senha, setSenha] = useState('');

  const [updating, setUpdating] = useState(false);

  useEffect(() => {
    if (user.fisica) {
      api
        .get(`/pessoafisica/${user.id}`)
        .then((response) => {
          if (response.status === 200) {
            const {
              CEP,
              CPF,
              Cidade,
              DataNascimento,
              Email,
              Estado,
              Logradouro,
              Nome,
              Numero,
              RG,
              Telefone,
              Senha,
            } = response.data;

            setNome(Nome);
            setCpf(CPF);
            setRg(RG);
            setNascimento(String(DataNascimento).substring(0, 10));
            setLogradouro(Logradouro);
            setNumero(Numero);
            setCep(CEP);
            setCidade(Cidade);
            setEstado(Estado);
            setTelefone(Telefone);
            setEmail(Email);
            setSenha(Senha);
          }
        })
        .catch((err) => {
          console.error(err);
        });
    } else {
      api
        .get(`/pessoajuridica/${user.id}`)
        .then((response) => {
          if (response.status === 200) {
            const {
              CEP,
              CNPJ,
              Cidade,
              RazaoSocial,
              Email,
              Estado,
              Logradouro,
              Numero,
              Telefone,
              Senha,
            } = response.data;

            setCnpj(CNPJ);
            setRazao(RazaoSocial);
            setLogradouro(Logradouro);
            setNumero(Numero);
            setCep(CEP);
            setCidade(Cidade);
            setEstado(Estado);
            setTelefone(Telefone);
            setEmail(Email);
            setSenha(Senha);
          }
        })
        .catch((err) => {
          console.error(err);
        });
    }
  }, []);

  const handleSave = () => {
    setUpdating(true);
    const dateBirth = new Date(nascimento).toISOString();

    if (user.fisica) {
      api
        .put('/pessoafisica', {
          IdPessoa: user.id,
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
        .then(() => {
          setUpdating(false);

          Alert.alert('Sucesso!', 'Dados atualizados.', [
            {
              text: 'OK',
            },
          ]);
        })
        .catch((err) => {
          setUpdating(false);
          console.error(err);

          Alert.alert('Ops', 'Algo deu errado.', [
            {
              text: 'OK',
            },
          ]);
        });
    } else {
      api
        .put('/pessoajuridica', {
          IdPessoa: user.id,
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
        .then(() => {
          setUpdating(false);

          Alert.alert('Sucesso!', 'Dados atualizados.', [
            {
              text: 'OK',
            },
          ]);
        })
        .catch((err) => {
          setUpdating(false);
          console.error(err);

          Alert.alert('Ops', 'Algo deu errado.', [
            {
              text: 'OK',
            },
          ]);
        });
    }
  };

  return (
    <>
      <Header openSidemenu={navigation.openDrawer} route={route.name} />
      <ScrollView style={styles.scroll} keyboardShouldPersistTaps='always'>
        <View style={styles.perfilContainer}>
          <FontAwesome5 name='user-alt' style={styles.icon} />
          {user.fisica ? (
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
              value={String(numero)}
              onChangeText={(text) => setNumero(text)}
              style={styles.input}
            ></TextInput>
          </View>
          <View style={styles.inputContainer}>
            <Text style={styles.label}>CEP</Text>
            <TextInput
              value={cep}
              onChangeText={(text) => setCep(text)}
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
            onPress={updating ? undefined : handleSave}
            style={styles.buttonEnter}
          >
            <Text style={styles.buttonText}>
              {updating ? 'Salvando' : 'Salvar'}
            </Text>
          </TouchableOpacity>
        </View>
      </ScrollView>
    </>
  );
};

export default Perfil;

const styles = StyleSheet.create({
  scroll: {
    backgroundColor: '#362466',
    flex: 1,
  },
  perfilContainer: {
    padding: 16,
    margin: 16,
    backgroundColor: '#5e4a97',
    borderRadius: 20,
    alignItems: 'center',
  },
  icon: {
    fontSize: 128,
    color: '#fff',
    marginBottom: 16,
  },
  inputContainer: {
    justifyContent: 'center',
    alignItems: 'flex-start',
    width: '100%',
  },
  label: {
    color: '#fff',
    fontSize: 24,
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
