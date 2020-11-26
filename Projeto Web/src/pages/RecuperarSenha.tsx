import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import api from '../services/api';

import '../styles/pages/login.css';
import '../styles/pages/recuperar-senha.css';

const RecuperarSenha: React.FC = () => {
  const [emailSended, setEmailSended] = useState(false);

  const handleSubmit = (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();

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

  return (
    <div id='login'>
      <div className='loginContainer'>
        {!emailSended ? (
          <>
            <h1>Recuperar Senha</h1>
            <p>Digite seu email para recuperar a senha.</p>
            <form onSubmit={handleSubmit}>
              <input
                value={email}
                onInput={(event) => setEmail(event.currentTarget.value)}
                type='text'
                placeholder='Email'
              />
              <button type='submit' className='enter'>
                Enviar
              </button>
            </form>
          </>
        ) : (
          <>
            <h1>Enviado!</h1>
            <p>Verifique seu email.</p>
            <Link to='/Login' className='enter'>
              Login
            </Link>
          </>
        )}
      </div>
    </div>
  );
};

export default RecuperarSenha;
