using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DiscStore.Class;
using System.Data.SqlClient;

namespace QL_DiscStore
{
    public partial class frmChangPass : Form
    {
        public frmChangPass()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HERE\SQLEXPRESS;Initial Catalog=QL_DiscStore;Integrated Security=True");


        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNewPass, "");
            errorProvider1.SetError(txtReNewPass, "");

            /*if (txtNewPass.Text.Length < 8 || txtNewPass.Text.Any(char.IsDigit)
                || txtNewPass.Text.Any(char.IsLower) || txtNewPass.Text.Any(char.IsUpper)) ;
            {
                errorProvider1.SetError(txtNewPass, "Mật khẩu mới tới thiểu 8 ký tự, bao gồm số, " +
                    "in hoa, in thường.");
                return;
            }*/

            if (txtNewPass.Text != txtReNewPass.Text)
            {
                errorProvider1.SetError(txtNewPass, "Mật khẩu không trùng khớp!");
                return;
            }

            frmMain f = (frmMain)this.MdiParent;


            
            int count = XL_Bang.Thuc_hien_lenh("Update NhanVien set PassWord ='"
                + txtNewPass.Text + "'where MaNV ='" + frmLogin.ID_User + "'");

            if (count > 0)
            {
                MessageBox.Show("Cap nhat thanh cong!!");
            }
            else
            {
                MessageBox.Show("Cap nhat that bai!!");
            }
        }



        private void frmChangPass_Load(object sender, EventArgs e)
        {

        }
    }
}
