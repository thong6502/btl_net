namespace btl_net.View
{
    partial class form_lophoc
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
            this.cb_kyhoc = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_tenlophoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.id_lophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_xoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ti_le_sinh_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_khoiphuc = new System.Windows.Forms.Button();
            this.chb_thungrac = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_lmh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_monhoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_toidasv = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_toidasv)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_kyhoc
            // 
            this.cb_kyhoc.FormattingEnabled = true;
            this.cb_kyhoc.ItemHeight = 18;
            this.cb_kyhoc.Location = new System.Drawing.Point(161, 90);
            this.cb_kyhoc.Name = "cb_kyhoc";
            this.cb_kyhoc.Size = new System.Drawing.Size(612, 26);
            this.cb_kyhoc.TabIndex = 7;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_thoat.Location = new System.Drawing.Point(676, 293);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(98, 44);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_xoa.Location = new System.Drawing.Point(265, 293);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(98, 44);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_sua.Location = new System.Drawing.Point(139, 293);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(98, 44);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_them.Location = new System.Drawing.Point(18, 293);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(98, 44);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tenlophoc
            // 
            this.txt_tenlophoc.Location = new System.Drawing.Point(161, 47);
            this.txt_tenlophoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenlophoc.Multiline = true;
            this.txt_tenlophoc.Name = "txt_tenlophoc";
            this.txt_tenlophoc.Size = new System.Drawing.Size(612, 28);
            this.txt_tenlophoc.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên lớp học:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kỳ học:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagridview);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 460);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(822, 251);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học";
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lophoc,
            this.is_xoa,
            this.tenlophoc,
            this.tenmonhoc,
            this.kyhoc,
            this.ti_le_sinh_vien});
            this.datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview.Location = new System.Drawing.Point(3, 19);
            this.datagridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridview.MultiSelect = false;
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 28;
            this.datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview.Size = new System.Drawing.Size(816, 230);
            this.datagridview.TabIndex = 0;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellClick);
            // 
            // id_lophoc
            // 
            this.id_lophoc.DataPropertyName = "id_lophoc";
            this.id_lophoc.HeaderText = "id_lophoc";
            this.id_lophoc.MinimumWidth = 6;
            this.id_lophoc.Name = "id_lophoc";
            this.id_lophoc.ReadOnly = true;
            this.id_lophoc.Visible = false;
            this.id_lophoc.Width = 125;
            // 
            // is_xoa
            // 
            this.is_xoa.DataPropertyName = "is_xoa";
            this.is_xoa.HeaderText = "is_xoa";
            this.is_xoa.MinimumWidth = 6;
            this.is_xoa.Name = "is_xoa";
            this.is_xoa.ReadOnly = true;
            this.is_xoa.Visible = false;
            this.is_xoa.Width = 125;
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
            this.tenmonhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            // 
            // kyhoc
            // 
            this.kyhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kyhoc.DataPropertyName = "kyhoc";
            this.kyhoc.HeaderText = "kỳ học";
            this.kyhoc.MinimumWidth = 6;
            this.kyhoc.Name = "kyhoc";
            this.kyhoc.ReadOnly = true;
            // 
            // ti_le_sinh_vien
            // 
            this.ti_le_sinh_vien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ti_le_sinh_vien.DataPropertyName = "ti_le_sinh_vien";
            this.ti_le_sinh_vien.HeaderText = "Số sinh viên";
            this.ti_le_sinh_vien.MinimumWidth = 6;
            this.ti_le_sinh_vien.Name = "ti_le_sinh_vien";
            this.ti_le_sinh_vien.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txt_toidasv);
            this.groupBox1.Controls.Add(this.btn_khoiphuc);
            this.groupBox1.Controls.Add(this.chb_thungrac);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.cb_lmh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_monhoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_kyhoc);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_tenlophoc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(799, 412);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // btn_khoiphuc
            // 
            this.btn_khoiphuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_khoiphuc.Enabled = false;
            this.btn_khoiphuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_khoiphuc.Location = new System.Drawing.Point(395, 293);
            this.btn_khoiphuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_khoiphuc.Name = "btn_khoiphuc";
            this.btn_khoiphuc.Size = new System.Drawing.Size(98, 44);
            this.btn_khoiphuc.TabIndex = 19;
            this.btn_khoiphuc.Text = "Khôi phục";
            this.btn_khoiphuc.UseVisualStyleBackColor = true;
            this.btn_khoiphuc.Click += new System.EventHandler(this.btn_khoiphuc_Click);
            // 
            // chb_thungrac
            // 
            this.chb_thungrac.AutoSize = true;
            this.chb_thungrac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_thungrac.Location = new System.Drawing.Point(697, 368);
            this.chb_thungrac.Name = "chb_thungrac";
            this.chb_thungrac.Size = new System.Drawing.Size(96, 22);
            this.chb_thungrac.TabIndex = 18;
            this.chb_thungrac.Text = "Thùng rác";
            this.chb_thungrac.UseVisualStyleBackColor = true;
            this.chb_thungrac.CheckedChanged += new System.EventHandler(this.chb_thungrac_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_search.Location = new System.Drawing.Point(535, 293);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 44);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_lmh
            // 
            this.cb_lmh.FormattingEnabled = true;
            this.cb_lmh.ItemHeight = 18;
            this.cb_lmh.Location = new System.Drawing.Point(161, 132);
            this.cb_lmh.Name = "cb_lmh";
            this.cb_lmh.Size = new System.Drawing.Size(612, 26);
            this.cb_lmh.TabIndex = 15;
            this.cb_lmh.SelectedIndexChanged += new System.EventHandler(this.cb_lmh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Loại môn học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tối đa sinh viên:";
            // 
            // cb_monhoc
            // 
            this.cb_monhoc.FormattingEnabled = true;
            this.cb_monhoc.ItemHeight = 18;
            this.cb_monhoc.Location = new System.Drawing.Point(161, 175);
            this.cb_monhoc.Name = "cb_monhoc";
            this.cb_monhoc.Size = new System.Drawing.Size(612, 26);
            this.cb_monhoc.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Môn học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // txt_toidasv
            // 
            this.txt_toidasv.Location = new System.Drawing.Point(162, 222);
            this.txt_toidasv.Name = "txt_toidasv";
            this.txt_toidasv.Size = new System.Drawing.Size(612, 24);
            this.txt_toidasv.TabIndex = 20;
            this.txt_toidasv.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // form_lophoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 722);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "form_lophoc";
            this.Text = "form_lophoc";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_toidasv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_kyhoc;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_tenlophoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_monhoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_lmh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ti_le_sinh_vien;
        private System.Windows.Forms.Button btn_khoiphuc;
        private System.Windows.Forms.CheckBox chb_thungrac;
        private System.Windows.Forms.NumericUpDown txt_toidasv;
    }
}