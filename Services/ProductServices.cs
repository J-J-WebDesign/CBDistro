using CBDistro.Models;
using CBDistro.Models.Domain;
using CBDistro.Data.Providers;
using System;
using System.Collections.Generic;
using CBDistro.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using CBDistro.Data.Extensions;
using static CBDistro.Services.Interfaces.IProductServices;

namespace CBDistro.Services
{
    public class ProductServices : IProductService
    {
        IDataProvider _data = null;
        public ProductServices(IDataProvider data)
        {
            _data = data;
        }
        public List<Product> GetAll()
        {
            //Paged<Product> pagedResult = null;
            List<Product> result = null;
            //Product Products = null;
            //int totalCount = 0;
            _data.ExecuteCmd(
                "[dbo].[Product_SelectAll]",
                inputParamMapper: delegate (SqlParameterCollection parameterCollection)
                {
                    //parameterCollection.AddWithValue("@pageIndex", pageIndex);
                    //parameterCollection.AddWithValue("@pageSize", pageSize);
                },
                singleRecordMapper: delegate (IDataReader reader, short set)
                {
                    Product product = MapProduct(reader);

                    //if (totalCount == 0)
                    //{
                    //    totalCount = reader.GetSafeInt32(13);
                    //}
                    if (result == null)
                    {
                        result = new List<Product>();
                    }
                    result.Add(product);
                }
            );
            if (result != null)
            {
                result = new List<Product>(result);
            }
            return result;
        }
        private static Product MapProduct(IDataReader reader)
        {
            Product product = new Product();

            int startingIndex = 0;

            product.Id = reader.GetSafeInt32(startingIndex++);
            product.Name = reader.GetSafeString(startingIndex++);

            return product;
        }


    }
}
