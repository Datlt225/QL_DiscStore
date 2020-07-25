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
using System.IO;
using QL_DiscStore.Class;
using System.Data.Linq;

namespace QL_DiscStore
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }
        XL_NhanVien tblNhanVien;
        BindingManagerBase DS;
        bool update = false;


        private void btnExit_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            tblNhanVien = new XL_NhanVien();
            LoadDGVStaff();

            txtMaNV.DataBindings.Add("text",tblNhanVien, "MaNV", true);
            txtTenNV.DataBindings.Add("text", tblNhanVien, "TenNV", true);
            txtGT.DataBindings.Add("text", tblNhanVien, "GioiTinh", true);
            txtSDT.DataBindings.Add("text", tblNhanVien, "SDT", true);
            dtNgayVL.DataBindings.Add("text", tblNhanVien, "NgayVaoLam", true);
            txtGmail.DataBindings.Add("text", tblNhanVien, "Gmail", true);
            txtUser.DataBindings.Add("text", tblNhanVien, "UserName", true);
            txtPass.DataBindings.Add("text", tblNhanVien, "PassWord", true);
            txtLTK.DataBindings.Add("text", tblNhanVien, "MaLTK", true);

            DS = this.BindingContext[tblNhanVien];
            enableNutLenh(false);
        }

        private void LoadDGVStaff()
        {
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.DataSource = tblNhanVien;
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
                tblNhanVien.ghi();
                enableNutLenh(true);
                update = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DS.CancelCurrentEdit();
            tblNhanVien.RejectChanges();
            enableNutLenh(true);
            update = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DS.RemoveAt(DS.Position);
            if(!tblNhanVien.ghi())
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
