using CBDistro.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBDistro.Services.Interfaces
{
    public class IProductServices
    {
        public interface IProductService
        {
            List<Product> GetAll();

        }
    }
}
