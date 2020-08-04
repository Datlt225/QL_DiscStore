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
using System.Data.Linq;
using System.IO;

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
        bool update = false;
        
        private void frmQL_Kho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DiscStoreDataSet2.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qL_DiscStoreDataSet2.SanPham);

            tblSanPham = new XL_SanPham();
            LoadDGVSP();

            txtMaSP.DataBindings.Add("text", tblSanPham, "MaSP", true);
            txtTenSP.DataBindings.Add("text", tblSanPham, "TenSP", true);
            txtTheLoai.DataBindings.Add("text", tblSanPham, "TheLoai", true);
            txtSoLuong.DataBindings.Add("text", tblSanPham, "SoLuong", true);

            DS = this.BindingContext[tblSanPham];
            enableNutLenh(false);
        }

        private void LoadDGVSP()
        {
            dgvSP.AutoGenerateColumns = false;
            dgvSP.DataSource = tblSanPham;
        }

        private void enableNutLenh(bool v)
        {
            btnAdd.Enabled = !update;
            btnDelete.Enabled = !update;
            btnEdit.Enabled = !update;
            btnExit.Enabled = !update;
            btnSave.Enabled = update;
            btnCancel.Enabled = update;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DS.AddNew();
            enableNutLenh(true);
            update = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enableNutLenh(true);
            update = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DS.EndCurrentEdit();
                tblSanPham.ghi();
                enableNutLenh(true);
                update = false;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DS.CancelCurrentEdit();
            tblSanPham.RejectChanges();
            enableNutLenh(true);
            update = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DS.RemoveAt(DS.Position);
            if (!tblSanPham.ghi())
            {
                MessageBox.Show("Xóa thất bại!!!");
            }
        }
    }
}
