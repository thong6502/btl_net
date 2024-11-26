namespace btl_net.View
{
    partial class form_thongke
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
            this.gb_thongke = new System.Windows.Forms.GroupBox();
            this.Datagridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_pass = new System.Windows.Forms.RadioButton();
            this.cb_nganhhoc = new System.Windows.Forms.ComboBox();
            this.rbt_notpass = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tenlophoc = new System.Windows.Forms.ComboBox();
            this.cb_monhoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_kyhoc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.is_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_bh_chophep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemquamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_msv = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_thongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_thongke
            // 
            this.gb_thongke.Controls.Add(this.Datagridview);
            this.gb_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongke.Location = new System.Drawing.Point(23, 374);
            this.gb_thongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_thongke.Name = "gb_thongke";
            this.gb_thongke.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_thongke.Size = new System.Drawing.Size(1650, 251);
            this.gb_thongke.TabIndex = 8;
            this.gb_thongke.TabStop = false;
            this.gb_thongke.Text = "Tổng số : 0";
            // 
            // Datagridview
            // 
            this.Datagridview.AllowUserToAddRows = false;
            this.Datagridview.AllowUserToDeleteRows = false;
            this.Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.is_pass,
            this.msv,
            this.hoten,
            this.kyhoc,
            this.tenchuyennganh,
            this.tenlophoc,
            this.tenmonhoc,
            this.max_bh_chophep,
            this.diemquamon,
            this.detail});
            this.Datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Datagridview.Location = new System.Drawing.Point(3, 19);
            this.Datagridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Datagridview.Name = "Datagridview";
            this.Datagridview.ReadOnly = true;
            this.Datagridview.RowHeadersWidth = 51;
            this.Datagridview.RowTemplate.Height = 28;
            this.Datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagridview.Size = new System.Drawing.Size(1644, 230);
            this.Datagridview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(745, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ THỐNG KÊ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.txt_msv);
            this.groupBox1.Controls.Add(this.btn_thongke);
            this.groupBox1.Controls.Add(this.rbt_pass);
            this.groupBox1.Controls.Add(this.cb_nganhhoc);
            this.groupBox1.Controls.Add(this.rbt_notpass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_tenlophoc);
            this.groupBox1.Controls.Add(this.cb_monhoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_kyhoc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(26, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1647, 273);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbt_pass
            // 
            this.rbt_pass.AutoSize = true;
            this.rbt_pass.Checked = true;
            this.rbt_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbt_pass.Location = new System.Drawing.Point(1500, 248);
            this.rbt_pass.Name = "rbt_pass";
            this.rbt_pass.Size = new System.Drawing.Size(58, 20);
            this.rbt_pass.TabIndex = 30;
            this.rbt_pass.TabStop = true;
            this.rbt_pass.Text = "pass";
            this.rbt_pass.UseVisualStyleBackColor = true;
            this.rbt_pass.CheckedChanged += new System.EventHandler(this.rbt_pass_CheckedChanged);
            // 
            // cb_nganhhoc
            // 
            this.cb_nganhhoc.FormattingEnabled = true;
            this.cb_nganhhoc.ItemHeight = 16;
            this.cb_nganhhoc.Location = new System.Drawing.Point(223, 154);
            this.cb_nganhhoc.Name = "cb_nganhhoc";
            this.cb_nganhhoc.Size = new System.Drawing.Size(497, 24);
            this.cb_nganhhoc.TabIndex = 34;
            // 
            // rbt_notpass
            // 
            this.rbt_notpass.AutoSize = true;
            this.rbt_notpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbt_notpass.Location = new System.Drawing.Point(1567, 247);
            this.rbt_notpass.Name = "rbt_notpass";
            this.rbt_notpass.Size = new System.Drawing.Size(59, 20);
            this.rbt_notpass.TabIndex = 28;
            this.rbt_notpass.Text = "Trượt";
            this.rbt_notpass.UseVisualStyleBackColor = true;
            this.rbt_notpass.CheckedChanged += new System.EventHandler(this.rbt_notpass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ngành học:";
            // 
            // cb_tenlophoc
            // 
            this.cb_tenlophoc.FormattingEnabled = true;
            this.cb_tenlophoc.ItemHeight = 16;
            this.cb_tenlophoc.Location = new System.Drawing.Point(1034, 57);
            this.cb_tenlophoc.Name = "cb_tenlophoc";
            this.cb_tenlophoc.Size = new System.Drawing.Size(497, 24);
            this.cb_tenlophoc.TabIndex = 32;
            // 
            // cb_monhoc
            // 
            this.cb_monhoc.FormattingEnabled = true;
            this.cb_monhoc.ItemHeight = 16;
            this.cb_monhoc.Location = new System.Drawing.Point(1034, 159);
            this.cb_monhoc.Name = "cb_monhoc";
            this.cb_monhoc.Size = new System.Drawing.Size(497, 24);
            this.cb_monhoc.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(935, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Môn học:";
            // 
            // cb_kyhoc
            // 
            this.cb_kyhoc.FormattingEnabled = true;
            this.cb_kyhoc.ItemHeight = 16;
            this.cb_kyhoc.Location = new System.Drawing.Point(1034, 106);
            this.cb_kyhoc.Name = "cb_kyhoc";
            this.cb_kyhoc.Size = new System.Drawing.Size(497, 24);
            this.cb_kyhoc.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(915, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Tên lớp học:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(946, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Kỳ học:";
            // 
            // btn_thongke
            // 
            this.btn_thongke.Location = new System.Drawing.Point(749, 210);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(153, 38);
            this.btn_thongke.TabIndex = 35;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // is_pass
            // 
            this.is_pass.DataPropertyName = "is_pass";
            this.is_pass.HeaderText = "is_pass";
            this.is_pass.MinimumWidth = 6;
            this.is_pass.Name = "is_pass";
            this.is_pass.ReadOnly = true;
            this.is_pass.Visible = false;
            this.is_pass.Width = 125;
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
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // kyhoc
            // 
            this.kyhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kyhoc.DataPropertyName = "kyhoc";
            this.kyhoc.HeaderText = "Kỳ học";
            this.kyhoc.MinimumWidth = 6;
            this.kyhoc.Name = "kyhoc";
            this.kyhoc.ReadOnly = true;
            // 
            // tenchuyennganh
            // 
            this.tenchuyennganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenchuyennganh.DataPropertyName = "tenchuyennganh";
            this.tenchuyennganh.HeaderText = "Chuyên ngành";
            this.tenchuyennganh.MinimumWidth = 6;
            this.tenchuyennganh.Name = "tenchuyennganh";
            this.tenchuyennganh.ReadOnly = true;
            // 
            // tenlophoc
            // 
            this.tenlophoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenlophoc.DataPropertyName = "tenlophoc";
            this.tenlophoc.HeaderText = "Lớp học";
            this.tenlophoc.MinimumWidth = 6;
            this.tenlophoc.Name = "tenlophoc";
            this.tenlophoc.ReadOnly = true;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Môn học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            // 
            // max_bh_chophep
            // 
            this.max_bh_chophep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.max_bh_chophep.DataPropertyName = "max_bh_chophep";
            this.max_bh_chophep.HeaderText = "Giới hạn buổi nghỉ";
            this.max_bh_chophep.MinimumWidth = 6;
            this.max_bh_chophep.Name = "max_bh_chophep";
            this.max_bh_chophep.ReadOnly = true;
            // 
            // diemquamon
            // 
            this.diemquamon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diemquamon.DataPropertyName = "diemquamon";
            this.diemquamon.HeaderText = "Điểm qua môn";
            this.diemquamon.MinimumWidth = 6;
            this.diemquamon.Name = "diemquamon";
            this.diemquamon.ReadOnly = true;
            // 
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail.DataPropertyName = "detail";
            this.detail.HeaderText = "Chi tiết";
            this.detail.MinimumWidth = 6;
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            // 
            // txt_msv
            // 
            this.txt_msv.Location = new System.Drawing.Point(223, 57);
            this.txt_msv.Name = "txt_msv";
            this.txt_msv.Size = new System.Drawing.Size(497, 22);
            this.txt_msv.TabIndex = 36;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(223, 104);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(497, 22);
            this.txt_ten.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mã sinh viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tên sinh viên";
            // 
            // form_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1741, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_thongke);
            this.Controls.Add(this.label1);
            this.Name = "form_thongke";
            this.Text = "form_thongke";
            this.gb_thongke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_thongke;
        private System.Windows.Forms.DataGridView Datagridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_pass;
        private System.Windows.Forms.ComboBox cb_nganhhoc;
        private System.Windows.Forms.RadioButton rbt_notpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tenlophoc;
        private System.Windows.Forms.ComboBox cb_monhoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_kyhoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchuyennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_bh_chophep;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemquamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_msv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}