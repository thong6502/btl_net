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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Luoi_SV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbtn_conhoc = new System.Windows.Forms.RadioButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tbtn_bohoc = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_nganh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_SV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Luoi_SV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 374);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(713, 251);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng số : 0";
            // 
            // Luoi_SV
            // 
            this.Luoi_SV.AllowUserToAddRows = false;
            this.Luoi_SV.AllowUserToDeleteRows = false;
            this.Luoi_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_SV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msv,
            this.hoten,
            this.tenchuyennganh,
            this.kyhoc,
            this.tenlophoc});
            this.Luoi_SV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Luoi_SV.Location = new System.Drawing.Point(3, 19);
            this.Luoi_SV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Luoi_SV.Name = "Luoi_SV";
            this.Luoi_SV.ReadOnly = true;
            this.Luoi_SV.RowHeadersWidth = 51;
            this.Luoi_SV.RowTemplate.Height = 28;
            this.Luoi_SV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_SV.Size = new System.Drawing.Size(707, 230);
            this.Luoi_SV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ THỐNG KÊ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbtn_conhoc);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.tbtn_bohoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_nganh);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(26, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 273);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbtn_conhoc
            // 
            this.tbtn_conhoc.AutoSize = true;
            this.tbtn_conhoc.Checked = true;
            this.tbtn_conhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtn_conhoc.Location = new System.Drawing.Point(575, 239);
            this.tbtn_conhoc.Name = "tbtn_conhoc";
            this.tbtn_conhoc.Size = new System.Drawing.Size(58, 20);
            this.tbtn_conhoc.TabIndex = 30;
            this.tbtn_conhoc.TabStop = true;
            this.tbtn_conhoc.Text = "pass";
            this.tbtn_conhoc.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 16;
            this.comboBox3.Location = new System.Drawing.Point(150, 176);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(497, 24);
            this.comboBox3.TabIndex = 34;
            // 
            // tbtn_bohoc
            // 
            this.tbtn_bohoc.AutoSize = true;
            this.tbtn_bohoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtn_bohoc.Location = new System.Drawing.Point(642, 238);
            this.tbtn_bohoc.Name = "tbtn_bohoc";
            this.tbtn_bohoc.Size = new System.Drawing.Size(59, 20);
            this.tbtn_bohoc.TabIndex = 28;
            this.tbtn_bohoc.Text = "Trượt";
            this.tbtn_bohoc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ngành học:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 16;
            this.comboBox2.Location = new System.Drawing.Point(150, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(497, 24);
            this.comboBox2.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Location = new System.Drawing.Point(150, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(497, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Môn học:";
            // 
            // cb_nganh
            // 
            this.cb_nganh.FormattingEnabled = true;
            this.cb_nganh.ItemHeight = 16;
            this.cb_nganh.Location = new System.Drawing.Point(150, 75);
            this.cb_nganh.Name = "cb_nganh";
            this.cb_nganh.Size = new System.Drawing.Size(497, 24);
            this.cb_nganh.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Tên lớp học:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Kỳ học:";
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
            // tenchuyennganh
            // 
            this.tenchuyennganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenchuyennganh.DataPropertyName = "tenchuyennganh";
            this.tenchuyennganh.HeaderText = "Chuyên ngành";
            this.tenchuyennganh.MinimumWidth = 6;
            this.tenchuyennganh.Name = "tenchuyennganh";
            this.tenchuyennganh.ReadOnly = true;
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
            // tenlophoc
            // 
            this.tenlophoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenlophoc.DataPropertyName = "tenlophoc";
            this.tenlophoc.HeaderText = "Lớp học";
            this.tenlophoc.MinimumWidth = 6;
            this.tenlophoc.Name = "tenlophoc";
            this.tenlophoc.ReadOnly = true;
            // 
            // form_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "form_thongke";
            this.Text = "form_thongke";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_SV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Luoi_SV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchuyennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlophoc;
        private System.Windows.Forms.RadioButton tbtn_conhoc;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton tbtn_bohoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_nganh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}