import React, { Component } from 'react'

export default class Sales extends Component {
    goHome = ()=>{
        this.props.history.push("/")
    }
    render() {
        return (
            <div>
                <h1>Sales!</h1>
                <button onClick={this.goHome} className="btn btn-danger">Go Home!</button>
            </div>
        )
    }
}
