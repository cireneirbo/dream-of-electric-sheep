import React, { Component } from 'react';
import { Route, Switch } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { useAuth0 } from "@auth0/auth0-react";
import { ProtectedRoute } from './auth/protected-route';
import './custom.css'
import { NavMenu } from "./components/NavMenu";
import { Loading } from "./components/loading";
import { Profile } from "./views/profile";
import { FetchCrypto } from './components/FetchCrypto';

const App = () => {
  const { isLoading } = useAuth0();

  if (isLoading) {
    return <Loading />;
  }

  return (
    <div id="app" className="d-flex flex-column h-100">
      <NavMenu />
      <div className="container flex-grow-1">
        <Switch>
          <Route path="/" exact component={Home} />
          <ProtectedRoute path="/counter" component={Counter} />
          <ProtectedRoute path="/fetchCryptoAPI" component={FetchCrypto} />
          <ProtectedRoute path="/fetchWeatherAPI" component={FetchData} />
          <ProtectedRoute path="/profile" component={Profile} />
        </Switch>
      </div>
    </div>
  );
};

export default App;






/*
export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data' component={FetchData} />
        
      </Layout>
    );
  }
}*/
