using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class NXBDao
    {
        ShopBookDbContext db = null;
        public NXBDao()
        {
            db = new ShopBookDbContext();
        }
        public Nxb ViewDetail(string ID)
        {
            return db.Nxbs.Find(ID);
        }
    }
}
