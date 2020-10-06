import React, { Component } from 'react';
import { useAuth0 } from "@auth0/auth0-react";

export class Profile extends Component {
    static displayname = Profile.name;

    LoginButton = () => {
    const { loginWithRedirect } = useAuth0();

    return <button onClick={() => loginWithRedirect()}>Log In</button>;
    };
    
  render() {
    return this.LoginButton;
  }
}
