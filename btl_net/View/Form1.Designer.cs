namespace btl_net
{
    partial class Form1
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
            this.btn_khoiphuc = new System.Windows.Forms.Button();
            this.cb_nganh = new System.Windows.Forms.ComboBox();
            this.tbtn_conhoc = new System.Windows.Forms.RadioButton();
            this.tbtn_bohoc = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Luoi_SV = new System.Windows.Forms.DataGridView();
            this.id_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_chuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_conhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_SV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_khoiphuc);
            this.groupBox1.Controls.Add(this.cb_nganh);
            this.groupBox1.Controls.Add(this.tbtn_conhoc);
            this.groupBox1.Controls.Add(this.tbtn_bohoc);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dateNgaySinh);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtKhoaHoc);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1333, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btn_khoiphuc
            // 
            this.btn_khoiphuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_khoiphuc.Location = new System.Drawing.Point(756, 290);
            this.btn_khoiphuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_khoiphuc.Name = "btn_khoiphuc";
            this.btn_khoiphuc.Size = new System.Drawing.Size(127, 44);
            this.btn_khoiphuc.TabIndex = 8;
            this.btn_khoiphuc.Text = "Khôi phục";
            this.btn_khoiphuc.UseVisualStyleBackColor = true;
            this.btn_khoiphuc.Click += new System.EventHandler(this.btn_khoiphuc_Click);
            // 
            // cb_nganh
            // 
            this.cb_nganh.FormattingEnabled = true;
            this.cb_nganh.ItemHeight = 18;
            this.cb_nganh.Location = new System.Drawing.Point(228, 73);
            this.cb_nganh.Name = "cb_nganh";
            this.cb_nganh.Size = new System.Drawing.Size(352, 26);
            this.cb_nganh.TabIndex = 7;
            // 
            // tbtn_conhoc
            // 
            this.tbtn_conhoc.AutoSize = true;
            this.tbtn_conhoc.Checked = true;
            this.tbtn_conhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtn_conhoc.Location = new System.Drawing.Point(1148, 330);
            this.tbtn_conhoc.Name = "tbtn_conhoc";
            this.tbtn_conhoc.Size = new System.Drawing.Size(86, 22);
            this.tbtn_conhoc.TabIndex = 6;
            this.tbtn_conhoc.TabStop = true;
            this.tbtn_conhoc.Text = "Còn học";
            this.tbtn_conhoc.UseVisualStyleBackColor = true;
            this.tbtn_conhoc.CheckedChanged += new System.EventHandler(this.tbtn_conhoc_CheckedChanged);
            // 
            // tbtn_bohoc
            // 
            this.tbtn_bohoc.AutoSize = true;
            this.tbtn_bohoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtn_bohoc.Location = new System.Drawing.Point(1250, 330);
            this.tbtn_bohoc.Name = "tbtn_bohoc";
            this.tbtn_bohoc.Size = new System.Drawing.Size(77, 22);
            this.tbtn_bohoc.TabIndex = 5;
            this.tbtn_bohoc.Text = "Bỏ học";
            this.tbtn_bohoc.UseVisualStyleBackColor = true;
            this.tbtn_bohoc.CheckedChanged += new System.EventHandler(this.tbtn_bohoc_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnThoat.Location = new System.Drawing.Point(934, 290);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 44);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnXoa.Location = new System.Drawing.Point(580, 290);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 44);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSua.Location = new System.Drawing.Point(395, 290);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(127, 44);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnThem.Location = new System.Drawing.Point(208, 290);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 44);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(885, 111);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(365, 24);
            this.dateNgaySinh.TabIndex = 3;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(885, 30);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(365, 26);
            this.cbGioiTinh.TabIndex = 2;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(885, 68);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCD.Multiline = true;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(365, 28);
            this.txtCCCD.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(885, 151);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(365, 28);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Location = new System.Drawing.Point(885, 194);
            this.txtKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhoaHoc.Multiline = true;
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(365, 28);
            this.txtKhoaHoc.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(228, 202);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(352, 28);
            this.txtSDT.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(228, 156);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 28);
            this.txtEmail.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(228, 113);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(352, 28);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(228, 30);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSV.Multiline = true;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(352, 28);
            this.txtMaSV.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã sinh viên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên ngành";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Họ tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(767, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(767, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khóa học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "SĐT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(767, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "CCCD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(767, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(767, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Luoi_SV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 425);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1335, 272);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // Luoi_SV
            // 
            this.Luoi_SV.AllowUserToAddRows = false;
            this.Luoi_SV.AllowUserToDeleteRows = false;
            this.Luoi_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_SV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sv,
            this.id_chuyennganh,
            this.is_conhoc,
            this.hoten,
            this.msv,
            this.ngaysinh,
            this.gioitinh,
            this.cccd,
            this.email,
            this.sdt,
            this.tenchuyennganh,
            this.diachi,
            this.khoahoc});
            this.Luoi_SV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Luoi_SV.Location = new System.Drawing.Point(3, 19);
            this.Luoi_SV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Luoi_SV.Name = "Luoi_SV";
            this.Luoi_SV.ReadOnly = true;
            this.Luoi_SV.RowHeadersWidth = 51;
            this.Luoi_SV.RowTemplate.Height = 28;
            this.Luoi_SV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_SV.Size = new System.Drawing.Size(1329, 251);
            this.Luoi_SV.TabIndex = 0;
            this.Luoi_SV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_SV_CellClick);
            // 
            // id_sv
            // 
            this.id_sv.DataPropertyName = "id_sv";
            this.id_sv.HeaderText = "ID sinh viên";
            this.id_sv.MinimumWidth = 6;
            this.id_sv.Name = "id_sv";
            this.id_sv.ReadOnly = true;
            this.id_sv.Visible = false;
            this.id_sv.Width = 76;
            // 
            // id_chuyennganh
            // 
            this.id_chuyennganh.DataPropertyName = "id_chuyennganh";
            this.id_chuyennganh.HeaderText = "id_chuyennganh";
            this.id_chuyennganh.MinimumWidth = 6;
            this.id_chuyennganh.Name = "id_chuyennganh";
            this.id_chuyennganh.ReadOnly = true;
            this.id_chuyennganh.Visible = false;
            this.id_chuyennganh.Width = 125;
            // 
            // is_conhoc
            // 
            this.is_conhoc.DataPropertyName = "is_conhoc";
            this.is_conhoc.HeaderText = "Đang học";
            this.is_conhoc.MinimumWidth = 6;
            this.is_conhoc.Name = "is_conhoc";
            this.is_conhoc.ReadOnly = true;
            this.is_conhoc.Visible = false;
            this.is_conhoc.Width = 76;
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
            // msv
            // 
            this.msv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msv.DataPropertyName = "msv";
            this.msv.HeaderText = "Mã sinh viên";
            this.msv.MinimumWidth = 6;
            this.msv.Name = "msv";
            this.msv.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // cccd
            // 
            this.cccd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cccd.DataPropertyName = "cccd";
            this.cccd.HeaderText = "CCCD";
            this.cccd.MinimumWidth = 6;
            this.cccd.Name = "cccd";
            this.cccd.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // tenchuyennganh
            // 
            this.tenchuyennganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenchuyennganh.DataPropertyName = "tenchuyennganh";
            this.tenchuyennganh.HeaderText = "Tên ngành";
            this.tenchuyennganh.MinimumWidth = 6;
            this.tenchuyennganh.Name = "tenchuyennganh";
            this.tenchuyennganh.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // khoahoc
            // 
            this.khoahoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.khoahoc.DataPropertyName = "khoahoc";
            this.khoahoc.HeaderText = "Khóa học";
            this.khoahoc.MinimumWidth = 6;
            this.khoahoc.Name = "khoahoc";
            this.khoahoc.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 708);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_SV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Luoi_SV;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtKhoaHoc;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.RadioButton tbtn_conhoc;
        private System.Windows.Forms.RadioButton tbtn_bohoc;
        private System.Windows.Forms.ComboBox cb_nganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_chuyennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_conhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchuyennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoahoc;
        private System.Windows.Forms.Button btn_khoiphuc;
    }
}

