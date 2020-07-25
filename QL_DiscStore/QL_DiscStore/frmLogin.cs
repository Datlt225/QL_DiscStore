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
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HERE\SQLEXPRESS;Initial Catalog=QL_DiscStore;Integrated Security=True");
        
        public frmLogin (frmMain pf)
        {
            fMain = pf;
            InitializeComponent();
        }

        public static string ID_User = "";

        public void btnLogin_Click(object sender, EventArgs e)
        {
            ID_User = getID();
            if (ID_User != "")
            {
                frmMain fMain = new frmMain();
                fMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tai khoan");
            }
        
        }
        
        private string getID ()
        {
            string id = "";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from NhanVien where UserName = '" + txtUserName.Text + "' AND PassWord = '" + txtPassWord.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow dr  in dt.Rows)
                    {
                        id = dr["MaNV"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("sai mat khau");
            }

            finally
            {
                con.Close();
            }

            return id;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "admin";
            txtPassWord.Text = "123";
        }
    }
}
