import React, { Component } from 'react'

export default class Home extends Component {
    goToLink = () => {
        this.props.history.push("/link")
    }
    render() {
        return (
            <div>
                <h1>Hello!</h1>
                <button onClick={this.goToLink} className="btn btn-primary btn-pill">Go to Link!</button>
            </div>
        )
    }
}
