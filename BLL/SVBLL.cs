using QLSVuserLinq.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVuserLinq.BLL
{
    class SVBLL
    {
        SVDAL svDAL = new SVDAL();
        public List<SV> LayTatCa()
        {
            return svDAL.LayDulieu();
        }
    }
}
