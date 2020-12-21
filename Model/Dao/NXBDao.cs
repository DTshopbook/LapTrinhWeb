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
        ShopBook3DbContext db = null;
        public NXBDao()
        {
            db = new ShopBook3DbContext();
        }
        public Nxb ViewDetail(string ID)
        {
            return db.Nxbs.Find(ID);
        }
    }
}
