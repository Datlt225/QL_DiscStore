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
using System.Diagnostics;

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
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HERE\SQLEXPRESS;Initial Catalog=QL_DiscStore;Integrated Security=True");
        private int pQ()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select MaLTK from NhanVien where MaNV ='" + frmLogin.ID_User + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                        return Convert.ToInt32(row["MaLTK"].ToString());

                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            return 0;
        }
                    
        private void PhanQuyen()
        {
            switch (this.pQ())
            {
                case 1:
                    btnNhanVien.Enabled = true;
                    btnChamCong.Enabled = true;
                    btnThanhToan.Enabled = true;
                    btnKho.Enabled = true;
                    btnDoiMatKhau.Enabled = true;
                    btnLogOut.Enabled = true;
                    btnExit.Enabled = true;
                    break;
                case 2:
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnThanhToan.Enabled = true;
                    btnKho.Enabled = false;
                    btnDoiMatKhau.Enabled = true;
                    btnLogOut.Enabled = true;
                    btnExit.Enabled = true;
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
            PhanQuyen();
            frmLogin f = new frmLogin();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Maximized;
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

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("QuanLyNhanVien");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else
            {
                frmStaff f = new frmStaff();
                f.MdiParent = this;
                TabPage p = new TabPage(f.Text);
                p.Name = "QuanLyNhanVien";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.PhanQuyen();
        }

        private void btnThanhToan_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("DoiMatKhau");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else
            {
                frmpay f = new frmpay();
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

        private void btnChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("DoiMatKhau");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else
            {
                frmChamCong f = new frmChamCong();
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

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("DoiMatKhau");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else
            {
                frmQL_Kho f = new frmQL_Kho();
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
    }
}
