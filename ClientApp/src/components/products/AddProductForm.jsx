import React, { Component } from "react";
import { Formik, Field } from "formik";
import { Form, FormGroup, Label } from "reactstrap";
import "./ProductForm.css";
import * as productServices from "../services/productServices";

export default class AddProductForm extends Component {
  constructor(props) {
    super(props);
    this.state = {
      formData: {
        name: "",
        description: "",
        price: "",
        image: "",
        brand: ""
      }
    };
  }
  handleSubmit = values => {
    productServices
      .add(values)
      .then(this.onAddSuccess)
      .catch(this.axiosFail);
  };

  onAddSuccess = data => {
    console.log(data);
  };

  axiosFail = (xhr, status, error) => {
    console.log(xhr, status, error);
  };
  render() {
    return (
      <Formik
        initialValues={this.state.formData}
        enableReinitialize={true}
        // validationSchema={resourceValidationSchema}
        // initialValues={this.state.formData}
        onSubmit={this.handleSubmit}
        // isInitialValid={this.state.isEditing}
      >
        {props => {
          const {
            values,
            // touched,
            errors,
            handleSubmit
            // isValid,
            // setFieldValue
          } = props;
          return (
            <Form className="col-lg-10 col-md-12 card m-auto p-4 " onSubmit={handleSubmit}>
              <Label className="row">
                <div className="col-10 m-auto">
                  <h5>Add A Product</h5>
                </div>
              </Label>
              <FormGroup>
                <Label className="row">
                  <div className="col-10 m-auto">
                    <strong>Name</strong>
                  </div>
                </Label>
                <Field type="text" value={values.name} name="name" className="form-control col-10 m-auto" placeholder="Name..." />
                {errors.name && <div id="feedback">{errors.name}</div>}
              </FormGroup>
              <FormGroup>
                <Label className="row">
                  <div className="col-10 m-auto">
                    <strong>Description</strong>
                  </div>
                </Label>
                <Field
                  type="text"
                  value={values.description}
                  name="description"
                  className="form-control col-10 m-auto"
                  placeholder="Description..."
                />
                {errors.name && <div id="feedback">{errors.description}</div>}
              </FormGroup>
              <FormGroup>
                <Label className="row">
                  <div className="col-10 m-auto">
                    <strong>Price</strong>
                  </div>
                </Label>
                <Field type="text" value={values.price} name="price" className="form-control col-10 m-auto" placeholder="Price..." />
                {errors.price && <div id="feedback">{errors.price}</div>}
              </FormGroup>
              <FormGroup>
                <Label className="row">
                  <div className="col-10 m-auto">
                    <strong>Image</strong>
                  </div>
                </Label>
                <Field type="text" value={values.image} name="image" className="form-control col-10 m-auto" placeholder="Image..." />
                {errors.image && <div id="feedback">{errors.image}</div>}
              </FormGroup>
              <FormGroup>
                <Label className="row">
                  <div className="col-10 m-auto">
                    <strong>Brand</strong>
                  </div>
                </Label>
                <Field type="text" value={values.brand} name="brand" className="form-control col-10 m-auto" placeholder="Brand..." />
                {errors.brand && <div id="feedback">{errors.brand}</div>}
              </FormGroup>
              <div className="row mt-2">
                <div className="col-10 m-auto">
                  <button type="submit" className="btn-pill btn btn-primary floatRight">
                    Submit
                  </button>
                </div>
              </div>
            </Form>
          );
        }}
      </Formik>
    );
  }
}
