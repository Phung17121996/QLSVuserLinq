using QLSVuserLinq.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLSVuserLinq.BLL
{
    public class LopBLL
    {
        LopDAL lopDAL = new LopDAL();
        public List<Lop> LayTatCa()
        {
            return lopDAL.LayDulieu();
        }

    }
}
