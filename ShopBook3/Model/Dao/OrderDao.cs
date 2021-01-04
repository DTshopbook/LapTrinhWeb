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
        ShopBookDbContext db = null;
        public OrderDao()
        {
            db = new ShopBookDbContext();
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
            return model.OrderByDescending(x => x.OrderID).ToPagedList(page, pagelist);
        }
        public IEnumerable<Order> ListOder()
        {
            return db.Orders.Where(x=>x.Status == true).ToList();
        }
        public bool ChangeStatus(long ID)
        {
            var order = db.Orders.Find(ID);
            order.Status = !order.Status;
            db.SaveChanges();
            return order.Status;
        }

    }
}
