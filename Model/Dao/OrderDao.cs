using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class OrderDao
    {
        ShopBook3DbContext db = null;
        public OrderDao()
        {
            db = new ShopBook3DbContext();
        }

        public Order ViewDetail(long orderID)
        {
            return db.Orders.Find(orderID);
        }
        public long Insert(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.OrderID;
        }
        public IEnumerable<Order> ListAllOrder(int page, int pagelist)
        {
            IQueryable<Order> model = db.Orders;
            //if (!string.IsNullOrEmpty(searchString))
            //{
            //    model = model.Where(x => x.Catogoryname.Contains(searchString));
            //}

            return db.Orders.OrderByDescending(x => x.OrderID).ToPagedList(page, pagelist);
        }
        public List<Order> ListOder()
        {
            return db.Orders.Where(x=>x.Status == true).ToList();
        }

    }
}
