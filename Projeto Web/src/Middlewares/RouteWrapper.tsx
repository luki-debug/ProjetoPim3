import React, { useContext } from 'react';
import { Redirect, Route, RouteProps } from 'react-router-dom';
import { userContext } from '../App';

function RouteWrapper({
  redirectTo = '/login',
  isPrivate = false,
  component: Component,
  ...rest
}: {
  redirectTo?: string;
  isPrivate?: boolean;
  component: React.FC<any>;
} & RouteProps) {
  const [user] = useContext(userContext);
  const authenticated = !!user.id;

  if (!authenticated && isPrivate) return <Redirect to={redirectTo} />;

  return <Route {...rest} render={(props) => <Component {...props} />} />;
}

export default RouteWrapper;
