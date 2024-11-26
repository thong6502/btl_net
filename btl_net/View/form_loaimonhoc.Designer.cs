namespace btl_net.View
{
    partial class form_loaimonhoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Loai = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.radaxoa = new System.Windows.Forms.RadioButton();
            this.rachuaxoa = new System.Windows.Forms.RadioButton();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtloaimh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lý phân loại môn học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Loai);
            this.groupBox1.Location = new System.Drawing.Point(71, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 382);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị bảng";
            // 
            // dgv_Loai
            // 
            this.dgv_Loai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Loai.Location = new System.Drawing.Point(20, 31);
            this.dgv_Loai.Name = "dgv_Loai";
            this.dgv_Loai.RowHeadersWidth = 82;
            this.dgv_Loai.RowTemplate.Height = 33;
            this.dgv_Loai.Size = new System.Drawing.Size(1186, 345);
            this.dgv_Loai.TabIndex = 0;
            this.dgv_Loai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Loai_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncapnhat);
            this.groupBox2.Controls.Add(this.radaxoa);
            this.groupBox2.Controls.Add(this.rachuaxoa);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.txtloaimh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(71, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1232, 396);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin loại môn học";
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(1061, 234);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(171, 49);
            this.btncapnhat.TabIndex = 11;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // radaxoa
            // 
            this.radaxoa.AutoSize = true;
            this.radaxoa.Location = new System.Drawing.Point(911, 345);
            this.radaxoa.Name = "radaxoa";
            this.radaxoa.Size = new System.Drawing.Size(111, 29);
            this.radaxoa.TabIndex = 10;
            this.radaxoa.TabStop = true;
            this.radaxoa.Text = "Đã xóa";
            this.radaxoa.UseVisualStyleBackColor = true;
            this.radaxoa.CheckedChanged += new System.EventHandler(this.radaxoa_CheckedChanged);
            // 
            // rachuaxoa
            // 
            this.rachuaxoa.AutoSize = true;
            this.rachuaxoa.Location = new System.Drawing.Point(1093, 345);
            this.rachuaxoa.Name = "rachuaxoa";
            this.rachuaxoa.Size = new System.Drawing.Size(135, 29);
            this.rachuaxoa.TabIndex = 9;
            this.rachuaxoa.TabStop = true;
            this.rachuaxoa.Text = "Chưa xóa";
            this.rachuaxoa.UseVisualStyleBackColor = true;
            this.rachuaxoa.CheckedChanged += new System.EventHandler(this.rachuaxoa_CheckedChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(867, 234);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(171, 49);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(634, 234);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(171, 49);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(399, 234);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(171, 49);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(161, 234);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(171, 49);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtloaimh
            // 
            this.txtloaimh.Location = new System.Drawing.Point(367, 95);
            this.txtloaimh.Name = "txtloaimh";
            this.txtloaimh.Size = new System.Drawing.Size(401, 31);
            this.txtloaimh.TabIndex = 4;
            this.txtloaimh.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại môn học";
            // 
            // FormQLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1383, 936);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "FormQLMH";
            this.Text = "FormQLMH";
            this.Load += new System.EventHandler(this.FormQLMH_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtloaimh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.RadioButton radaxoa;
        private System.Windows.Forms.RadioButton rachuaxoa;
        private System.Windows.Forms.DataGridView dgv_Loai;
    }
}