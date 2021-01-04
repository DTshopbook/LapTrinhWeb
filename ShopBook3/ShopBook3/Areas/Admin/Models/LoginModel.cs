using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopBook3.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please input user name")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Please input password")]
        public string Password { set; get; }

        //public bool RememberMe { set; get; }
    }
}