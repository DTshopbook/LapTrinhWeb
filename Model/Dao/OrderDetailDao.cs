using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class OrderDetailDao
    {
        ShopBook3DbContext db = null;
        public OrderDetailDao()
        {
            db = new ShopBook3DbContext();
        }
        public bool Insert(OrdersDetail detail)
        {
            try
            {
                db.OrdersDetails.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }
        public List<OrdersDetail> ListOderDetail()
        {            
            return db.OrdersDetails.ToList();
        }


    }
}
