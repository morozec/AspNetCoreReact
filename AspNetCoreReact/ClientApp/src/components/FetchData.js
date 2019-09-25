import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor (props) {
    super(props);
    this.state = { cars: [], loading: true };

    fetch('api/Car/cars')
      .then(response => response.json())
      .then(cars => {
        console.log(cars)
        this.setState({cars:cars, loading: false });
        
      });
  }

  renderCars(){
    return (
      <div>
        {this.state.cars.map(car => 
          <div key={car.carId}>
            <p>{car.name} {car.price}</p>           
          </div>
          )}
      </div>
    )
  }

  
  render () {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : this.renderCars();

    return (
      <div>
        <h1>Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }
}
