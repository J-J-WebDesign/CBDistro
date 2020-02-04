import React from "react";
import "./Navbar.css";

const Navbar = props => {
  return (
    <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
      <a className="navbar-brand brand" href="/">
        CBDistro
      </a>
      <button
        className="navbar-toggler"
        type="button"
        data-toggle="collapse"
        data-target="#navbarSupportedContent"
        aria-controls="navbarSupportedContent"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span className="navbar-toggler-icon"></span>
      </button>
      <div className="collapse navbar-collapse" id="navbarSupportedContent">
        <ul className="navbar-nav mr-auto">
          <li className="nav-item">
            <a className="nav-link" href="/products">
              Products
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link " href="/sales">
              Sales
            </a>
          </li>
          <li className="nav-item dropdown show">
            <span
              className="nav-link dropdown-toggle"
              id="navbarDropdown"
              role="button"
              data-toggle="dropdown"
              aria-haspopup="true"
              aria-expanded="false"
            >
              Dropdown
            </span>
            <div className="dropdown-menu" aria-labelledby="navbarDropdown">
              <a className="dropdown-item" href="/1">
                Action
              </a>
              <a className="dropdown-item" href="/2">
                Another action
              </a>
              <div className="dropdown-divider"></div>
              <a className="dropdown-item" href="/3">
                Something else here
              </a>
            </div>
          </li>
        </ul>
        <ul className="navbar-nav">
          <li className="ml-auto nav-item">
            <a className="nav-link" href="/cart">
              <i className="fas fa-lg fa-cart-plus cart" />
            </a>
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
