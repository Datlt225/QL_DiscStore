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
using System.IO;

namespace QL_DiscStore
{
    public partial class frmpay : Form
    {
        public frmpay()
        {
            InitializeComponent();
        }
        XL_HoaDon tblHoaDonCT;
        BindingManagerBase DS;

        private void btnExit_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DS.CancelCurrentEdit();
            tblHoaDonCT.RejectChanges();
        }

        private void frmpay_Load(object sender, EventArgs e)
        {
            

            tblHoaDonCT = new XL_HoaDon();
            LoadDGV();

            txtMaHDCT.DataBindings.Add("text", tblHoaDonCT, "MaHDCT", true);
            txtMaHD.DataBindings.Add("text", tblHoaDonCT, "MaHD", true);
            txtMaSP.DataBindings.Add("text", tblHoaDonCT, "MaSP", true);
            txtSoLuong.DataBindings.Add("text", tblHoaDonCT, "SoLuong", true);
            txtThanhTien.DataBindings.Add("text", tblHoaDonCT, "ThanhTien", true);

            DS = this.BindingContext[tblHoaDonCT];
        }

        private void LoadDGV()
        {
            dgvPay.AutoGenerateColumns = false;
            dgvPay.DataSource = tblHoaDonCT;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DS.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DS.RemoveAt(DS.Position);
            if (!tblHoaDonCT.ghi())
            {
                MessageBox.Show("Xóa thất bại!!!");
            }
        }
    }
}
