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
using DevExpress.XtraBars;

namespace QL_DiscStore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public string maNV;

        internal void enableControl(int maLTK)
        {
            switch (maLTK)
            {
                case 1:
                    btnNhanVien.Enabled = true;
                    btnChamCong.Enabled = true;
                    btnThanhToan.Enabled = true;
                    btnKho.Enabled = true;
                    btnDoiMatKhau.Enabled = true;
                    btnLogOut.Enabled = true;
                    break;
                case 2:
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnThanhToan.Enabled = true;
                    btnKho.Enabled = false;
                    btnDoiMatKhau.Enabled = true;
                    btnLogOut.Enabled = true;
                    break;

            }
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn đăng xuất không?", "Warning", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                tabControlMain.TabPages.Clear();
                this.Close();
                frmMain_Load(sender, e);
            }
        }

        private void frmMain_Load(object sender, ItemClickEventArgs e)
        {
            enableControl(-1);
            frmLogin f = new frmLogin();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("DoiMatKhau");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else
            {
                frmChangPass f = new frmChangPass();
                f.MdiParent = this;
                TabPage p = new TabPage(f.Text);
                p.Name = "DoiMatkhau";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Warning", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }
    }
}
