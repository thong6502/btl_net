namespace btl_net.View
{
    partial class Form3
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
            this.cbIDMonHoc = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTyLe = new System.Windows.Forms.TextBox();
            this.txtTenDauDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Luoi_DauDiem = new System.Windows.Forms.DataGridView();
            this.id_daudiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendaudiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DauDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẦU ĐIỂM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIDMonHoc);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTyLe);
            this.groupBox1.Controls.Add(this.txtTenDauDiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(758, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đầu điểm";
            // 
            // cbIDMonHoc
            // 
            this.cbIDMonHoc.FormattingEnabled = true;
            this.cbIDMonHoc.Location = new System.Drawing.Point(166, 47);
            this.cbIDMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbIDMonHoc.Name = "cbIDMonHoc";
            this.cbIDMonHoc.Size = new System.Drawing.Size(575, 27);
            this.cbIDMonHoc.TabIndex = 3;
            this.cbIDMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbIDMonHoc_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(634, 248);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 38);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(489, 248);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(97, 38);
            this.btn_capnhat.TabIndex = 2;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(332, 248);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(178, 248);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 248);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 38);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTyLe
            // 
            this.txtTyLe.Location = new System.Drawing.Point(166, 166);
            this.txtTyLe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTyLe.Multiline = true;
            this.txtTyLe.Name = "txtTyLe";
            this.txtTyLe.Size = new System.Drawing.Size(575, 31);
            this.txtTyLe.TabIndex = 1;
            // 
            // txtTenDauDiem
            // 
            this.txtTenDauDiem.Location = new System.Drawing.Point(166, 99);
            this.txtTenDauDiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDauDiem.Multiline = true;
            this.txtTenDauDiem.Name = "txtTenDauDiem";
            this.txtTenDauDiem.Size = new System.Drawing.Size(575, 31);
            this.txtTenDauDiem.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tỷ lệ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên đầu điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Môn học:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Luoi_DauDiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 374);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(758, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đầu điểm";
            // 
            // Luoi_DauDiem
            // 
            this.Luoi_DauDiem.AllowUserToAddRows = false;
            this.Luoi_DauDiem.AllowUserToDeleteRows = false;
            this.Luoi_DauDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_DauDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_DauDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_daudiem,
            this.id_monhoc,
            this.tendaudiem,
            this.tyle});
            this.Luoi_DauDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Luoi_DauDiem.Location = new System.Drawing.Point(4, 24);
            this.Luoi_DauDiem.Margin = new System.Windows.Forms.Padding(4);
            this.Luoi_DauDiem.Name = "Luoi_DauDiem";
            this.Luoi_DauDiem.ReadOnly = true;
            this.Luoi_DauDiem.RowHeadersWidth = 82;
            this.Luoi_DauDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_DauDiem.Size = new System.Drawing.Size(750, 193);
            this.Luoi_DauDiem.TabIndex = 0;
            this.Luoi_DauDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_DauDiem_CellClick);
            // 
            // id_daudiem
            // 
            this.id_daudiem.DataPropertyName = "id_daudiem";
            this.id_daudiem.HeaderText = "ID đầu điểm";
            this.id_daudiem.MinimumWidth = 10;
            this.id_daudiem.Name = "id_daudiem";
            this.id_daudiem.ReadOnly = true;
            this.id_daudiem.Visible = false;
            // 
            // id_monhoc
            // 
            this.id_monhoc.DataPropertyName = "id_monhoc";
            this.id_monhoc.HeaderText = "ID môn học";
            this.id_monhoc.MinimumWidth = 10;
            this.id_monhoc.Name = "id_monhoc";
            this.id_monhoc.ReadOnly = true;
            this.id_monhoc.Visible = false;
            // 
            // tendaudiem
            // 
            this.tendaudiem.DataPropertyName = "tendaudiem";
            this.tendaudiem.HeaderText = "Tên đầu điểm";
            this.tendaudiem.MinimumWidth = 10;
            this.tendaudiem.Name = "tendaudiem";
            this.tendaudiem.ReadOnly = true;
            // 
            // tyle
            // 
            this.tyle.DataPropertyName = "tyle";
            this.tyle.HeaderText = "Tỷ lệ";
            this.tyle.MinimumWidth = 10;
            this.tyle.Name = "tyle";
            this.tyle.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(811, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Quản lý đầu điểm";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DauDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTyLe;
        private System.Windows.Forms.TextBox txtTenDauDiem;
        private System.Windows.Forms.DataGridView Luoi_DauDiem;
        private System.Windows.Forms.ComboBox cbIDMonHoc;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_daudiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendaudiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyle;
    }
}