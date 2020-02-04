import React from "react";
import "./Product.css";

const ProductCard = props => {
  const onImageError = e => {
    e.target.onerror = null;
    e.target.src = "https://bit.ly/2QWQhwp";
  };
  return (
    <div className="card">
      <h5 className="pt-4">{props.product.name}</h5>
      <hr />
      <img
        className="mx-auto productImg rounded d-block"
        onError={onImageError}
        src={props.product.image}
        alt={props.product.description.slice(0, 50)}
      />
      <h6>{props.product.brand}</h6>
      <hr />
      <h5>${props.product.price}</h5>
      <hr />
      <p className="mb-3">
        {props.product.description > 50
          ? props.product.description.slice(0, 50) + "..."
          : props.product.description}
      </p>
    </div>
  );
};

export default ProductCard;
