import React from "react";
import "./App.css";
import Home from "./components/home/Home";
import { Route } from "react-router-dom";
import Products from "./components/products/Products";
import Navbar from "./components/common/Navbar";
import Cart from "./components/cart/Cart";
import Sales from "./components/sales/Sales";
import ProductForm from "./components/products/ProductForm";

function App() {
  return (
    <div className="App">
      <div className="backGround">
        <div className="navbarSpacing">
          <Navbar />
        </div>
        <Route path="/" component={Home} exact={true} />
        <Route path="/products" component={Products} exact={true} />
        <Route path="/products/add" component={ProductForm} exact={true} />
        <Route path="/products/:id/edit" component={ProductForm} exact={true} />
        <Route path="/sales" component={Sales} exact={true} />
        <Route path="/cart" component={Cart} exact={true} />
      </div>
    </div>
  );
}

export default App;
