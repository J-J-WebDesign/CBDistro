import React, { Component } from 'react'
import HomeBanner from "./HomeBanner"
// import "./Home.css"

export default class Home extends Component {
    goToProducts = () => {
        this.props.history.push("/products")
    }
    render() {
        return (
            <div className="container col-12">
                {//CBDistro cool logo/title
                }
                <HomeBanner goToProducts={this.goToProducts} className="bannerHeight" />
                <h1>Hello!</h1>
                <button onClick={this.goToProducts} className="btn btn-primary btn-pill">Go to Products!</button>
            </div>
        )
    }
}
