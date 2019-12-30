import React, { Component } from 'react'

export default class Link extends Component {
    goBack = ()=>{
        this.props.history.goBack()
    }
    render() {
        return (
            <div>
                <h3>Products!</h3>
                <button onClick={this.goBack} className="btn btn-danger">Go Home!</button>
            </div>
        )
    }
}
