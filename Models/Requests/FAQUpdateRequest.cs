﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CBDistro.Models.Requests
{
    public class FAQUpdateRequest: FAQAddRequest, IModelIdentifier
    {
        [Required(ErrorMessage = "Please give an Id.")]
        public int Id { get; set; }
    }
}
