using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using Model.Dao;
using PagedList;

namespace Model.Dao
{
    public class ReceiptDao
    {
        ShopBook3DbContext db = null;
        public ReceiptDao()
        {
            db = new ShopBook3DbContext();
        }
        public string Insert(Receipt entity)
        {
            db.Receipts.Add(entity);
            db.SaveChanges();
            return entity.ReceiptID;
        }
        public Receipt GetByID(string recname)
        {
            return db.Receipts.SingleOrDefault(x => x.Username == recname);
        }
        public Receipt ViewDetail(string recID)
        {
            return db.Receipts.Find(recID);
        }
        public bool Update(Receipt entity)
        {
            try
            {
                var Rec = db.Receipts.Find(entity.ReceiptID);
                Rec.Username = entity.Username;
                Rec.DateCreate = entity.DateCreate;
                Rec.PriceTotal = entity.PriceTotal;
                Rec.ProductAmount = entity.ProductAmount;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                //logging
                return false;
            }
        }
        public bool Delete(string recID)
        {
            try
            {
                var Rec = db.Receipts.Find(recID);
                db.Receipts.Remove(Rec);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //public bool ChangeStatus(string recID)
        //{
        //    var Cate = db.Categories.Find(recID);
        //    Cate.Statuss = !Cate.Statuss;
        //    db.SaveChanges();
        //    return Cate.Statuss;
        //}
        //public bool CheckCategoryName(string categoryname)
        //{
        //    return db.Categories.Count(x => x.CategoryName == categoryname) > 0;
        //}
        public IEnumerable<Receipt> ListAllPaging(int page, int pagelist)
        {
            IQueryable<Receipt> model = db.Receipts;
            //if (!string.IsNullOrEmpty(searchString))
            //{
            //    model = model.Where(x => x.Catogoryname.Contains(searchString));
            //}

            return db.Receipts.OrderByDescending(x => x.ReceiptID).ToPagedList(page, pagelist);
        }
        public List<Receipt> Listcate()
        {
            return db.Receipts.ToList();
        }

    }
}
