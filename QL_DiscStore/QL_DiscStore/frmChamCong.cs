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
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }

        XL_ChamCong tblChamCong;
        XL_NhanVien tblNhanVien;
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DiscStoreDataSet1.ChamCong' table. You can move, or remove it, as needed.
            //this.chamCongTableAdapter.Fill(this.qL_DiscStoreDataSet1.ChamCong);
            tblNhanVien = new XL_NhanVien();
            tblChamCong = new XL_ChamCong();
            loadCTChamCong();
            loadNhanVien();
            dtNgay.Value = DateTime.Now;
        }

        private void loadCTChamCong()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblNhanVien, tblChamCong});
            DataRelation qh = new DataRelation("FRK_NhanVien_ChamCong", tblNhanVien.Columns["MaNV"], tblChamCong.Columns["MaNV"]);
            ds.Relations.Add(qh);

            DataColumn cTenVN = new DataColumn("TenNV", Type.GetType("System.String"), "Parent(FRK_NhanVien_ChamCong).TenNV");
            tblChamCong.Columns.Add(cTenVN);

            dgvChamCong.AutoGenerateColumns = false;
            dgvChamCong.DataSource = tblChamCong;
        }

        private void loadNhanVien()
        {
            listStaff.DataSource = tblNhanVien;
            listStaff.ValueMember = "MaNV";
            listStaff.DisplayMember = "TenNV";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void dtNgay_ValueChanged(object sender, EventArgs e)
        {
            tblChamCong.locDuLieu("Ngay =" + dtNgay.Value.ToLongDateString() +"'");
        }

        private void dgvChamCong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvChamCong.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void dgvChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 4 || e.ColumnIndex == 5))
            {
                if (e.ColumnIndex == 5)
                    tblChamCong.Rows[e.RowIndex].Delete();
                tblChamCong.ghi();
            }
        }
    }
}
