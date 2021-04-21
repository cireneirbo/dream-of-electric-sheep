import React, { Component } from 'react';

export class FetchCrypto extends Component {
  static displayName = FetchCrypto.name;

  constructor(props) {
    super(props);
    this.state = { prices: [], loading: true };
  }

  componentDidMount() {
    this.populateCryptoPrice();
  }

  static renderPricesTable(prices) {
    
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {prices.map(price =>
            <tr key={price.date}>
              <td>{price.date}</td>
              <td>{price.temperatureC}</td>
              <td>{price.temperatureF}</td>
              <td>{price.summ}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchCrypto.renderPricesTable(this.state.prices);

    return (
      <div>
        <h1 id="tabelLabel" >Crypto prices</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateCryptoPrice() {
    const response = await fetch('cryptoprices');
    const data = await response.json();
    this.setState({ prices: data, loading: false });
  }

  
}
