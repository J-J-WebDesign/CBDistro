using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CBDistro.Models.Requests
{
    public class AddUserProfileRequest
    {
        [Required(ErrorMessage = "A first name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage ="Please enter a first name from 1 to 50 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "A last name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please enter a first name from 1 to 50 characters")]
        public string LastName { get; set; }
        [StringLength(1, ErrorMessage = "A middle initial must be one character")]
        public string Mi { get; set; }
        [Required]

        public string AvatarUrl { get; set; }
    }
}
