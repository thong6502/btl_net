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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTyLe = new System.Windows.Forms.TextBox();
            this.txtTenDauDiem = new System.Windows.Forms.TextBox();
            this.txtIDDauDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Luoi_DauDiem = new System.Windows.Forms.DataGridView();
            this.cbIDMonHoc = new System.Windows.Forms.ComboBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DauDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẦU ĐIỂM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIDMonHoc);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTyLe);
            this.groupBox1.Controls.Add(this.txtTenDauDiem);
            this.groupBox1.Controls.Add(this.txtIDDauDiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1338, 470);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đầu điểm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1096, 388);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(204, 60);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(840, 388);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(204, 60);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(580, 388);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(204, 60);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(316, 388);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(204, 60);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 382);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(204, 60);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTyLe
            // 
            this.txtTyLe.Location = new System.Drawing.Point(780, 246);
            this.txtTyLe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTyLe.Multiline = true;
            this.txtTyLe.Name = "txtTyLe";
            this.txtTyLe.Size = new System.Drawing.Size(200, 46);
            this.txtTyLe.TabIndex = 1;
            // 
            // txtTenDauDiem
            // 
            this.txtTenDauDiem.Location = new System.Drawing.Point(780, 74);
            this.txtTenDauDiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTenDauDiem.Multiline = true;
            this.txtTenDauDiem.Name = "txtTenDauDiem";
            this.txtTenDauDiem.Size = new System.Drawing.Size(200, 46);
            this.txtTenDauDiem.TabIndex = 1;
            // 
            // txtIDDauDiem
            // 
            this.txtIDDauDiem.Enabled = false;
            this.txtIDDauDiem.Location = new System.Drawing.Point(202, 63);
            this.txtIDDauDiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIDDauDiem.Multiline = true;
            this.txtIDDauDiem.Name = "txtIDDauDiem";
            this.txtIDDauDiem.Size = new System.Drawing.Size(200, 46);
            this.txtIDDauDiem.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tỷ lệ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên đầu điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID đầu điểm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Luoi_DauDiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 585);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1338, 345);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đầu điểm";
            // 
            // Luoi_DauDiem
            // 
            this.Luoi_DauDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_DauDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_DauDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column5});
            this.Luoi_DauDiem.Location = new System.Drawing.Point(14, 40);
            this.Luoi_DauDiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Luoi_DauDiem.Name = "Luoi_DauDiem";
            this.Luoi_DauDiem.RowHeadersWidth = 82;
            this.Luoi_DauDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_DauDiem.Size = new System.Drawing.Size(1324, 305);
            this.Luoi_DauDiem.TabIndex = 0;
            // 
            // cbIDMonHoc
            // 
            this.cbIDMonHoc.FormattingEnabled = true;
            this.cbIDMonHoc.Location = new System.Drawing.Point(202, 235);
            this.cbIDMonHoc.Name = "cbIDMonHoc";
            this.cbIDMonHoc.Size = new System.Drawing.Size(200, 39);
            this.cbIDMonHoc.TabIndex = 3;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "id_daudiem";
            this.Column3.HeaderText = "ID đầu điểm";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_monhoc";
            this.Column1.HeaderText = "ID môn học";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tendaudiem";
            this.Column4.HeaderText = "Tên đầu điểm";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tyle";
            this.Column5.HeaderText = "Tỷ lệ";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1403, 942);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.TextBox txtIDDauDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTyLe;
        private System.Windows.Forms.TextBox txtTenDauDiem;
        private System.Windows.Forms.DataGridView Luoi_DauDiem;
        private System.Windows.Forms.ComboBox cbIDMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}