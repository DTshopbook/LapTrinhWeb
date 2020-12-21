using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ShopBook3.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please enter a username !")]
        public string UserName { set; get; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter a password !")]
        public string Password { set; get; }

    }
}