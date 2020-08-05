using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiscStore.Class
{
    class XL_HoaDon : XL_Bang
    {
        public XL_HoaDon() : base("HoaDonCT") { }
        public XL_HoaDon(string pQuery) : base("HoaDonCT", pQuery) { }
    }
}
