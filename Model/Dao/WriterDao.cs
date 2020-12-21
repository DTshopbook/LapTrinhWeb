using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class WriterDao
    {
        ShopBook3DbContext db = null;
        public WriterDao()
        {
            db = new ShopBook3DbContext();
        }
        public Writer ViewDetail(string ID)
        {
            return db.Writers.Find(ID);
        }
    }
}
