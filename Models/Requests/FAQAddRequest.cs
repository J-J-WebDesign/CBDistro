using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CBDistro.Models.Requests
{
    public class FAQAddRequest
    {
        [Required]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Please enter a question.")]
        public string Question { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Please enter an answer.")]
        public string Answer { get; set; }

    }
}
