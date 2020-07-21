using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiscStore.Class
{
    class XL_NhanVien: XL_Bang
    {
        public XL_NhanVien() : base("NhanVien") { }
        public XL_NhanVien( string pQuery) : base("NhanVien", pQuery) { }
    }
}
