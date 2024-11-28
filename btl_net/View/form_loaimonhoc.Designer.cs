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
            this.dgv_Loai = new System.Windows.Forms.DataGridView();
            this.is_xoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaimh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_phanloai_monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtloaimh = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.chb_thungrac = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_lietke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Loai
            // 
            this.dgv_Loai.AllowUserToAddRows = false;
            this.dgv_Loai.AllowUserToDeleteRows = false;
            this.dgv_Loai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Loai.ColumnHeadersHeight = 29;
            this.dgv_Loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Loai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_phanloai_monhoc,
            this.loaimh,
            this.is_xoa});
            this.dgv_Loai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Loai.Location = new System.Drawing.Point(2, 17);
            this.dgv_Loai.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Loai.MultiSelect = false;
            this.dgv_Loai.Name = "dgv_Loai";
            this.dgv_Loai.ReadOnly = true;
            this.dgv_Loai.RowHeadersWidth = 82;
            this.dgv_Loai.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Loai.RowTemplate.Height = 33;
            this.dgv_Loai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Loai.Size = new System.Drawing.Size(717, 225);
            this.dgv_Loai.TabIndex = 0;
            this.dgv_Loai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Loai_CellClick);
            // 
            // is_xoa
            // 
            this.is_xoa.DataPropertyName = "is_xoa";
            this.is_xoa.HeaderText = "is_xoa";
            this.is_xoa.MinimumWidth = 6;
            this.is_xoa.Name = "is_xoa";
            this.is_xoa.ReadOnly = true;
            this.is_xoa.Visible = false;
            // 
            // loaimh
            // 
            this.loaimh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaimh.DataPropertyName = "loaimh";
            this.loaimh.HeaderText = "Phân loại môn học";
            this.loaimh.MinimumWidth = 6;
            this.loaimh.Name = "loaimh";
            this.loaimh.ReadOnly = true;
            // 
            // id_phanloai_monhoc
            // 
            this.id_phanloai_monhoc.DataPropertyName = "id_phanloai_monhoc";
            this.id_phanloai_monhoc.HeaderText = "id_phanloai_monhoc";
            this.id_phanloai_monhoc.MinimumWidth = 6;
            this.id_phanloai_monhoc.Name = "id_phanloai_monhoc";
            this.id_phanloai_monhoc.ReadOnly = true;
            this.id_phanloai_monhoc.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Loai);
            this.groupBox1.Location = new System.Drawing.Point(49, 327);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(721, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị bảng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại môn học";
            // 
            // txtloaimh
            // 
            this.txtloaimh.Location = new System.Drawing.Point(155, 65);
            this.txtloaimh.Margin = new System.Windows.Forms.Padding(2);
            this.txtloaimh.Name = "txtloaimh";
            this.txtloaimh.Size = new System.Drawing.Size(383, 22);
            this.txtloaimh.TabIndex = 4;
            this.txtloaimh.Text = " ";
            // 
            // btnthem
            // 
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Location = new System.Drawing.Point(38, 126);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(98, 37);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.Location = new System.Drawing.Point(179, 126);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(98, 37);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Location = new System.Drawing.Point(320, 126);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 37);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Location = new System.Drawing.Point(589, 126);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(98, 37);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncapnhat.Location = new System.Drawing.Point(456, 126);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(98, 37);
            this.btncapnhat.TabIndex = 11;
            this.btncapnhat.Text = "Khôi phục";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // chb_thungrac
            // 
            this.chb_thungrac.AutoSize = true;
            this.chb_thungrac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_thungrac.Location = new System.Drawing.Point(612, 192);
            this.chb_thungrac.Name = "chb_thungrac";
            this.chb_thungrac.Size = new System.Drawing.Size(89, 20);
            this.chb_thungrac.TabIndex = 12;
            this.chb_thungrac.Text = "Thùng rác";
            this.chb_thungrac.UseVisualStyleBackColor = true;
            this.chb_thungrac.CheckedChanged += new System.EventHandler(this.chb_thungrac_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_lietke);
            this.groupBox2.Controls.Add(this.chb_thungrac);
            this.groupBox2.Controls.Add(this.btncapnhat);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.txtloaimh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Location = new System.Drawing.Point(49, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(719, 224);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin loại môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUẢN LÝ PHÂN LOẠI MÔN HỌC ";
            // 
            // btn_lietke
            // 
            this.btn_lietke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lietke.Location = new System.Drawing.Point(542, 58);
            this.btn_lietke.Margin = new System.Windows.Forms.Padding(2);
            this.btn_lietke.Name = "btn_lietke";
            this.btn_lietke.Size = new System.Drawing.Size(98, 37);
            this.btn_lietke.TabIndex = 13;
            this.btn_lietke.Text = "Liệt kê";
            this.btn_lietke.UseVisualStyleBackColor = true;
            this.btn_lietke.Click += new System.EventHandler(this.btn_lietke_Click);
            // 
            // form_loaimonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(814, 604);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form_loaimonhoc";
            this.Text = "FormQLMH";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_phanloai_monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaimh;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtloaimh;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.CheckBox chb_thungrac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_lietke;
    }
}