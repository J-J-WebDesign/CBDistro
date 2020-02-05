using CBDistro.Models.Domain;
using CBDistro.Models.Requests;
using CBDistro.Web.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBDistro.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        int Add(ProductAddRequest model);
        void Update(ProductUpdateRequest model);
        void Delete(int id);
    }
}
