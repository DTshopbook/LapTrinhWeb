using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopBook3.Models
{
    [Serializable]
    public class CartProduct
    {
        public Product Product  { set; get; }
        public int Amount { set; get; }
    }

}