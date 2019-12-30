import React from 'react';

const Navbar = () => {
    return (
        <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
  <a className="navbar-brand" href="/">CBDistro</a>
  <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span className="navbar-toggler-icon"></span>
  </button>
  <div className="collapse navbar-collapse" id="navbarSupportedContent">
    <ul className="navbar-nav mr-auto">
      <li className="nav-item">
        <a className="nav-link" href="/products">Products</a>
      </li>
      <li className="nav-item">
        <a className="nav-link " href="/sales" >Sales</a>
      </li>
      <li className="nav-item dropdown show">{
        // eslint-disable-next-line jsx-a11y/anchor-is-valid
        }<a className="nav-link dropdown-toggle" id="navbarDropdown" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
          Dropdown
        </a>
        <div className="dropdown-menu" aria-labelledby="navbarDropdown">
          <a className="dropdown-item" href="/1">Action</a>
          <a className="dropdown-item" href="/2">Another action</a>
          <div className="dropdown-divider"></div>
          <a className="dropdown-item" href="/3">Something else here</a>
        </div>
      </li>
    </ul>
  </div>
  </nav>
    );
};

export default Navbar;