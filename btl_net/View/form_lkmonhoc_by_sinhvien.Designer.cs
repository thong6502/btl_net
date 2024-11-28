namespace btl_net.View
{
    partial class form_lkmonhoc_by_sinhvien
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_head = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_monhoc_by_idsv = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.is_xoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeplichthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc_by_idsv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(782, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_head
            // 
            this.txt_head.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_head.Location = new System.Drawing.Point(-1, 32);
            this.txt_head.Name = "txt_head";
            this.txt_head.Size = new System.Drawing.Size(903, 61);
            this.txt_head.TabIndex = 15;
            this.txt_head.Text = "DANH SÁCH MÔN HỌC CỦA SINH VIÊN";
            this.txt_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_monhoc_by_idsv);
            this.groupBox1.Location = new System.Drawing.Point(26, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(859, 244);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị bảng";
            // 
            // dgv_monhoc_by_idsv
            // 
            this.dgv_monhoc_by_idsv.AllowUserToAddRows = false;
            this.dgv_monhoc_by_idsv.AllowUserToDeleteRows = false;
            this.dgv_monhoc_by_idsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_monhoc_by_idsv.ColumnHeadersHeight = 29;
            this.dgv_monhoc_by_idsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_monhoc_by_idsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.is_xoa,
            this.xeplichthi,
            this.kyhoc,
            this.tenlophoc,
            this.tenmonhoc});
            this.dgv_monhoc_by_idsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_monhoc_by_idsv.Location = new System.Drawing.Point(2, 17);
            this.dgv_monhoc_by_idsv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_monhoc_by_idsv.MultiSelect = false;
            this.dgv_monhoc_by_idsv.Name = "dgv_monhoc_by_idsv";
            this.dgv_monhoc_by_idsv.ReadOnly = true;
            this.dgv_monhoc_by_idsv.RowHeadersWidth = 82;
            this.dgv_monhoc_by_idsv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_monhoc_by_idsv.RowTemplate.Height = 33;
            this.dgv_monhoc_by_idsv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_monhoc_by_idsv.Size = new System.Drawing.Size(855, 225);
            this.dgv_monhoc_by_idsv.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(698, 121);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 20);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.Text = "Đang học";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(813, 121);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 20);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "Đã học";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            // xeplichthi
            // 
            this.xeplichthi.DataPropertyName = "xeplichthi";
            this.xeplichthi.HeaderText = "xeplichthi";
            this.xeplichthi.MinimumWidth = 6;
            this.xeplichthi.Name = "xeplichthi";
            this.xeplichthi.ReadOnly = true;
            this.xeplichthi.Visible = false;
            // 
            // kyhoc
            // 
            this.kyhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kyhoc.DataPropertyName = "kyhoc";
            this.kyhoc.HeaderText = "Học kỳ";
            this.kyhoc.MinimumWidth = 6;
            this.kyhoc.Name = "kyhoc";
            this.kyhoc.ReadOnly = true;
            this.kyhoc.Width = 200;
            // 
            // tenlophoc
            // 
            this.tenlophoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenlophoc.DataPropertyName = "tenlophoc";
            this.tenlophoc.HeaderText = "Tên lớp học";
            this.tenlophoc.MinimumWidth = 6;
            this.tenlophoc.Name = "tenlophoc";
            this.tenlophoc.ReadOnly = true;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Môn học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            // 
            // form_lkmonhoc_by_sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_head);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_lkmonhoc_by_sinhvien";
            this.Text = "form_lkmonhoc_by_sinhvien";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc_by_idsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_head;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_monhoc_by_idsv;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeplichthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
    }
}