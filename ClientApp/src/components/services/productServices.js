import axios from "axios";
import { onGlobalError, onGlobalSuccess, API_HOST_PREFIX } from "./serviceHelpers";

const getAll = () => {
  const config = {
    method: "GET",
    withCredentials: true,
    crossdomain: true,
    url: `${API_HOST_PREFIX}/products`
  };

  return axios(config)
    .then(onGlobalError)
    .catch(onGlobalSuccess);
};

const add = data => {
  const config = {
    method: "POST",
    withCredentials: true,
    crossdomain: true,
    data: data,
    url: `${API_HOST_PREFIX}/products/add`
  };

  return axios(config)
    .then(onGlobalError)
    .catch(onGlobalSuccess);
};

const update = data => {
  const config = {
    method: "PUT",
    withCredentials: true,
    crossdomain: true,
    data: data,
    url: `${API_HOST_PREFIX}/products/update/${data.id}`
  };

  return axios(config)
    .then(onGlobalError)
    .catch(onGlobalSuccess);
};

const deleteProduct = data => {
  const config = {
    method: "DELETE",
    withCredentials: true,
    crossdomain: true,
    data: data,
    url: `${API_HOST_PREFIX}/products/delete/${data.id}`
  };

  return axios(config)
    .then(onGlobalError)
    .catch(onGlobalSuccess);
};

export { getAll, add, update, deleteProduct };
