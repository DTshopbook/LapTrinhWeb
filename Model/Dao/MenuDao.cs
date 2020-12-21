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
        ShopBook3DbContext db = null;
        public MenuDao()
        {
            db = new ShopBook3DbContext();
        }
        public List<Menu> List(int groupId)
        {
            return db.Menus.Where(x => x.Status == true).OrderBy(x => x.MenuID).ToList();
        }
    }
}
