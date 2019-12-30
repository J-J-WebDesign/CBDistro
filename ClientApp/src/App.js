import React from 'react';
import './App.css';
import Home from "./components/home/Home"
import {Route}from "react-router-dom"
import Products from "./components/Products"
import Navbar from "./components/Navbar"

function App() {
  return (
    <div className="App">
      <Navbar/>
    <Route path="/" component={Home} exact={true} />
    <Route path="/products" component={Products} exact={true} />
    </div>
  );
}

export default App;
