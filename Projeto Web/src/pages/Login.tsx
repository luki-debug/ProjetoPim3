import React, { useContext, useState } from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';

import '../styles/pages/login.css';

import logoImage from '../images/lumiaLogo.png';
import api from '../services/api';
import { userContext } from '../App';

const Login: React.FC<RouteComponentProps> = ({ history }) => {
  const [, setUser] = useContext(userContext);
  const [loading, setLoading] = useState(false);
  const [erro, setErro] = useState(false);
  const [login, setLogin] = useState('');
  const [senha, setSenha] = useState('');

  const handleSubmit = (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();

    setLoading(true);

    api
      .post('/login', {
        Email: login,
        Senha: senha,
      })
      .then((response) => {
        setLoading(false);

        if (response.status === 200) {
          const { Id, Tipo } = response.data;

          setUser({
            fisica: Tipo === 'Fisica',
            id: Id,
          });

          history.push('/');
        }
      })
      .catch((err) => {
        setErro(true);

        setLoading(false);
      });
  };

  return (
    <div id='login'>
      <div className='loginContainer'>
        <img src={logoImage} alt='Logo' />
        <h1>Bem Vindo!</h1>
        <p>Acesse a sua conta</p>
        <form onSubmit={handleSubmit}>
          <input
            value={login}
            onInput={(event) => setLogin(event.currentTarget.value)}
            type='text'
            placeholder='Login'
          />
          <input
            value={senha}
            onInput={(event) => setSenha(event.currentTarget.value)}
            type='password'
            placeholder='Senha'
          />
          <div className='anotherOptionsContainer'>
            <Link to='/recuperarSenha'>ESQUECI A SENHA</Link>
            <Link to='/cadastro'>ABRA SUA CONTA</Link>
          </div>
          {erro && <span className='error'>Login e/ou Senha inválidos.</span>}

          <button
            type={loading ? 'button' : 'submit'}
            className={loading ? 'loading enter' : 'enter'}
          >
            {loading ? '...' : 'ENTRAR'}
          </button>
        </form>
      </div>
    </div>
  );
};

export default Login;
