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
            this.cb_nganh = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Luoi_SV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.id_lophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_SV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_nganh
            // 
            this.cb_nganh.FormattingEnabled = true;
            this.cb_nganh.ItemHeight = 18;
            this.cb_nganh.Location = new System.Drawing.Point(161, 90);
            this.cb_nganh.Name = "cb_nganh";
            this.cb_nganh.Size = new System.Drawing.Size(448, 26);
            this.cb_nganh.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnThoat.Location = new System.Drawing.Point(524, 231);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 44);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnXoa.Location = new System.Drawing.Point(263, 231);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 44);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSua.Location = new System.Drawing.Point(137, 231);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 44);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnThem.Location = new System.Drawing.Point(16, 231);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 44);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(161, 47);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSV.Multiline = true;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(448, 28);
            this.txtMaSV.TabIndex = 1;
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
            this.groupBox2.Controls.Add(this.Luoi_SV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 383);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(644, 251);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học";
            // 
            // Luoi_SV
            // 
            this.Luoi_SV.AllowUserToAddRows = false;
            this.Luoi_SV.AllowUserToDeleteRows = false;
            this.Luoi_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_SV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lophoc,
            this.tenlophoc,
            this.tenmonhoc,
            this.kyhoc,
            this.sosinhvien});
            this.Luoi_SV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Luoi_SV.Location = new System.Drawing.Point(3, 19);
            this.Luoi_SV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Luoi_SV.Name = "Luoi_SV";
            this.Luoi_SV.ReadOnly = true;
            this.Luoi_SV.RowHeadersWidth = 51;
            this.Luoi_SV.RowTemplate.Height = 28;
            this.Luoi_SV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_SV.Size = new System.Drawing.Size(638, 230);
            this.Luoi_SV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_nganh);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(642, 296);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.Location = new System.Drawing.Point(161, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(448, 26);
            this.comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Môn học:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(398, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tối đa sinh viên:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 180);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 28);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "40";
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
            // sosinhvien
            // 
            this.sosinhvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sosinhvien.HeaderText = "Số sinh viên";
            this.sosinhvien.MinimumWidth = 6;
            this.sosinhvien.Name = "sosinhvien";
            this.sosinhvien.ReadOnly = true;
            // 
            // form_lophoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "form_lophoc";
            this.Text = "form_lophoc";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_SV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_nganh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Luoi_SV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosinhvien;
        private System.Windows.Forms.TextBox textBox1;
    }
}