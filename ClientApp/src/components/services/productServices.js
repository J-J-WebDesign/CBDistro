import axios from "axios";
import {
  onGlobalError,
  onGlobalSuccess,
  API_HOST_PREFIX
} from "./serviceHelpers";

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

export { getAll, add };
