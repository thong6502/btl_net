namespace btl_net.View
{
    partial class form_thongkeSVNH
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
            this.lblTongSoSV = new System.Windows.Forms.GroupBox();
            this.LUOI_SVCN = new System.Windows.Forms.DataGridView();
            this.txtTenChuyenNganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_chuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.lblTongSoSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUOI_SVCN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ SINH VIÊN CỦA NGÀNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenChuyenNganh);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ngành";
            // 
            // lblTongSoSV
            // 
            this.lblTongSoSV.Controls.Add(this.LUOI_SVCN);
            this.lblTongSoSV.Location = new System.Drawing.Point(13, 251);
            this.lblTongSoSV.Name = "lblTongSoSV";
            this.lblTongSoSV.Size = new System.Drawing.Size(903, 267);
            this.lblTongSoSV.TabIndex = 2;
            this.lblTongSoSV.TabStop = false;
            this.lblTongSoSV.Text = "Tổng số sinh viên: 0";
            // 
            // LUOI_SVCN
            // 
            this.LUOI_SVCN.AllowUserToAddRows = false;
            this.LUOI_SVCN.AllowUserToDeleteRows = false;
            this.LUOI_SVCN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LUOI_SVCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LUOI_SVCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_chuyennganh,
            this.id_sv,
            this.msv,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.sdt,
            this.email,
            this.cccd,
            this.diachi,
            this.khoahoc});
            this.LUOI_SVCN.Location = new System.Drawing.Point(7, 20);
            this.LUOI_SVCN.Name = "LUOI_SVCN";
            this.LUOI_SVCN.ReadOnly = true;
            this.LUOI_SVCN.Size = new System.Drawing.Size(890, 241);
            this.LUOI_SVCN.TabIndex = 0;
            // 
            // txtTenChuyenNganh
            // 
            this.txtTenChuyenNganh.Enabled = false;
            this.txtTenChuyenNganh.Location = new System.Drawing.Point(390, 63);
            this.txtTenChuyenNganh.Multiline = true;
            this.txtTenChuyenNganh.Name = "txtTenChuyenNganh";
            this.txtTenChuyenNganh.Size = new System.Drawing.Size(244, 28);
            this.txtTenChuyenNganh.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chuyên ngành:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // id_chuyennganh
            // 
            this.id_chuyennganh.DataPropertyName = "id_chuyennganh";
            this.id_chuyennganh.HeaderText = "ID chuyên ngành";
            this.id_chuyennganh.Name = "id_chuyennganh";
            this.id_chuyennganh.ReadOnly = true;
            this.id_chuyennganh.Visible = false;
            // 
            // id_sv
            // 
            this.id_sv.DataPropertyName = "id_sv";
            this.id_sv.HeaderText = "ID sinh viên";
            this.id_sv.Name = "id_sv";
            this.id_sv.ReadOnly = true;
            this.id_sv.Visible = false;
            // 
            // msv
            // 
            this.msv.DataPropertyName = "msv";
            this.msv.HeaderText = "Mã sinh viên";
            this.msv.Name = "msv";
            this.msv.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // cccd
            // 
            this.cccd.DataPropertyName = "cccd";
            this.cccd.HeaderText = "CCCD";
            this.cccd.Name = "cccd";
            this.cccd.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // khoahoc
            // 
            this.khoahoc.DataPropertyName = "khoahoc";
            this.khoahoc.HeaderText = "Khóa học";
            this.khoahoc.Name = "khoahoc";
            this.khoahoc.ReadOnly = true;
            // 
            // form_thongkeSVNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 530);
            this.Controls.Add(this.lblTongSoSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "form_thongkeSVNH";
            this.Text = "form_thongkeSVNH";
            this.Load += new System.EventHandler(this.form_thongkeSVNH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lblTongSoSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LUOI_SVCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox lblTongSoSV;
        private System.Windows.Forms.DataGridView LUOI_SVCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_chuyennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoahoc;
    }
}