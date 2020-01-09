import React, { Component } from 'react'
import * as productServices from "../services/productServices"

export default class Link extends Component {
constructor(props){
    super(props)
    this.state = {
        products:0
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

    productMapper = (product) => {
        return product.name
    }

    goBack = ()=>{
        this.props.history.push("/")
    }

    render() {
        return (
            <div>
                <h3>Products!</h3>
                {/* {this.state.products} */}
                <button onClick={this.goBack} className="btn btn-danger">Go Home!</button>
            </div>
        )
    }
}
