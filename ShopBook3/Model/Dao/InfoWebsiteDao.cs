using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class InfoWebsiteDao
    {
        ShopBookDbContext db = null;
        public InfoWebsiteDao()
        {
            db = new ShopBookDbContext();
        }
        public InfoWebsite ViewDetail(string name)
        {
            return db.InfoWebsites.Find(name);
        }
        public IEnumerable<InfoWebsite> ListAllPaging(int page = 1, int pagelist = 1)
        {
            IQueryable<InfoWebsite> model = db.InfoWebsites;
            return model.OrderBy(x => x.Webname).ToPagedList(page, pagelist);
        }
        public List<InfoWebsite> ListAll()
        {
            return db.InfoWebsites.ToList();
        }
        public bool Update(InfoWebsite entity)
        {
            try
            {
                var web = db.InfoWebsites.Find(entity.Webname);
                web.Webname = entity.Webname;
                web.WebAddress = entity.WebAddress;
                web.WebPhone = entity.WebPhone;
                web.WebEmail = entity.WebEmail;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                //logging
                return false;
            }
        }
    }
}
