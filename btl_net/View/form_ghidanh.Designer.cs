namespace btl_net.View
{
    partial class form_ghidanh
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
            this.lblTongSoSinhVien = new System.Windows.Forms.GroupBox();
            this.Luoi_DSGD = new System.Windows.Forms.DataGridView();
            this.id_ghidanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobuoinghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeplichthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbtn_GhiDanhDaXoa = new System.Windows.Forms.RadioButton();
            this.tbtn_GhiDanhHienCo = new System.Windows.Forms.RadioButton();
            this.cbTenLopHoc = new System.Windows.Forms.ComboBox();
            this.txtXepLichThi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoBuoiNghi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTenSV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongSoSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSGD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTongSoSinhVien
            // 
            this.lblTongSoSinhVien.Controls.Add(this.Luoi_DSGD);
            this.lblTongSoSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoSinhVien.Location = new System.Drawing.Point(26, 486);
            this.lblTongSoSinhVien.Name = "lblTongSoSinhVien";
            this.lblTongSoSinhVien.Size = new System.Drawing.Size(1312, 382);
            this.lblTongSoSinhVien.TabIndex = 5;
            this.lblTongSoSinhVien.TabStop = false;
            this.lblTongSoSinhVien.Text = "Danh sách ghi danh";
            // 
            // Luoi_DSGD
            // 
            this.Luoi_DSGD.AllowUserToAddRows = false;
            this.Luoi_DSGD.AllowUserToDeleteRows = false;
            this.Luoi_DSGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_DSGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ghidanh,
            this.id_sv,
            this.id_lophoc,
            this.msv,
            this.hoten,
            this.tenlop,
            this.kyhoc,
            this.tenmonhoc,
            this.sobuoinghi,
            this.xeplichthi});
            this.Luoi_DSGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Luoi_DSGD.Location = new System.Drawing.Point(3, 24);
            this.Luoi_DSGD.Name = "Luoi_DSGD";
            this.Luoi_DSGD.ReadOnly = true;
            this.Luoi_DSGD.RowHeadersWidth = 51;
            this.Luoi_DSGD.RowTemplate.Height = 28;
            this.Luoi_DSGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_DSGD.Size = new System.Drawing.Size(1306, 355);
            this.Luoi_DSGD.TabIndex = 0;
            this.Luoi_DSGD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_DSGD_CellClick);
            this.Luoi_DSGD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_SV_CellContentClick);
            // 
            // id_ghidanh
            // 
            this.id_ghidanh.DataPropertyName = "id_ghidanh";
            this.id_ghidanh.HeaderText = "ID ghi danh";
            this.id_ghidanh.MinimumWidth = 6;
            this.id_ghidanh.Name = "id_ghidanh";
            this.id_ghidanh.ReadOnly = true;
            this.id_ghidanh.Visible = false;
            this.id_ghidanh.Width = 76;
            // 
            // id_sv
            // 
            this.id_sv.DataPropertyName = "id_sv";
            this.id_sv.HeaderText = "ID sinh viên";
            this.id_sv.MinimumWidth = 8;
            this.id_sv.Name = "id_sv";
            this.id_sv.ReadOnly = true;
            this.id_sv.Visible = false;
            this.id_sv.Width = 150;
            // 
            // id_lophoc
            // 
            this.id_lophoc.DataPropertyName = "id_lophoc";
            this.id_lophoc.HeaderText = "ID lớp học";
            this.id_lophoc.MinimumWidth = 8;
            this.id_lophoc.Name = "id_lophoc";
            this.id_lophoc.ReadOnly = true;
            this.id_lophoc.Visible = false;
            this.id_lophoc.Width = 150;
            // 
            // msv
            // 
            this.msv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msv.DataPropertyName = "msv";
            this.msv.HeaderText = "Mã sinh viên";
            this.msv.MinimumWidth = 6;
            this.msv.Name = "msv";
            this.msv.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // tenlop
            // 
            this.tenlop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên lớp học";
            this.tenlop.MinimumWidth = 6;
            this.tenlop.Name = "tenlop";
            this.tenlop.ReadOnly = true;
            // 
            // kyhoc
            // 
            this.kyhoc.DataPropertyName = "kyhoc";
            this.kyhoc.HeaderText = "Kỳ học";
            this.kyhoc.MinimumWidth = 8;
            this.kyhoc.Name = "kyhoc";
            this.kyhoc.ReadOnly = true;
            this.kyhoc.Width = 150;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 8;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            this.tenmonhoc.Width = 150;
            // 
            // sobuoinghi
            // 
            this.sobuoinghi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sobuoinghi.DataPropertyName = "sobuoinghi";
            this.sobuoinghi.HeaderText = "Số buổi nghỉ";
            this.sobuoinghi.MinimumWidth = 6;
            this.sobuoinghi.Name = "sobuoinghi";
            this.sobuoinghi.ReadOnly = true;
            // 
            // xeplichthi
            // 
            this.xeplichthi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xeplichthi.DataPropertyName = "xeplichthi";
            this.xeplichthi.HeaderText = "Lịch thi";
            this.xeplichthi.MinimumWidth = 6;
            this.xeplichthi.Name = "xeplichthi";
            this.xeplichthi.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tbtn_GhiDanhDaXoa);
            this.groupBox1.Controls.Add(this.tbtn_GhiDanhHienCo);
            this.groupBox1.Controls.Add(this.cbTenLopHoc);
            this.groupBox1.Controls.Add(this.txtXepLichThi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoBuoiNghi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTenSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnKhoiPhuc);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1312, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ghi danh";
            // 
            // tbtn_GhiDanhDaXoa
            // 
            this.tbtn_GhiDanhDaXoa.AutoSize = true;
            this.tbtn_GhiDanhDaXoa.Location = new System.Drawing.Point(1086, 368);
            this.tbtn_GhiDanhDaXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbtn_GhiDanhDaXoa.Name = "tbtn_GhiDanhDaXoa";
            this.tbtn_GhiDanhDaXoa.Size = new System.Drawing.Size(167, 26);
            this.tbtn_GhiDanhDaXoa.TabIndex = 6;
            this.tbtn_GhiDanhDaXoa.Text = "Ghi danh đã xóa";
            this.tbtn_GhiDanhDaXoa.UseVisualStyleBackColor = true;
            this.tbtn_GhiDanhDaXoa.CheckedChanged += new System.EventHandler(this.tbtn_GhiDanhDaXoa_CheckedChanged);
            // 
            // tbtn_GhiDanhHienCo
            // 
            this.tbtn_GhiDanhHienCo.AutoSize = true;
            this.tbtn_GhiDanhHienCo.Checked = true;
            this.tbtn_GhiDanhHienCo.Location = new System.Drawing.Point(842, 368);
            this.tbtn_GhiDanhHienCo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbtn_GhiDanhHienCo.Name = "tbtn_GhiDanhHienCo";
            this.tbtn_GhiDanhHienCo.Size = new System.Drawing.Size(171, 26);
            this.tbtn_GhiDanhHienCo.TabIndex = 6;
            this.tbtn_GhiDanhHienCo.TabStop = true;
            this.tbtn_GhiDanhHienCo.Text = "Ghi danh hiện có";
            this.tbtn_GhiDanhHienCo.UseVisualStyleBackColor = true;
            this.tbtn_GhiDanhHienCo.CheckedChanged += new System.EventHandler(this.tbtn_GhiDanhHienCo_CheckedChanged);
            // 
            // cbTenLopHoc
            // 
            this.cbTenLopHoc.FormattingEnabled = true;
            this.cbTenLopHoc.ItemHeight = 22;
            this.cbTenLopHoc.Location = new System.Drawing.Point(256, 60);
            this.cbTenLopHoc.Name = "cbTenLopHoc";
            this.cbTenLopHoc.Size = new System.Drawing.Size(396, 30);
            this.cbTenLopHoc.TabIndex = 19;
            this.cbTenLopHoc.SelectedIndexChanged += new System.EventHandler(this.cbTenLopHoc_SelectedIndexChanged);
            this.cbTenLopHoc.TextChanged += new System.EventHandler(this.cbTenLopHoc_TextChanged);
            this.cbTenLopHoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbTenLopHoc_KeyUp);
            // 
            // txtXepLichThi
            // 
            this.txtXepLichThi.Location = new System.Drawing.Point(861, 160);
            this.txtXepLichThi.Multiline = true;
            this.txtXepLichThi.Name = "txtXepLichThi";
            this.txtXepLichThi.Size = new System.Drawing.Size(396, 35);
            this.txtXepLichThi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Xếp lịch thi:";
            // 
            // txtSoBuoiNghi
            // 
            this.txtSoBuoiNghi.Location = new System.Drawing.Point(861, 55);
            this.txtSoBuoiNghi.Multiline = true;
            this.txtSoBuoiNghi.Name = "txtSoBuoiNghi";
            this.txtSoBuoiNghi.Size = new System.Drawing.Size(396, 35);
            this.txtSoBuoiNghi.TabIndex = 14;
            this.txtSoBuoiNghi.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số buổi nghỉ:";
            // 
            // cbTenSV
            // 
            this.cbTenSV.FormattingEnabled = true;
            this.cbTenSV.ItemHeight = 22;
            this.cbTenSV.Location = new System.Drawing.Point(256, 157);
            this.cbTenSV.Name = "cbTenSV";
            this.cbTenSV.Size = new System.Drawing.Size(396, 30);
            this.cbTenSV.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên sinh viên:";
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnKhoiPhuc.Location = new System.Drawing.Point(1072, 272);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(142, 55);
            this.btnKhoiPhuc.TabIndex = 4;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnThoat.Location = new System.Drawing.Point(824, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 55);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnXoa.Location = new System.Drawing.Point(597, 272);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 55);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSua.Location = new System.Drawing.Point(358, 272);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 55);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnThem.Location = new System.Drawing.Point(142, 272);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 55);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(135, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên lớp học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ GHI DANH";
            // 
            // form_ghidanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 885);
            this.Controls.Add(this.lblTongSoSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "form_ghidanh";
            this.Text = "form_lophoc";
            this.Load += new System.EventHandler(this.form_ghidanh_Load);
            this.lblTongSoSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSGD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox lblTongSoSinhVien;
        private System.Windows.Forms.DataGridView Luoi_DSGD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXepLichThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoBuoiNghi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTenLopHoc;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.RadioButton tbtn_GhiDanhDaXoa;
        private System.Windows.Forms.RadioButton tbtn_GhiDanhHienCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ghidanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobuoinghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeplichthi;
    }
}