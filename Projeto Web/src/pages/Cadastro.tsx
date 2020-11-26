import React, { useContext, useState } from 'react';

import '../styles/pages/login.css';
import '../styles/pages/cadastro.css';

import logoImage from '../images/lumiaLogo.png';
import api from '../services/api';
import { RouteComponentProps } from 'react-router-dom';
import { userContext } from '../App';

const Cadastro: React.FC<RouteComponentProps> = ({ history }) => {
  const [, setUser] = useContext(userContext);
  const [fisica, setFisica] = useState(true);

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

  const handleSubmit = (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();

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

            setUser({ fisica: true, id });

            history.push('/');
          }
        })
        .catch((err) => {
          console.error(err);

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

            setUser({ fisica: false, id });

            history.push('/');
          }
        })
        .catch((err) => {
          console.error(err);

          setCreating(false);
        });
    }
  };

  return (
    <div id='login'>
      <div className='loginContainer'>
        <img src={logoImage} alt='Logo' />
        <h1>Cadastrar</h1>
        <p>Abra a sua conta</p>
        <div className='optionsContainer'>
          <button
            onClick={() => setFisica(true)}
            className={fisica ? 'active' : ''}
          >
            Pessoa Física
          </button>
          <button
            onClick={() => setFisica(false)}
            className={fisica ? '' : 'active'}
          >
            Pessoa Jurídica
          </button>
        </div>
        <form onSubmit={handleSubmit}>
          {fisica ? (
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
                  onInput={(event) => setNascimento(event.currentTarget.value)}
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
            <label htmlFor='cep'>CEP</label>
            <input
              onChange={(e) => {
                const newCep = e.target.value;
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
              onInput={(event) => setCep(event.currentTarget.value)}
              value={cep}
              type='number'
              id='cep'
              autoComplete='noff'
              placeholder='CEP'
            />
          </div>
          <div className='inputBox'>
            <label htmlFor='logradouro'>Logradouro</label>
            <input
              onChange={(e) => setLogradouro(e.target.value)}
              onInput={(event) => setLogradouro(event.currentTarget.value)}
              value={logradouro}
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
            <label htmlFor='cidade'>Cidade</label>
            <input
              onChange={(e) => setCidade(e.target.value)}
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
              onChange={(e) => setEstado(e.target.value)}
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
            type={creating ? 'button' : 'submit'}
            className={creating ? 'enter creating' : 'enter'}
          >
            Cadastrar
          </button>
        </form>
      </div>
    </div>
  );
};

export default Cadastro;
