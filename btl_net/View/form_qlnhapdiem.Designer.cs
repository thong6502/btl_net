namespace btl_net.View
{
    partial class form_qlnhapdiem
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
            this.btnCapNhatDiem = new System.Windows.Forms.Button();
            this.cbTenLopHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongSoSV = new System.Windows.Forms.GroupBox();
            this.Luoi_DSSV = new System.Windows.Forms.DataGridView();
            this.id_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.lblTongSoSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHẬP ĐIỂM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhatDiem);
            this.groupBox1.Controls.Add(this.cbTenLopHoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1253, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp";
            // 
            // btnCapNhatDiem
            // 
            this.btnCapNhatDiem.Location = new System.Drawing.Point(527, 215);
            this.btnCapNhatDiem.Name = "btnCapNhatDiem";
            this.btnCapNhatDiem.Size = new System.Drawing.Size(158, 48);
            this.btnCapNhatDiem.TabIndex = 2;
            this.btnCapNhatDiem.Text = "Cập nhật điểm";
            this.btnCapNhatDiem.UseVisualStyleBackColor = true;
            this.btnCapNhatDiem.Click += new System.EventHandler(this.btnCapNhatDiem_Click);
            // 
            // cbTenLopHoc
            // 
            this.cbTenLopHoc.FormattingEnabled = true;
            this.cbTenLopHoc.Location = new System.Drawing.Point(437, 113);
            this.cbTenLopHoc.Name = "cbTenLopHoc";
            this.cbTenLopHoc.Size = new System.Drawing.Size(365, 28);
            this.cbTenLopHoc.TabIndex = 1;
            this.cbTenLopHoc.SelectedIndexChanged += new System.EventHandler(this.cbTenLopHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên lớp học:";
            // 
            // lblTongSoSV
            // 
            this.lblTongSoSV.Controls.Add(this.Luoi_DSSV);
            this.lblTongSoSV.Location = new System.Drawing.Point(13, 404);
            this.lblTongSoSV.Name = "lblTongSoSV";
            this.lblTongSoSV.Size = new System.Drawing.Size(1253, 296);
            this.lblTongSoSV.TabIndex = 1;
            this.lblTongSoSV.TabStop = false;
            this.lblTongSoSV.Text = "Danh sách sinh viên 0/0";
            // 
            // Luoi_DSSV
            // 
            this.Luoi_DSSV.AllowUserToAddRows = false;
            this.Luoi_DSSV.AllowUserToDeleteRows = false;
            this.Luoi_DSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_DSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sv,
            this.msv,
            this.hoten,
            this.id_lophoc});
            this.Luoi_DSSV.Location = new System.Drawing.Point(6, 26);
            this.Luoi_DSSV.Name = "Luoi_DSSV";
            this.Luoi_DSSV.ReadOnly = true;
            this.Luoi_DSSV.RowHeadersWidth = 62;
            this.Luoi_DSSV.RowTemplate.Height = 28;
            this.Luoi_DSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_DSSV.Size = new System.Drawing.Size(1240, 264);
            this.Luoi_DSSV.TabIndex = 0;
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
            // msv
            // 
            this.msv.DataPropertyName = "msv";
            this.msv.HeaderText = "MSV";
            this.msv.MinimumWidth = 8;
            this.msv.Name = "msv";
            this.msv.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // id_lophoc
            // 
            this.id_lophoc.DataPropertyName = "id_lophoc";
            this.id_lophoc.HeaderText = "ID lớp học";
            this.id_lophoc.MinimumWidth = 8;
            this.id_lophoc.Name = "id_lophoc";
            this.id_lophoc.ReadOnly = true;
            this.id_lophoc.Visible = false;
            // 
            // form_qlnhapdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 712);
            this.Controls.Add(this.lblTongSoSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "form_qlnhapdiem";
            this.Text = "form_qlnhapdiem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lblTongSoSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhatDiem;
        private System.Windows.Forms.ComboBox cbTenLopHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox lblTongSoSV;
        private System.Windows.Forms.DataGridView Luoi_DSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lophoc;
    }
}