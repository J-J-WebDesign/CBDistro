using CBDistro.Models.Domain;
using CBDistro.Data.Providers;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CBDistro.Data.Extensions;
using CBDistro.Services.Interfaces;
using CBDistro.Models.Requests;
using System;
using CBDistro.Web.Models.Responses;
using Microsoft.AspNetCore.Mvc;

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
                inputParamMapper: null,
                //delegate (SqlParameterCollection parameterCollection)
                //{
                    //parameterCollection.AddWithValue("@pageIndex", pageIndex);
                    //parameterCollection.AddWithValue("@pageSize", pageSize);
                //},
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
        public int Add(ProductAddRequest model)
        {
            int id = 0;
            string procName = "[dbo].[Product_Insert]";
            _data.ExecuteNonQuery(procName,
                inputParamMapper: delegate (SqlParameterCollection col)
                {
                    AddCommonParams(model, col);
                    SqlParameter idOut = new SqlParameter("@Id", SqlDbType.Int);
                    idOut.Direction = ParameterDirection.Output;
                    col.Add(idOut);
                },
                returnParameters: delegate (SqlParameterCollection returnCollection)
                {
                    object oId = returnCollection["@Id"].Value;
                    Int32.TryParse(oId.ToString(), out id);
                });
            return id;
        }
        public void Update(ProductUpdateRequest model)
        {
            string procName = "[dbo].[Product_Update]";
            _data.ExecuteNonQuery(procName,
            inputParamMapper: delegate (SqlParameterCollection col)
            {
                col.AddWithValue("@Id", model.Id);
                AddCommonParams(model, col);

            },
        returnParameters: null);
        }
        public void Delete(int id)
        {
            string procName = "[dbo].[Product_Delete]";

            _data.ExecuteNonQuery(procName, delegate (SqlParameterCollection paramCollection)
            {
                paramCollection.AddWithValue("@Id", id);

            }, returnParameters: null);
        }
        private static Product MapProduct(IDataReader reader)
        {
            Product product = new Product();

            int startingIndex = 0;

            product.Id = reader.GetSafeInt32(startingIndex++);
            product.Name = reader.GetSafeString(startingIndex++);
            product.Description = reader.GetSafeString(startingIndex++);
            product.Price = reader.GetSafeInt32(startingIndex++);
            product.Image = reader.GetSafeString(startingIndex++);
            product.Brand = reader.GetSafeString(startingIndex++);
            product.DateCreated = reader.GetSafeDateTime(startingIndex++);
            product.DateModified = reader.GetSafeDateTime(startingIndex++);


            return product;
        }
        private static void AddCommonParams(ProductAddRequest model, SqlParameterCollection col)
        {
            col.AddWithValue("@Name", model.Name);
            col.AddWithValue("@Description", model.Description);
            col.AddWithValue("@Price", model.Price);
            col.AddWithValue("@Image", model.Image);
            col.AddWithValue("@Brand", model.Brand);
        }
    }
}
