import React, { Component } from 'react'
import * as productServices from "../services/productServices"
import ProductCard from "./ProductCard"
import "./Product.css";

export default class Products extends Component {
constructor(props){
    super(props)
    this.state = {
        products: null
    }
}

    componentDidMount(){
        productServices.getAll()
        .then(this.onGetAllSuccess)
        .catch(this.axiosFail)
    }

    onGetAllSuccess = data => {
        let vat = data.items.map(this.productMapper)
        this.setState(prevState=>{return{...prevState, products: vat}})
    }

    productMapper = (product) => (<ProductCard key={product.id} product={product}/>)

    goBack = ()=>{
        this.props.history.push("/")
    }

    render() {
        return (
            <div className="container col-12" id="products">
                <h3>Products!</h3>
                {this.state.products}
                <button onClick={this.goBack} className="btn btn-danger">Go Home!</button>
            </div>
        )
    }
}
