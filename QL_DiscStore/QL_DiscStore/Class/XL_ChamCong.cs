using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiscStore.Class
{
    class XL_ChamCong : XL_Bang
    {
        public XL_ChamCong() : base("ChamCong") { }
        public XL_ChamCong(string pQuery) : base("ChamCong", pQuery) { }
    }
}