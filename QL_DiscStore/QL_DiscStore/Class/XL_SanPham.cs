using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiscStore.Class
{
    class XL_SanPham: XL_Bang
    {
        public XL_SanPham() : base("SanPham") { }
        public XL_SanPham(string pQuery) : base("SanPham",pQuery) { }
    }
}
