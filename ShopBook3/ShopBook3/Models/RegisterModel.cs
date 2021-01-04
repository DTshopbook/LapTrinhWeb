using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopBook3.Models
{
    public class RegisterModel
    {
            [Display(Name = "UserName")]
            [Required(ErrorMessage = "Please enter a username !")]
            public string UserName { set; get; }

            [Display(Name = "Password")]
            [StringLength(20, MinimumLength = 6, ErrorMessage = "Password is at least 6 characters long !")]
            [Required(ErrorMessage = "Plese enter a password")]
            public string Password { set; get; }

            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "Password was wrong !")]
            public string ConfirmPassword { set; get; }

            [Display(Name = "Email")]
            [Required(ErrorMessage = "Please enter a email !")]
            public string Email { set; get; }


    }
}