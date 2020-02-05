using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBDistro.Models.Requests
{
    public class ProductUpdateRequest: ProductAddRequest, IModelIdentifier
    {
        public int Id { get; set; }
    }
}
