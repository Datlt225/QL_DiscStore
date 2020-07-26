namespace QL_DiscStore
{
    partial class frmChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamCong));
            this.gbTTChamCong = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numNgay = new System.Windows.Forms.NumericUpDown();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.qL_DiscStoreDataSet = new QL_DiscStore.QL_DiscStoreDataSet();
            this.qLDiscStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_DiscStoreDataSet1 = new QL_DiscStore.QL_DiscStoreDataSet1();
            this.chamCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamCongTableAdapter = new QL_DiscStore.QL_DiscStoreDataSet1TableAdapters.ChamCongTableAdapter();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heSoLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.listStaff = new System.Windows.Forms.ListBox();
            this.gbTTChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiscStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTTChamCong
            // 
            this.gbTTChamCong.Controls.Add(this.listStaff);
            this.gbTTChamCong.Controls.Add(this.dtNgay);
            this.gbTTChamCong.Controls.Add(this.btnExit);
            this.gbTTChamCong.Controls.Add(this.txtSalary);
            this.gbTTChamCong.Controls.Add(this.numNgay);
            this.gbTTChamCong.Controls.Add(this.label3);
            this.gbTTChamCong.Controls.Add(this.label2);
            this.gbTTChamCong.Controls.Add(this.label4);
            this.gbTTChamCong.Controls.Add(this.label1);
            this.gbTTChamCong.Location = new System.Drawing.Point(41, 12);
            this.gbTTChamCong.Name = "gbTTChamCong";
            this.gbTTChamCong.Size = new System.Drawing.Size(1081, 202);
            this.gbTTChamCong.TabIndex = 0;
            this.gbTTChamCong.TabStop = false;
            this.gbTTChamCong.Text = "Thông Tin Chấm Công";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số ngày làm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng lương:";
            // 
            // numNgay
            // 
            this.numNgay.Location = new System.Drawing.Point(199, 99);
            this.numNgay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numNgay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNgay.Name = "numNgay";
            this.numNgay.Size = new System.Drawing.Size(76, 22);
            this.numNgay.TabIndex = 1;
            this.numNgay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(200, 142);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(251, 22);
            this.txtSalary.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Sách Nhân Viên:";
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AutoGenerateColumns = false;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.soNgayLamDataGridViewTextBoxColumn,
            this.heSoLuongDataGridViewTextBoxColumn,
            this.btnEdit,
            this.btnDelete});
            this.dgvChamCong.DataSource = this.chamCongBindingSource;
            this.dgvChamCong.Location = new System.Drawing.Point(41, 241);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(993, 266);
            this.dgvChamCong.TabIndex = 1;
            this.dgvChamCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellContentClick);
            this.dgvChamCong.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvChamCong_DataBindingComplete);
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
            // qL_DiscStoreDataSet1
            // 
            this.qL_DiscStoreDataSet1.DataSetName = "QL_DiscStoreDataSet1";
            this.qL_DiscStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chamCongBindingSource
            // 
            this.chamCongBindingSource.DataMember = "ChamCong";
            this.chamCongBindingSource.DataSource = this.qL_DiscStoreDataSet1;
            // 
            // chamCongTableAdapter
            // 
            this.chamCongTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(888, 44);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã Nhân Viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên Nhân Viên";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // soNgayLamDataGridViewTextBoxColumn
            // 
            this.soNgayLamDataGridViewTextBoxColumn.DataPropertyName = "SoNgayLam";
            this.soNgayLamDataGridViewTextBoxColumn.HeaderText = "Sô Ngày Làm";
            this.soNgayLamDataGridViewTextBoxColumn.Name = "soNgayLamDataGridViewTextBoxColumn";
            // 
            // heSoLuongDataGridViewTextBoxColumn
            // 
            this.heSoLuongDataGridViewTextBoxColumn.DataPropertyName = "HeSoLuong";
            this.heSoLuongDataGridViewTextBoxColumn.HeaderText = "Số Lương / Ngày";
            this.heSoLuongDataGridViewTextBoxColumn.Name = "heSoLuongDataGridViewTextBoxColumn";
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Sửa";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Xóa";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Chấm Công:";
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(199, 54);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(252, 22);
            this.dtNgay.TabIndex = 5;
            this.dtNgay.ValueChanged += new System.EventHandler(this.dtNgay_ValueChanged);
            // 
            // listStaff
            // 
            this.listStaff.FormattingEnabled = true;
            this.listStaff.ItemHeight = 16;
            this.listStaff.Location = new System.Drawing.Point(519, 68);
            this.listStaff.Name = "listStaff";
            this.listStaff.Size = new System.Drawing.Size(228, 100);
            this.listStaff.TabIndex = 6;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 617);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.gbTTChamCong);
            this.Name = "frmChamCong";
            this.Text = "Bảng Chấm Công";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            this.gbTTChamCong.ResumeLayout(false);
            this.gbTTChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiscStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DiscStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTTChamCong;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.NumericUpDown numNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private QL_DiscStoreDataSet qL_DiscStoreDataSet;
        private System.Windows.Forms.BindingSource qLDiscStoreDataSetBindingSource;
        private QL_DiscStoreDataSet1 qL_DiscStoreDataSet1;
        private System.Windows.Forms.BindingSource chamCongBindingSource;
        private QL_DiscStoreDataSet1TableAdapters.ChamCongTableAdapter chamCongTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayLamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heSoLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listStaff;
    }
}