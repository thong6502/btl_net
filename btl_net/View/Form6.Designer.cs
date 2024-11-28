namespace btl_net.View
{
    partial class Form6
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTenLopHoc = new System.Windows.Forms.ComboBox();
            this.cbMSV = new System.Windows.Forms.ComboBox();
            this.cbTenDauDiem = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.Luoi_DSD = new System.Windows.Forms.DataGridView();
            this.id_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_daudiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendaudiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẦU ĐIỂM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.cbTenDauDiem);
            this.groupBox1.Controls.Add(this.cbMSV);
            this.groupBox1.Controls.Add(this.cbTenLopHoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Luoi_DSD);
            this.groupBox2.Location = new System.Drawing.Point(13, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1326, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách điểm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên lớp học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã SV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên đầu điểm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm:";
            // 
            // cbTenLopHoc
            // 
            this.cbTenLopHoc.FormattingEnabled = true;
            this.cbTenLopHoc.Location = new System.Drawing.Point(158, 58);
            this.cbTenLopHoc.Name = "cbTenLopHoc";
            this.cbTenLopHoc.Size = new System.Drawing.Size(323, 28);
            this.cbTenLopHoc.TabIndex = 1;
            this.cbTenLopHoc.SelectedIndexChanged += new System.EventHandler(this.cbTenLopHoc_SelectedIndexChanged);
            // 
            // cbMSV
            // 
            this.cbMSV.FormattingEnabled = true;
            this.cbMSV.Location = new System.Drawing.Point(158, 140);
            this.cbMSV.Name = "cbMSV";
            this.cbMSV.Size = new System.Drawing.Size(323, 28);
            this.cbMSV.TabIndex = 1;
            // 
            // cbTenDauDiem
            // 
            this.cbTenDauDiem.FormattingEnabled = true;
            this.cbTenDauDiem.Location = new System.Drawing.Point(825, 55);
            this.cbTenDauDiem.Name = "cbTenDauDiem";
            this.cbTenDauDiem.Size = new System.Drawing.Size(323, 28);
            this.cbTenDauDiem.TabIndex = 1;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(825, 133);
            this.txtDiem.Multiline = true;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(323, 35);
            this.txtDiem.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(342, 263);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 41);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(583, 263);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 41);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(804, 263);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 41);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Luoi_DSD
            // 
            this.Luoi_DSD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_DSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_DSD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sv,
            this.msv,
            this.hoten,
            this.id_daudiem,
            this.tenmonhoc,
            this.tendaudiem,
            this.id_diem,
            this.diem});
            this.Luoi_DSD.Location = new System.Drawing.Point(7, 26);
            this.Luoi_DSD.Name = "Luoi_DSD";
            this.Luoi_DSD.RowHeadersWidth = 62;
            this.Luoi_DSD.RowTemplate.Height = 28;
            this.Luoi_DSD.Size = new System.Drawing.Size(1313, 248);
            this.Luoi_DSD.TabIndex = 0;
            // 
            // id_sv
            // 
            this.id_sv.DataPropertyName = "id_sv";
            this.id_sv.HeaderText = "ID sinh viên";
            this.id_sv.MinimumWidth = 8;
            this.id_sv.Name = "id_sv";
            this.id_sv.Visible = false;
            // 
            // msv
            // 
            this.msv.DataPropertyName = "msv";
            this.msv.HeaderText = "MSV";
            this.msv.MinimumWidth = 8;
            this.msv.Name = "msv";
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            // 
            // id_daudiem
            // 
            this.id_daudiem.DataPropertyName = "id_daudiem";
            this.id_daudiem.HeaderText = "ID đầu điểm";
            this.id_daudiem.MinimumWidth = 8;
            this.id_daudiem.Name = "id_daudiem";
            this.id_daudiem.Visible = false;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 8;
            this.tenmonhoc.Name = "tenmonhoc";
            // 
            // tendaudiem
            // 
            this.tendaudiem.DataPropertyName = "tendaudiem";
            this.tendaudiem.HeaderText = "Tên đầu điểm";
            this.tendaudiem.MinimumWidth = 8;
            this.tendaudiem.Name = "tendaudiem";
            // 
            // id_diem
            // 
            this.id_diem.DataPropertyName = "id_diem";
            this.id_diem.HeaderText = "ID Điểm";
            this.id_diem.MinimumWidth = 8;
            this.id_diem.Name = "id_diem";
            this.id_diem.Visible = false;
            // 
            // diem
            // 
            this.diem.DataPropertyName = "diem";
            this.diem.HeaderText = "Điểm";
            this.diem.MinimumWidth = 8;
            this.diem.Name = "diem";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 767);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.ComboBox cbTenDauDiem;
        private System.Windows.Forms.ComboBox cbMSV;
        private System.Windows.Forms.ComboBox cbTenLopHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Luoi_DSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_daudiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendaudiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
    }
}