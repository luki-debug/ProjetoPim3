import React from 'react';
import Routes from './routes';

import './styles/global.css';
import usePersistedState, {
  UsePersistedStateResponse,
} from './utils/usePersistedState';

interface User {
  id?: number;
  fisica?: boolean;
  saldo?: string;
}

export const userContext = React.createContext<UsePersistedStateResponse<User>>(
  [{}, () => {}]
);

function App() {
  const [user, setUser] = usePersistedState<User>('user', {});

  return (
    <userContext.Provider value={[user, setUser]}>
      <Routes />
    </userContext.Provider>
  );
}

export default App;
