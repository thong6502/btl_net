namespace btl_net.View
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tbtn_chuyennganhdaxoa = new System.Windows.Forms.RadioButton();
            this.tbtn_chuyenganhhienco = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenChuyenNganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Luoi_CN = new System.Windows.Forms.DataGridView();
            this.id_chuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongsinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_CN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý chuyên ngành";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnKhoiPhuc);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.tbtn_chuyennganhdaxoa);
            this.groupBox1.Controls.Add(this.tbtn_chuyenganhhienco);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTenChuyenNganh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuyên ngành";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thống kê sinh viên của ngành";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Location = new System.Drawing.Point(515, 139);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(74, 29);
            this.btnKhoiPhuc.TabIndex = 5;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(406, 139);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(74, 29);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tbtn_chuyennganhdaxoa
            // 
            this.tbtn_chuyennganhdaxoa.AutoSize = true;
            this.tbtn_chuyennganhdaxoa.Location = new System.Drawing.Point(353, 105);
            this.tbtn_chuyennganhdaxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbtn_chuyennganhdaxoa.Name = "tbtn_chuyennganhdaxoa";
            this.tbtn_chuyennganhdaxoa.Size = new System.Drawing.Size(127, 19);
            this.tbtn_chuyennganhdaxoa.TabIndex = 4;
            this.tbtn_chuyennganhdaxoa.TabStop = true;
            this.tbtn_chuyennganhdaxoa.Text = "Chuyên ngành đã xóa";
            this.tbtn_chuyennganhdaxoa.UseVisualStyleBackColor = true;
            this.tbtn_chuyennganhdaxoa.CheckedChanged += new System.EventHandler(this.tbtn_chuyennganhdaxoa_CheckedChanged);
            // 
            // tbtn_chuyenganhhienco
            // 
            this.tbtn_chuyenganhhienco.AutoSize = true;
            this.tbtn_chuyenganhhienco.Checked = true;
            this.tbtn_chuyenganhhienco.Location = new System.Drawing.Point(201, 106);
            this.tbtn_chuyenganhhienco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbtn_chuyenganhhienco.Name = "tbtn_chuyenganhhienco";
            this.tbtn_chuyenganhhienco.Size = new System.Drawing.Size(131, 19);
            this.tbtn_chuyenganhhienco.TabIndex = 3;
            this.tbtn_chuyenganhhienco.TabStop = true;
            this.tbtn_chuyenganhhienco.Text = "Chuyên ngành hiện có";
            this.tbtn_chuyenganhhienco.UseVisualStyleBackColor = true;
            this.tbtn_chuyenganhhienco.CheckedChanged += new System.EventHandler(this.tbtn_chuyenganhhienco_CheckedChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(299, 139);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(195, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 29);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(87, 140);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 29);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenChuyenNganh
            // 
            this.txtTenChuyenNganh.Location = new System.Drawing.Point(204, 56);
            this.txtTenChuyenNganh.Multiline = true;
            this.txtTenChuyenNganh.Name = "txtTenChuyenNganh";
            this.txtTenChuyenNganh.Size = new System.Drawing.Size(262, 26);
            this.txtTenChuyenNganh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên chuyên ngành";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Luoi_CN);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chuyên ngành";
            // 
            // Luoi_CN
            // 
            this.Luoi_CN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_CN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_CN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_chuyennganh,
            this.tenchuyennganh,
            this.soluongsinhvien});
            this.Luoi_CN.Location = new System.Drawing.Point(10, 20);
            this.Luoi_CN.Name = "Luoi_CN";
            this.Luoi_CN.RowHeadersWidth = 62;
            this.Luoi_CN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_CN.Size = new System.Drawing.Size(671, 215);
            this.Luoi_CN.TabIndex = 0;
            this.Luoi_CN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_CN_CellClick);
            // 
            // id_chuyennganh
            // 
            this.id_chuyennganh.DataPropertyName = "id_chuyennganh";
            this.id_chuyennganh.HeaderText = "ID";
            this.id_chuyennganh.MinimumWidth = 8;
            this.id_chuyennganh.Name = "id_chuyennganh";
            this.id_chuyennganh.Visible = false;
            // 
            // tenchuyennganh
            // 
            this.tenchuyennganh.DataPropertyName = "tenchuyennganh";
            this.tenchuyennganh.HeaderText = "Tên chuyên ngành";
            this.tenchuyennganh.MinimumWidth = 8;
            this.tenchuyennganh.Name = "tenchuyennganh";
            // 
            // soluongsinhvien
            // 
            this.soluongsinhvien.DataPropertyName = "soluongsinhvien";
            this.soluongsinhvien.HeaderText = "Số lượng sinh viên";
            this.soluongsinhvien.MinimumWidth = 8;
            this.soluongsinhvien.Name = "soluongsinhvien";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_CN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenChuyenNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Luoi_CN;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_chuyennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchuyennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongsinhvien;
        private System.Windows.Forms.RadioButton tbtn_chuyenganhhienco;
        private System.Windows.Forms.RadioButton tbtn_chuyennganhdaxoa;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
    }
}