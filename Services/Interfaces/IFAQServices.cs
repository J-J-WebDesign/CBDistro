using CBDistro.Models.Domain;
using CBDistro.Models.Requests;
using System.Collections.Generic;

namespace CBDistro.Services.Interfaces
{
    public interface IFAQServices
    {
        List<FAQ> SelectAll();
        int Add(FAQAddRequest model);
        void Update(FAQUpdateRequest model);
        void Delete(FAQDeleteRequest model);
    }
}