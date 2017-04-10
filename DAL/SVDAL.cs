using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVuserLinq.DAL
{
    class SVDAL
    {
        QLSVDataContext DB = new QLSVDataContext();
        public List<SV> LayDulieu()
        {
            return  DB.SVs.Select(s => s).ToList();
        }
    }
}
