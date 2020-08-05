namespace QL_DiscStore
{
    partial class frmpay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpay));
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHDCT = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.qL_DiscStoreDataSet1 = new QL_DiscStore.QL_DiscStoreDataSet1();
            this.qLDiscStoreDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_DiscStoreDataSet2 = new QL_DiscStore.QL_DiscStoreDataSet2();
            this.hoaDonCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonCTTableAdapter = new QL_DiscStore.QL_DiscStoreDataSet2TableAdapters.HoaDonCTTableAdapter();
            this.qL_DiscStoreDataSet = new QL_DiscStore.QL_DiscStoreDataSet();
            this.qLDiscStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonCTTableAdapter1 = new QL_DiscStore.QL_DiscStoreDataSetTableAdapters.HoaDonCTTableAdapter();
            this.qL_DiscStoreDataSet3 = new QL_DiscStore.QL_DiscStoreDataSet3();
            this.hoaDonCTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonCTTableAdapter2 = new QL_DiscStore.QL_DiscStoreDataSet3TableAdapters.HoaDonCTTableAdapter();
            this.hoaDonCTBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.maHDCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiscStoreDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiscStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonCTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonCTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonCTBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(994, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 65);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(880, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 65);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(880, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 65);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(994, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 65);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvPay
            // 
            this.dgvPay.AutoGenerateColumns = false;
            this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDCTDataGridViewTextBoxColumn,
            this.maHDDataGridViewTextBoxColumn,
            this.maSPDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dgvPay.DataSource = this.hoaDonCTBindingSource3;
            this.dgvPay.Location = new System.Drawing.Point(78, 329);
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.RowTemplate.Height = 24;
            this.dgvPay.Size = new System.Drawing.Size(764, 218);
            this.dgvPay.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 57;
            this.label1.Text = "Phiếu Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mã Hóa ĐơnCT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Mã Hóa Đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 58;
            this.label4.Text = "Mã Sản Phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(621, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "Số Lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Thành Tiền:";
            // 
            // txtMaHDCT
            // 
            this.txtMaHDCT.Location = new System.Drawing.Point(322, 93);
            this.txtMaHDCT.Name = "txtMaHDCT";
            this.txtMaHDCT.Size = new System.Drawing.Size(199, 22);
            this.txtMaHDCT.TabIndex = 59;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(322, 151);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(199, 22);
            this.txtMaHD.TabIndex = 59;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(322, 215);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(199, 22);
            this.txtMaSP.TabIndex = 59;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(757, 93);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(199, 22);
            this.txtSoLuong.TabIndex = 59;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(757, 151);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(199, 22);
            this.txtThanhTien.TabIndex = 59;
            // 
            // qL_DiscStoreDataSet1
            // 
            this.qL_DiscStoreDataSet1.DataSetName = "QL_DiscStoreDataSet1";
            this.qL_DiscStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLDiscStoreDataSet1BindingSource
            // 
            this.qLDiscStoreDataSet1BindingSource.DataSource = this.qL_DiscStoreDataSet1;
            this.qLDiscStoreDataSet1BindingSource.Position = 0;
            // 
            // qL_DiscStoreDataSet2
            // 
            this.qL_DiscStoreDataSet2.DataSetName = "QL_DiscStoreDataSet2";
            this.qL_DiscStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonCTBindingSource
            // 
            this.hoaDonCTBindingSource.DataMember = "HoaDonCT";
            this.hoaDonCTBindingSource.DataSource = this.qL_DiscStoreDataSet2;
            // 
            // hoaDonCTTableAdapter
            // 
            this.hoaDonCTTableAdapter.ClearBeforeFill = true;
            // 
            // qL_DiscStoreDataSet
            // 
            this.qL_DiscStoreDataSet.DataSetName = "QL_DiscStoreDataSet";
            this.qL_DiscStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLDiscStoreDataSetBindingSource
            // 
            this.qLDiscStoreDataSetBindingSource.DataSource = this.qL_DiscStoreDataSet;
            this.qLDiscStoreDataSetBindingSource.Position = 0;
            // 
            // hoaDonCTBindingSource1
            // 
            this.hoaDonCTBindingSource1.DataMember = "HoaDonCT";
            this.hoaDonCTBindingSource1.DataSource = this.qLDiscStoreDataSetBindingSource;
            // 
            // hoaDonCTTableAdapter1
            // 
            this.hoaDonCTTableAdapter1.ClearBeforeFill = true;
            // 
            // qL_DiscStoreDataSet3
            // 
            this.qL_DiscStoreDataSet3.DataSetName = "QL_DiscStoreDataSet3";
            this.qL_DiscStoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonCTBindingSource2
            // 
            this.hoaDonCTBindingSource2.DataMember = "HoaDonCT";
            this.hoaDonCTBindingSource2.DataSource = this.qL_DiscStoreDataSet3;
            // 
            // hoaDonCTTableAdapter2
            // 
            this.hoaDonCTTableAdapter2.ClearBeforeFill = true;
            // 
            // hoaDonCTBindingSource3
            // 
            this.hoaDonCTBindingSource3.DataMember = "HoaDonCT";
            this.hoaDonCTBindingSource3.DataSource = this.qL_DiscStoreDataSet3;
            // 
            // maHDCTDataGridViewTextBoxColumn
            // 
            this.maHDCTDataGridViewTextBoxColumn.DataPropertyName = "MaHDCT";
            this.maHDCTDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn chi tiết";
            this.maHDCTDataGridViewTextBoxColumn.Name = "maHDCTDataGridViewTextBoxColumn";
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // frmpay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 620);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtMaHDCT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Name = "frmpay";
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.frmpay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiscStoreDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiscStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonCTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonCTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonCTBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHDCT;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtThanhTien;
        private QL_DiscStoreDataSet1 qL_DiscStoreDataSet1;
        private System.Windows.Forms.BindingSource qLDiscStoreDataSet1BindingSource;
        private QL_DiscStoreDataSet2 qL_DiscStoreDataSet2;
        private System.Windows.Forms.BindingSource hoaDonCTBindingSource;
        private QL_DiscStoreDataSet2TableAdapters.HoaDonCTTableAdapter hoaDonCTTableAdapter;
        private System.Windows.Forms.BindingSource qLDiscStoreDataSetBindingSource;
        private QL_DiscStoreDataSet qL_DiscStoreDataSet;
        private System.Windows.Forms.BindingSource hoaDonCTBindingSource1;
        private QL_DiscStoreDataSetTableAdapters.HoaDonCTTableAdapter hoaDonCTTableAdapter1;
        private QL_DiscStoreDataSet3 qL_DiscStoreDataSet3;
        private System.Windows.Forms.BindingSource hoaDonCTBindingSource2;
        private QL_DiscStoreDataSet3TableAdapters.HoaDonCTTableAdapter hoaDonCTTableAdapter2;
        private System.Windows.Forms.BindingSource hoaDonCTBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
    }
}