using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class MenuDao
    {
        ShopBookDbContext db = null;
        public MenuDao()
        {
            db = new ShopBookDbContext();
        }
        public List<Menu> List()
        {
            return db.Menus.Where(x => x.Status == true).OrderBy(x => x.MenuID).ToList();
        }
    }
}
