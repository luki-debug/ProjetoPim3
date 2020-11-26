import React, { useState } from 'react';
import { StatusBar } from 'expo-status-bar';
import AppAuth from './src/Routes';

export const loggedContext = React.createContext<
  [UserLogged, React.Dispatch<React.SetStateAction<UserLogged>>]
>([{ id: 0, logged: false }, () => {}]);

interface UserLogged {
  id: number;
  logged: boolean;
  saldo?: string;
  fisica?: boolean;
}

export default function App() {
  const [logged, setLogged] = useState<UserLogged>({ id: 0, logged: false });

  return (
    <loggedContext.Provider value={[logged, setLogged]}>
      <StatusBar style='light' backgroundColor='#473088' />
      <AppAuth />
    </loggedContext.Provider>
  );
}
