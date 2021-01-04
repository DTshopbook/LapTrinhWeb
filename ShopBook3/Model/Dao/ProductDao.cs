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
    public class ProductDao
    {
        ShopBookDbContext db = null;
        public ProductDao()
        {
            db = new ShopBookDbContext();
        }
        public string Insert(Product entity)
        {
            entity.Status = true;
            db.Products.Add(entity);
            db.SaveChanges();
            return entity.ProductID;
        }
        public Product GetByID(string productID)
        {
            return db.Products.SingleOrDefault(x => x.ProductID == productID);
        }
        public Product ViewDetail(string productID)
        {
            return db.Products.Find(productID);         
        }
        public Product ViewByCate(string cateID)
        {
            return db.Products.Find(cateID);
        }
        public bool Update(Product entity)
        {
            try
            {
                var product = db.Products.Find(entity.ProductID);
                product.NameBook = entity.NameBook;
                product.WriterID = entity.WriterID;
                product.NxbID = entity.NxbID;
                product.Price = entity.Price;
                product.Amount = entity.Amount;
                product.Describe = entity.Describe;
                product.ImageID = entity.ImageID;
                product.CategoryID = entity.CategoryID;
                product.Status = true;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                //logging
                return false;
            }
        }
        public bool Delete(string id)
        {
            try
            {
                var product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CheckCategoryName(string categoryname)
        {
            return db.Categories.Count(x => x.CategoryName == categoryname) > 0;
        }
        public IEnumerable<Product> ListAllPaging(string searchString, int page, int pagelist)
        {
            IQueryable<Product> model = db.Products;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.NameBook.Contains(searchString));
            }
            return model.Where(x=>x.Status==true).OrderByDescending(x => x.Amount).ToPagedList(page, pagelist);
        }
        public List<Product>Listproduct()
        {
            return db.Products.ToList();
        }
        public List<Product> ListRelatedProducts(string productID)
        {
            var product = db.Products.Find(productID);
            return db.Products.Where(x => x.ProductID != productID && x.CategoryID == product.CategoryID).ToList();
        }
        public List<Product> ListCateID(string categoryID)
        {
            var cateID = db.Categories.Find(categoryID);
            return db.Products.Where(x => x.CategoryID == cateID.CategoryID).ToList();
        }
        public bool ChangeStatus(string productID)
        {
            var pro = db.Products.Find(productID);
            pro.Status = !pro.Status;
            db.SaveChanges();
            return pro.Status;
        }
    }
}
