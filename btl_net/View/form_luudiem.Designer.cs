namespace btl_net.View
{
    partial class form_luudiem
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbTenDauDiem = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Luoi_DSD = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLopHoc = new System.Windows.Forms.TextBox();
            this.id_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_daudiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendaudiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP ĐIỂM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbTenDauDiem);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtLopHoc);
            this.groupBox1.Controls.Add(this.txtMSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1195, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập điểm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(731, 248);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 44);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(538, 248);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 44);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(345, 248);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 44);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbTenDauDiem
            // 
            this.cbTenDauDiem.FormattingEnabled = true;
            this.cbTenDauDiem.Location = new System.Drawing.Point(721, 70);
            this.cbTenDauDiem.Name = "cbTenDauDiem";
            this.cbTenDauDiem.Size = new System.Drawing.Size(285, 28);
            this.cbTenDauDiem.TabIndex = 2;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(721, 164);
            this.txtDiem.Multiline = true;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(285, 36);
            this.txtDiem.TabIndex = 1;
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(210, 166);
            this.txtMSV.Multiline = true;
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(275, 36);
            this.txtMSV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên đầu điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Luoi_DSD);
            this.groupBox2.Location = new System.Drawing.Point(13, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1195, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đầu điểm ";
            // 
            // Luoi_DSD
            // 
            this.Luoi_DSD.AllowUserToAddRows = false;
            this.Luoi_DSD.AllowUserToDeleteRows = false;
            this.Luoi_DSD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_DSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_DSD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sv,
            this.id_daudiem,
            this.tendaudiem,
            this.diem,
            this.id_diem});
            this.Luoi_DSD.Location = new System.Drawing.Point(15, 25);
            this.Luoi_DSD.Name = "Luoi_DSD";
            this.Luoi_DSD.ReadOnly = true;
            this.Luoi_DSD.RowHeadersWidth = 62;
            this.Luoi_DSD.RowTemplate.Height = 28;
            this.Luoi_DSD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_DSD.Size = new System.Drawing.Size(1174, 270);
            this.Luoi_DSD.TabIndex = 0;
            this.Luoi_DSD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_DSD_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên lớp học:";
            // 
            // txtLopHoc
            // 
            this.txtLopHoc.Location = new System.Drawing.Point(210, 75);
            this.txtLopHoc.Multiline = true;
            this.txtLopHoc.Name = "txtLopHoc";
            this.txtLopHoc.Size = new System.Drawing.Size(275, 36);
            this.txtLopHoc.TabIndex = 1;
            // 
            // id_sv
            // 
            this.id_sv.DataPropertyName = "id_sv";
            this.id_sv.HeaderText = "ID sinh viên";
            this.id_sv.MinimumWidth = 8;
            this.id_sv.Name = "id_sv";
            this.id_sv.ReadOnly = true;
            this.id_sv.Visible = false;
            // 
            // id_daudiem
            // 
            this.id_daudiem.DataPropertyName = "id_daudiem";
            this.id_daudiem.HeaderText = "ID đầu điểm";
            this.id_daudiem.MinimumWidth = 8;
            this.id_daudiem.Name = "id_daudiem";
            this.id_daudiem.ReadOnly = true;
            this.id_daudiem.Visible = false;
            // 
            // tendaudiem
            // 
            this.tendaudiem.DataPropertyName = "tendaudiem";
            this.tendaudiem.HeaderText = "Tên đầu điểm";
            this.tendaudiem.MinimumWidth = 8;
            this.tendaudiem.Name = "tendaudiem";
            this.tendaudiem.ReadOnly = true;
            // 
            // diem
            // 
            this.diem.DataPropertyName = "diem";
            this.diem.HeaderText = "Điểm";
            this.diem.MinimumWidth = 8;
            this.diem.Name = "diem";
            this.diem.ReadOnly = true;
            // 
            // id_diem
            // 
            this.id_diem.DataPropertyName = "id_diem";
            this.id_diem.HeaderText = "ID Điểm";
            this.id_diem.MinimumWidth = 8;
            this.id_diem.Name = "id_diem";
            this.id_diem.ReadOnly = true;
            this.id_diem.Visible = false;
            // 
            // form_luudiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 743);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "form_luudiem";
            this.Text = "form_luudiem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbTenDauDiem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.DataGridView Luoi_DSD;
        private System.Windows.Forms.TextBox txtLopHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_daudiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendaudiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_diem;
    }
}