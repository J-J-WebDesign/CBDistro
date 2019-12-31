import React from 'react';
import './App.css';
import Home from "./components/home/Home"
import {Route}from "react-router-dom"
import Products from "./components/products/Products"
import Navbar from "./components/Navbar"
import Cart from "./components/cart/Cart"
import Sales from "./components/sales/Sales"

function App() {
  return (
    <div className="App">
      <div className="navbarSpacing">
      <Navbar/>
      </div>
    <Route path="/" component={Home} exact={true} />
    <Route path="/products" component={Products} exact={true} />
    <Route path="/sales" component={Sales} exact={true} />
    <Route path="/cart" component={Cart} exact={true} />
    </div>
  );
}

export default App;
