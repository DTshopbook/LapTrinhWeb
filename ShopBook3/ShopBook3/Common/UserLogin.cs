using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopBook3
{
    [Serializable]
    public class UserLogin
    {
        public string Username { set; get; }
        public string Pasword { set; get; }
    }
}