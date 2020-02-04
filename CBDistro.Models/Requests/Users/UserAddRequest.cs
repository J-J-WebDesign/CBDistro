using CBDistro.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CBDistro.Models.Requests.Users
{
    public class UserAddRequest
    {
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please enter the email from 1 to 50 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,50}$"
        , ErrorMessage = "Password must contain at least One uppercase character, One lowercase character,One digit, One special character, and be at most 50 characters in length")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please enter the password from 1 to 50 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please enter the confirm password from 1 to 50 characters")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public int RoleId { get; set; }

        public bool IsConfirmed { get; set; }

    }
}
