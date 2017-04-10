using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVuserLinq.DAL
{
    class LopDAL
    {
        QLSVDataContext DB = new QLSVDataContext();
        public List<Lop> LayDulieu()
        {
            return DB.Lops.ToList();
        }
    }
}
