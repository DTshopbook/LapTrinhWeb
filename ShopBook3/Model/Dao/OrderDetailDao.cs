using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class OrderDetailDao
    {
        ShopBookDbContext db = null;
        public OrderDetailDao()
        {
            db = new ShopBookDbContext();
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
            return db.OrdersDetails.OrderByDescending(x => x.OrderID).ToList();
        }
        public IEnumerable<OrdersDetail> ListAllOrder(int page, int pagelist)
        {
            IQueryable<OrdersDetail> model = db.OrdersDetails;
            return model.OrderByDescending(x => x.OrderID).ToPagedList(page, pagelist);
        }

    }
}
