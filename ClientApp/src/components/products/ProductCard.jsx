import React from "react";
import "./Product.css";

const ProductCard = props => {
  const onImageError = e => {
    e.target.onerror = null;
    e.target.src = "https://bit.ly/2QWQhwp";
  };
  const goToEditForm = () => {
    props.goToEdit(props.product);
  };
  return (
    <div className="card">
      <div className="row col-12 m-auto">
        <i
          className="mr-auto fa fa-2x fa-trash-o pt-3 trash cardButtons"
          aria-hidden="true"
        ></i>
        <h5 className="pt-3 m-auto">
          {props.product.name.length > 35
            ? props.product.name.slice(0, 35)
            : props.product.name}
        </h5>
        <i
          className="ml-auto fa fa-cog fa-2x pt-3 gear cardButtons"
          aria-hidden="true"
          onClick={goToEditForm}
        ></i>
      </div>
      <hr />
      <img
        className="mx-auto productImg rounded d-block mb-1"
        onError={onImageError}
        src={props.product.image}
        alt={props.product.description.slice(0, 30)}
      />
      <h6 className="mt-1">{props.product.brand}</h6>
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
