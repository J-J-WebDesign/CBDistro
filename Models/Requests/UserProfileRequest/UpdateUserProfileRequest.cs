using System;
using System.Collections.Generic;
using System.Text;

namespace CBDistro.Models.Requests
{
    public class UpdateUserProfileRequest : AddUserProfileRequest, IModelIdentifier
    {
        public int Id { get; set; }
    }
}
