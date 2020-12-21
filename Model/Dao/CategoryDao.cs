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
    public class CategoryDao
    {
        ShopBook3DbContext db = null;
        public CategoryDao()
        {
            db = new ShopBook3DbContext();
        }
        public string Insert(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
            return entity.CategoryID;
        }
        public Category GetByID(string catogoryname)
        {
            return db.Categories.SingleOrDefault(x => x.CategoryName == catogoryname );
        }

        public Category ViewDetail(string catogoryID)
        {
            return db.Categories.Find(catogoryID);
        }
        public bool Update(Category entity)
        {
            try
            {
                var Cate = db.Categories.Find(entity.CategoryID);
                Cate.CategoryName = entity.CategoryName;
                Cate.Statuss = entity.Statuss;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                //logging
                return false;
            }
        }
        public bool Delete(string cateID)
        {
            try
            {
                var Cate = db.Categories.Find(cateID);
                db.Categories.Remove(Cate);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ChangeStatus(string categoryname)
        {
            var Cate = db.Categories.Find(categoryname);
            Cate.Statuss = !Cate.Statuss;
            db.SaveChanges();
            return Cate.Statuss;
        }
        public bool CheckCategoryName(string categoryname)
        {
            return db.Categories.Count(x => x.CategoryName == categoryname) > 0;
        }
        public IEnumerable<Category> ListAllPaging(int page, int pagelist)
        {
            IQueryable<Category> model = db.Categories;
            return db.Categories.OrderByDescending(x => x.CategoryID).ToPagedList(page, pagelist);
        }
        public List<Category>Listcate()
        {
            return db.Categories.Where(x=>x.Statuss==true).OrderBy(x=>x.CategoryID).ToList();
        }
    }
}
