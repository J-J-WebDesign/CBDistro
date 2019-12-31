import React, { Component } from 'react'

export default class Cart extends Component {
    goBack = () => {
        this.props.history.goBack();
    }
    render() {
        return (
            <div>
                <h1>This is the cart!</h1>
                <button className="btn btn-secondary" onClick={this.goBack}>Go back</button>
            </div>
        )
    }
}
