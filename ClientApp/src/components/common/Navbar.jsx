import React, { useState } from "react";
import "./Navbar.css";
import {
  Dropdown,
  DropdownToggle,
  DropdownMenu,
  DropdownItem
} from "reactstrap";

const Navbar = props => {
  const [dropdownOpen, setDropdownOpen] = useState(false);
  const toggle = () => setDropdownOpen(prevState => !prevState);
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
            <a className="nav-link btn mt-1 mb-0 pb-0" href="/products">
              Products
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link btn mt-1 mb-0 pb-0" href="/">
              Sales
            </a>
          </li>
          <li className="nav-item mb-0 ">
            <Dropdown
              className="btn nav-link topPadding pl-0 mb-0"
              isOpen={dropdownOpen}
              toggle={toggle}
            >
              <DropdownToggle className="dropdownBtn pb-0" caret>
                Admin
              </DropdownToggle>
              <DropdownMenu>
                <DropdownItem href="/products/add">Add Prduct</DropdownItem>
                <DropdownItem divider />
                <DropdownItem>Quo Action</DropdownItem>
              </DropdownMenu>
            </Dropdown>
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
