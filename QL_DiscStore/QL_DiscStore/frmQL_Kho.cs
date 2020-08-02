using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_DiscStore.Class;

namespace QL_DiscStore
{
    public partial class frmQL_Kho : Form
    {
        public frmQL_Kho()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }
        XL_SanPham tblSanPham;
        BindingManagerBase DS;
        
        private void frmQL_Kho_Load(object sender, EventArgs e)
        {
            tblSanPham = new XL_SanPham();
        }
    }
}
