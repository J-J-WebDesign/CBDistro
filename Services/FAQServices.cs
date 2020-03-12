using CBDistro.Data.Extensions;
using CBDistro.Data.Providers;
using CBDistro.Models;
using CBDistro.Models.Domain;
using CBDistro.Models.Requests;
using CBDistro.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CBDistro.Services
{
    public class FAQServices : IFAQServices
    {
        IDataProvider _data = null;
        public FAQServices(IDataProvider data)
        {
            _data = data;
        }
        public List<FAQ> SelectAll()
        {
            List<FAQ> result = null;
            string procname = "dbo.FAQ_SelectAll";
            _data.ExecuteCmd(procname, inputParamMapper: null,
            singleRecordMapper: delegate (IDataReader reader, short set)
            {
                FAQ faq = MapFAQ(reader);

                if (result == null)
                {
                    result = new List<FAQ>();
                }
                result.Add(faq);
            }
            );
            return result;
        }
        public int Add(FAQAddRequest model)
        {
            int id = 0;
            string procName = "[dbo].[FAQ_Insert]";
            _data.ExecuteNonQuery(procName,
                inputParamMapper: delegate (SqlParameterCollection col)
                {
                    col.AddWithValue("Question", model.Question);
                    col.AddWithValue("Answer", model.Answer);

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
        private static FAQ MapFAQ(IDataReader reader)
        {
            FAQ faq = new FAQ();
            int startingIndex = 0;

            faq.Id = reader.GetSafeInt32(startingIndex++);
            faq.DateCreated = reader.GetSafeDateTime(startingIndex++);
            faq.DateModified = reader.GetSafeDateTime(startingIndex++);
            faq.Question = reader.GetSafeString(startingIndex++);
            faq.Answer = reader.GetSafeString(startingIndex++);

            return faq;
        }
        public void Update(FAQUpdateRequest model)
        {
            string procName = "[dbo].[FAQ_Update]";
            _data.ExecuteNonQuery(procName,
            inputParamMapper: delegate (SqlParameterCollection col)
            {
                col.AddWithValue("@Id", model.Id);
                col.AddWithValue("@Question", model.Question);
                col.AddWithValue("@Answer", model.Answer);

            },
        returnParameters: null);
        }

        public void Delete(FAQDeleteRequest model)
        {
            string procName = "[dbo].[FAQ_DeleteById]";
            _data.ExecuteNonQuery(procName,
            inputParamMapper: delegate (SqlParameterCollection col)
            {
                col.AddWithValue("@Id", model.Id);
            },
        returnParameters: null);
        }
    }
}
