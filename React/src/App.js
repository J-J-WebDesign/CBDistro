import React from 'react';
import './App.css';
import Home from "./components/Home"
import {Route}from "react-router-dom"
import Link from "./components/Link"

function App() {
  return (
    <div className="App">
    <Route path="/" component={Home} exact={true} />
    <Route path="/link" component={Link} exact={true} />
    </div>
  );
}

export default App;
