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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        frmMain fMain = null;
        XL_NhanVien tblNhanVien;

        public frmLogin (frmMain pf)
        {
            fMain = pf;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XL_NhanVien();
            DataRow[] r = tblNhanVien.Select("UserName='" + txtUserName.Text + "'and PassWord='"
               + txtPassWord.Text + "'");
            if(r.Count() > 0)
            {
                fMain.Text = "Hello" + r[0]["TenNV"].ToString();
                fMain.maNV = r[0]["MaNV"].ToString();
                fMain.enableControl((int)r[0]["MaLTK"]);
                this.Close();
            }

            else
            {
                MessageBox.Show("Dang nhap khong dung");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
