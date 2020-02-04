using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CBDistro.Models.Requests
{
    public class UserTokensAddRequest
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Token { get; set; }
        [Required]
        public string TokenType { get; set; }

    }
}
