namespace btl_net.View
{
    partial class FormHocKy
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenHocKy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Luoi_DSHK = new System.Windows.Forms.DataGridView();
            this.id_kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluonglophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chb_thungrac = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSHK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Học Kỳ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_thungrac);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnKhoiPhuc);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTenHocKy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1088, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học kỳ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Location = new System.Drawing.Point(780, 77);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(114, 42);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Location = new System.Drawing.Point(823, 155);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 37);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(663, 155);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(128, 37);
            this.btnKhoiPhuc.TabIndex = 2;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(492, 155);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 37);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(321, 155);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 37);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(141, 155);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 37);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenHocKy
            // 
            this.txtTenHocKy.Enabled = false;
            this.txtTenHocKy.Location = new System.Drawing.Point(265, 87);
            this.txtTenHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHocKy.Name = "txtTenHocKy";
            this.txtTenHocKy.Size = new System.Drawing.Size(482, 25);
            this.txtTenHocKy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên học kỳ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Luoi_DSHK);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 345);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1088, 277);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học kỳ";
            // 
            // Luoi_DSHK
            // 
            this.Luoi_DSHK.AllowUserToAddRows = false;
            this.Luoi_DSHK.AllowUserToDeleteRows = false;
            this.Luoi_DSHK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_DSHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_DSHK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_kyhoc,
            this.kyhoc,
            this.soluonglophoc});
            this.Luoi_DSHK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Luoi_DSHK.Location = new System.Drawing.Point(4, 22);
            this.Luoi_DSHK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Luoi_DSHK.MultiSelect = false;
            this.Luoi_DSHK.Name = "Luoi_DSHK";
            this.Luoi_DSHK.ReadOnly = true;
            this.Luoi_DSHK.RowHeadersWidth = 62;
            this.Luoi_DSHK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_DSHK.Size = new System.Drawing.Size(1080, 251);
            this.Luoi_DSHK.TabIndex = 0;
            this.Luoi_DSHK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_DSHK_CellClick);
            // 
            // id_kyhoc
            // 
            this.id_kyhoc.DataPropertyName = "id_kyhoc";
            this.id_kyhoc.HeaderText = "ID";
            this.id_kyhoc.MinimumWidth = 8;
            this.id_kyhoc.Name = "id_kyhoc";
            this.id_kyhoc.ReadOnly = true;
            this.id_kyhoc.Visible = false;
            // 
            // kyhoc
            // 
            this.kyhoc.DataPropertyName = "kyhoc";
            this.kyhoc.HeaderText = "Tên học kỳ";
            this.kyhoc.MinimumWidth = 8;
            this.kyhoc.Name = "kyhoc";
            this.kyhoc.ReadOnly = true;
            // 
            // soluonglophoc
            // 
            this.soluonglophoc.DataPropertyName = "soluonglophoc";
            this.soluonglophoc.HeaderText = "Tổng số lớp học";
            this.soluonglophoc.MinimumWidth = 8;
            this.soluonglophoc.Name = "soluonglophoc";
            this.soluonglophoc.ReadOnly = true;
            // 
            // chb_thungrac
            // 
            this.chb_thungrac.AutoSize = true;
            this.chb_thungrac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_thungrac.Location = new System.Drawing.Point(990, 189);
            this.chb_thungrac.Name = "chb_thungrac";
            this.chb_thungrac.Size = new System.Drawing.Size(90, 21);
            this.chb_thungrac.TabIndex = 5;
            this.chb_thungrac.Text = "Thùng rác";
            this.chb_thungrac.UseVisualStyleBackColor = true;
            this.chb_thungrac.CheckedChanged += new System.EventHandler(this.chb_thungrac_CheckedChanged);
            // 
            // FormHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHocKy";
            this.Text = "FormHocKy";
            this.Load += new System.EventHandler(this.FormHocKy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSHK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Luoi_DSHK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluonglophoc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.CheckBox chb_thungrac;
    }
}