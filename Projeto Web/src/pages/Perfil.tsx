import React, { useContext, useEffect, useState } from 'react';
import { FaUserAlt } from 'react-icons/fa';
import { userContext } from '../App';
import Header from '../components/Header';
import Sidemenu from '../components/Sidemenu';
import api from '../services/api';

import '../styles/pages/perfil.css';

const Perfil: React.FC = () => {
  const [user] = useContext(userContext);

  const [nome, setNome] = useState('');
  const [cpf, setCpf] = useState('');
  const [rg, setRg] = useState('');
  const [nascimento, setNascimento] = useState('2020-11-20');
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

          alert('Sucesso!');
        })
        .catch((err) => {
          setUpdating(false);
          console.error(err);

          alert('Erro!');
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

          alert('Sucesso!');
        })
        .catch((err) => {
          setUpdating(false);
          console.error(err);

          alert('Erro!');
        });
    }
  };

  return (
    <div id='perfil'>
      <Sidemenu />
      <div className='perfilContent'>
        <Header />
        <div className='content'>
          <div className='itemsContainer'>
            <div className='inputsContainer'>
              {user.fisica ? (
                <>
                  <div className='inputBox'>
                    <label htmlFor='nome'>Nome</label>
                    <input
                      value={nome}
                      onInput={(event) => setNome(event.currentTarget.value)}
                      type='text'
                      id='nome'
                      placeholder='Nome'
                    />
                  </div>
                  <div className='inputBox'>
                    <label htmlFor='cpf'>CPF</label>
                    <input
                      value={cpf}
                      onInput={(event) => setCpf(event.currentTarget.value)}
                      type='text'
                      id='cpf'
                      placeholder='CPF'
                    />
                  </div>
                  <div className='inputBox'>
                    <label htmlFor='rg'>RG</label>
                    <input
                      value={rg}
                      onInput={(event) => setRg(event.currentTarget.value)}
                      type='text'
                      id='rg'
                      placeholder='RG'
                    />
                  </div>
                  <div className='inputBox'>
                    <label htmlFor='datanascimento'>Data de Nascimento</label>
                    <input
                      value={nascimento}
                      onInput={(event) =>
                        setNascimento(event.currentTarget.value)
                      }
                      type='date'
                      id='datanascimento'
                    />
                  </div>
                </>
              ) : (
                <>
                  <div className='inputBox'>
                    <label htmlFor='razaosocial'>Razão Social</label>
                    <input
                      value={razao}
                      onInput={(event) => setRazao(event.currentTarget.value)}
                      type='text'
                      id='razaosocial'
                      placeholder='Razão Social'
                    />
                  </div>
                  <div className='inputBox'>
                    <label htmlFor='cnpj'>CNPJ</label>
                    <input
                      value={cnpj}
                      onInput={(event) => setCnpj(event.currentTarget.value)}
                      type='text'
                      id='cnpj'
                      placeholder='CNPJ'
                    />
                  </div>
                </>
              )}
              <div className='inputBox'>
                <label htmlFor='logradouro'>Logradouro</label>
                <input
                  value={logradouro}
                  onInput={(event) => setLogradouro(event.currentTarget.value)}
                  type='text'
                  id='logradouro'
                  placeholder='Logradouro'
                />
              </div>
              <div className='inputBox'>
                <label htmlFor='numero'>Numero</label>
                <input
                  value={numero}
                  onInput={(event) => setNumero(event.currentTarget.value)}
                  type='text'
                  id='numero'
                  placeholder='Numero'
                />
              </div>
              <div className='inputBox'>
                <label htmlFor='cep'>CEP</label>
                <input
                  value={cep}
                  onInput={(event) => setCep(event.currentTarget.value)}
                  type='text'
                  id='cep'
                  placeholder='CEP'
                />
              </div>
              <div className='inputBox'>
                <label htmlFor='cidade'>Cidade</label>
                <input
                  value={cidade}
                  onInput={(event) => setCidade(event.currentTarget.value)}
                  type='text'
                  id='cidade'
                  placeholder='Cidade'
                />
              </div>
              <div className='inputBox'>
                <label htmlFor='estado'>Estado</label>
                <input
                  value={estado}
                  onInput={(event) => setEstado(event.currentTarget.value)}
                  type='text'
                  id='estado'
                  placeholder='Estado'
                />
              </div>
              <div className='inputBox'>
                <label htmlFor='telefone'>Telefone</label>
                <input
                  value={telefone}
                  onInput={(event) => setTelefone(event.currentTarget.value)}
                  type='text'
                  id='telefone'
                  placeholder='Telefone'
                />
              </div>
              <div className='inputBox'>
                <label htmlFor='email'>Email</label>
                <input
                  value={email}
                  onInput={(event) => setEmail(event.currentTarget.value)}
                  type='text'
                  id='email'
                  placeholder='Email'
                />
              </div>
              <div className='inputBox'>
                <label htmlFor='senha'>Senha</label>
                <input
                  value={senha}
                  onInput={(event) => setSenha(event.currentTarget.value)}
                  type='password'
                  id='senha'
                  placeholder='Senha'
                />
              </div>
              <button
                onClick={updating ? undefined : handleSave}
                className={updating ? 'salvar updating' : 'salvar'}
              >
                {updating ? 'Salvando' : 'Salvar'}
              </button>
            </div>
            <div className='iconContainer'>
              <FaUserAlt />
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Perfil;
