import React, { Component } from "react";
import * as productServices from "../services/productServices";
import ProductCard from "./ProductCard";
import "./Product.css";

export default class Products extends Component {
  constructor(props) {
    super(props);
    this.state = {
      products: null
    };
  }

  componentDidMount() {
    productServices
      .getAll()
      .then(this.onGetAllSuccess)
      .catch(this.axiosFail);
  }

  onGetAllSuccess = data => {
    let vat = data.items.map(this.productMapper);
    this.setState(prevState => {
      return { ...prevState, products: vat };
    });
  };

  productMapper = product => (
    <ProductCard
      goToEdit={this.goToEditForm}
      key={product.id}
      product={product}
    />
  );

  goBack = () => {
    this.props.history.push("/");
  };

  goToEditForm = product => {
    this.props.history.push(`/products/${product.id}/edit`, product);
  };

  render() {
    return (
      <div className="container col-12" id="products">
        <h3>Products!</h3>
        <div className="card-columns col-10 m-auto">{this.state.products}</div>
        <button onClick={this.goBack} className="btn btn-danger">
          Go Home!
        </button>
      </div>
    );
  }
}
