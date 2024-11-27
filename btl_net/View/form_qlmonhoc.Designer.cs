namespace btl_net.View
{
    partial class form_qlmonhoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoaiMonHoc = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGioiHanNghi = new System.Windows.Forms.TextBox();
            this.txtSoBuoiHoc = new System.Windows.Forms.TextBox();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Luoi_MonHoc = new System.Windows.Forms.DataGridView();
            this.chb_thungrac = new System.Windows.Forms.CheckBox();
            this.btn_khoiphuc = new System.Windows.Forms.Button();
            this.id_monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_xoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_phanloai_monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaimh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongsobh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_bh_chophep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_MonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_khoiphuc);
            this.groupBox1.Controls.Add(this.chb_thungrac);
            this.groupBox1.Controls.Add(this.cbLoaiMonHoc);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtGioiHanNghi);
            this.groupBox1.Controls.Add(this.txtSoBuoiHoc);
            this.groupBox1.Controls.Add(this.txtSoTC);
            this.groupBox1.Controls.Add(this.txtTenMonHoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1253, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            // 
            // cbLoaiMonHoc
            // 
            this.cbLoaiMonHoc.FormattingEnabled = true;
            this.cbLoaiMonHoc.Location = new System.Drawing.Point(162, 138);
            this.cbLoaiMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiMonHoc.Name = "cbLoaiMonHoc";
            this.cbLoaiMonHoc.Size = new System.Drawing.Size(359, 26);
            this.cbLoaiMonHoc.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Location = new System.Drawing.Point(952, 236);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 38);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Location = new System.Drawing.Point(795, 236);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 38);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(434, 236);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(266, 236);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(108, 236);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 38);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGioiHanNghi
            // 
            this.txtGioiHanNghi.Location = new System.Drawing.Point(810, 157);
            this.txtGioiHanNghi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGioiHanNghi.Multiline = true;
            this.txtGioiHanNghi.Name = "txtGioiHanNghi";
            this.txtGioiHanNghi.Size = new System.Drawing.Size(399, 29);
            this.txtGioiHanNghi.TabIndex = 1;
            // 
            // txtSoBuoiHoc
            // 
            this.txtSoBuoiHoc.Location = new System.Drawing.Point(810, 93);
            this.txtSoBuoiHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoBuoiHoc.Multiline = true;
            this.txtSoBuoiHoc.Name = "txtSoBuoiHoc";
            this.txtSoBuoiHoc.Size = new System.Drawing.Size(399, 29);
            this.txtSoBuoiHoc.TabIndex = 1;
            // 
            // txtSoTC
            // 
            this.txtSoTC.Location = new System.Drawing.Point(810, 30);
            this.txtSoTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTC.Multiline = true;
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(399, 29);
            this.txtSoTC.TabIndex = 1;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(162, 55);
            this.txtTenMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenMonHoc.Multiline = true;
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(359, 26);
            this.txtTenMonHoc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới hạn số buổi nghỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng số buổi học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại môn học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên môn học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số tín chỉ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Luoi_MonHoc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 362);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1253, 336);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn học";
            // 
            // Luoi_MonHoc
            // 
            this.Luoi_MonHoc.AllowUserToAddRows = false;
            this.Luoi_MonHoc.AllowUserToDeleteRows = false;
            this.Luoi_MonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_monhoc,
            this.is_xoa,
            this.tenmonhoc,
            this.id_phanloai_monhoc,
            this.loaimh,
            this.sotc,
            this.tongsobh,
            this.max_bh_chophep});
            this.Luoi_MonHoc.Location = new System.Drawing.Point(13, 22);
            this.Luoi_MonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Luoi_MonHoc.MultiSelect = false;
            this.Luoi_MonHoc.Name = "Luoi_MonHoc";
            this.Luoi_MonHoc.ReadOnly = true;
            this.Luoi_MonHoc.RowHeadersWidth = 62;
            this.Luoi_MonHoc.RowTemplate.Height = 28;
            this.Luoi_MonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_MonHoc.Size = new System.Drawing.Size(1239, 301);
            this.Luoi_MonHoc.TabIndex = 0;
            this.Luoi_MonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_MonHoc_CellClick);
            // 
            // chb_thungrac
            // 
            this.chb_thungrac.AutoSize = true;
            this.chb_thungrac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_thungrac.Location = new System.Drawing.Point(1148, 268);
            this.chb_thungrac.Name = "chb_thungrac";
            this.chb_thungrac.Size = new System.Drawing.Size(96, 22);
            this.chb_thungrac.TabIndex = 4;
            this.chb_thungrac.Text = "Thùng rác";
            this.chb_thungrac.UseVisualStyleBackColor = true;
            this.chb_thungrac.CheckedChanged += new System.EventHandler(this.chb_thungrac_CheckedChanged);
            // 
            // btn_khoiphuc
            // 
            this.btn_khoiphuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_khoiphuc.Enabled = false;
            this.btn_khoiphuc.Location = new System.Drawing.Point(611, 236);
            this.btn_khoiphuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_khoiphuc.Name = "btn_khoiphuc";
            this.btn_khoiphuc.Size = new System.Drawing.Size(112, 38);
            this.btn_khoiphuc.TabIndex = 5;
            this.btn_khoiphuc.Text = "Khôi phục";
            this.btn_khoiphuc.UseVisualStyleBackColor = true;
            this.btn_khoiphuc.Click += new System.EventHandler(this.btn_khoiphuc_Click);
            // 
            // id_monhoc
            // 
            this.id_monhoc.DataPropertyName = "id_monhoc";
            this.id_monhoc.HeaderText = "ID môn học";
            this.id_monhoc.MinimumWidth = 8;
            this.id_monhoc.Name = "id_monhoc";
            this.id_monhoc.ReadOnly = true;
            this.id_monhoc.Visible = false;
            // 
            // is_xoa
            // 
            this.is_xoa.DataPropertyName = "is_xoa";
            this.is_xoa.HeaderText = "is_xoa";
            this.is_xoa.MinimumWidth = 6;
            this.is_xoa.Name = "is_xoa";
            this.is_xoa.ReadOnly = true;
            this.is_xoa.Visible = false;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 8;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            // 
            // id_phanloai_monhoc
            // 
            this.id_phanloai_monhoc.DataPropertyName = "id_phanloai_monhoc";
            this.id_phanloai_monhoc.HeaderText = "ID phân loại";
            this.id_phanloai_monhoc.MinimumWidth = 8;
            this.id_phanloai_monhoc.Name = "id_phanloai_monhoc";
            this.id_phanloai_monhoc.ReadOnly = true;
            this.id_phanloai_monhoc.Visible = false;
            // 
            // loaimh
            // 
            this.loaimh.DataPropertyName = "loaimh";
            this.loaimh.HeaderText = "Loại môn học";
            this.loaimh.MinimumWidth = 8;
            this.loaimh.Name = "loaimh";
            this.loaimh.ReadOnly = true;
            // 
            // sotc
            // 
            this.sotc.DataPropertyName = "sotc";
            this.sotc.HeaderText = "Số tín chỉ";
            this.sotc.MinimumWidth = 8;
            this.sotc.Name = "sotc";
            this.sotc.ReadOnly = true;
            // 
            // tongsobh
            // 
            this.tongsobh.DataPropertyName = "tongsobh";
            this.tongsobh.HeaderText = "Tổng số  buổi học";
            this.tongsobh.MinimumWidth = 8;
            this.tongsobh.Name = "tongsobh";
            this.tongsobh.ReadOnly = true;
            // 
            // max_bh_chophep
            // 
            this.max_bh_chophep.DataPropertyName = "max_bh_chophep";
            this.max_bh_chophep.HeaderText = "Giới hạn số buổi nghỉ";
            this.max_bh_chophep.MinimumWidth = 8;
            this.max_bh_chophep.Name = "max_bh_chophep";
            this.max_bh_chophep.ReadOnly = true;
            // 
            // form_qlmonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1276, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_qlmonhoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_MonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGioiHanNghi;
        private System.Windows.Forms.TextBox txtSoBuoiHoc;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Luoi_MonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoaiMonHoc;
        private System.Windows.Forms.CheckBox chb_thungrac;
        private System.Windows.Forms.Button btn_khoiphuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_phanloai_monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaimh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongsobh;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_bh_chophep;
    }
}