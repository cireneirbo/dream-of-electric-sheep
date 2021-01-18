import React, { Component } from 'react';
import { Route, Switch } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { useAuth0 } from "@auth0/auth0-react";
import { ProtectedRoute } from './auth/protected-route';
import { NavMenu } from "./components/NavMenu";
import { Loading } from "./components/loading";
import { Profile } from "./views/profile";
import { FetchCrypto } from './components/FetchCrypto';
import './custom.css';
import './styles/assets/css/main.css';
import { FetchCoinMarketCapData } from './components/FetchCoinMarketCapData';

const App = () => {
  const { isLoading } = useAuth0();

  if (isLoading) {
    return <Loading />;
  }

  return (
    <div id="logo" className="d-flex flex-column h-100">
      <NavMenu />
      <div id="nav" className="container flex-grow-1">
        <Switch>
          <Route path="/" exact component={Home} />
          <Route path="/counter" component={Counter} />
          <Route path="/fetchCryptoAPI" component={FetchCrypto} />
          <Route path="/fetchWeatherAPI" component={FetchData} />
          <Route path="/fetchCoinMarketCapAPI" component={FetchCoinMarketCapData} />
          <ProtectedRoute path="/profile" component={Profile} />
        </Switch>
      </div>
    </div>
  );
};

export default App;
