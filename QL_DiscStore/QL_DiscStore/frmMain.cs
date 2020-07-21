using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiscStore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
                default:
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnThanhToan.Enabled = true;
                    btnKho.Enabled = false;
                    btnDoiMatKhau.Enabled = true;
                    btnLogOut.Enabled = true;
                    break;

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            frmLogin f = new frmLogin(this);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControlMain.TabPages.Clear();
            frmMain_Load(sender, e);
        }
    }
}
