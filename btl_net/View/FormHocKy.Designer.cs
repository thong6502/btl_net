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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHocKy = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Luoi_DSHK = new System.Windows.Forms.DataGridView();
            this.tbtn_hockyhienco = new System.Windows.Forms.RadioButton();
            this.tbtn_hockydaxoa = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.id_kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluonglophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSHK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Học Kỳ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbtn_hockydaxoa);
            this.groupBox1.Controls.Add(this.tbtn_hockyhienco);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnKhoiPhuc);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTenHocKy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên học kỳ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenHocKy
            // 
            this.txtTenHocKy.Location = new System.Drawing.Point(327, 64);
            this.txtTenHocKy.Multiline = true;
            this.txtTenHocKy.Name = "txtTenHocKy";
            this.txtTenHocKy.Size = new System.Drawing.Size(231, 28);
            this.txtTenHocKy.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(145, 171);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(262, 171);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(372, 171);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Location = new System.Drawing.Point(587, 171);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(85, 30);
            this.btnKhoiPhuc.TabIndex = 2;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Luoi_DSHK);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 189);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học kỳ";
            // 
            // Luoi_DSHK
            // 
            this.Luoi_DSHK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_DSHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_DSHK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_kyhoc,
            this.kyhoc,
            this.soluonglophoc});
            this.Luoi_DSHK.Location = new System.Drawing.Point(7, 20);
            this.Luoi_DSHK.Name = "Luoi_DSHK";
            this.Luoi_DSHK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Luoi_DSHK.Size = new System.Drawing.Size(803, 163);
            this.Luoi_DSHK.TabIndex = 0;
            this.Luoi_DSHK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_DSHK_CellClick);
            // 
            // tbtn_hockyhienco
            // 
            this.tbtn_hockyhienco.AutoSize = true;
            this.tbtn_hockyhienco.Checked = true;
            this.tbtn_hockyhienco.Location = new System.Drawing.Point(327, 129);
            this.tbtn_hockyhienco.Name = "tbtn_hockyhienco";
            this.tbtn_hockyhienco.Size = new System.Drawing.Size(98, 19);
            this.tbtn_hockyhienco.TabIndex = 3;
            this.tbtn_hockyhienco.TabStop = true;
            this.tbtn_hockyhienco.Text = "Học kỳ hiện có";
            this.tbtn_hockyhienco.UseVisualStyleBackColor = true;
            this.tbtn_hockyhienco.CheckedChanged += new System.EventHandler(this.tbtn_hockyhienco_CheckedChanged);
            // 
            // tbtn_hockydaxoa
            // 
            this.tbtn_hockydaxoa.AutoSize = true;
            this.tbtn_hockydaxoa.Location = new System.Drawing.Point(463, 129);
            this.tbtn_hockydaxoa.Name = "tbtn_hockydaxoa";
            this.tbtn_hockydaxoa.Size = new System.Drawing.Size(94, 19);
            this.tbtn_hockydaxoa.TabIndex = 3;
            this.tbtn_hockydaxoa.Text = "Học kỳ đã xóa";
            this.tbtn_hockydaxoa.UseVisualStyleBackColor = true;
            this.tbtn_hockydaxoa.CheckedChanged += new System.EventHandler(this.tbtn_hockydaxoa_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(483, 171);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 30);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // id_kyhoc
            // 
            this.id_kyhoc.DataPropertyName = "id_kyhoc";
            this.id_kyhoc.HeaderText = "ID";
            this.id_kyhoc.Name = "id_kyhoc";
            this.id_kyhoc.Visible = false;
            // 
            // kyhoc
            // 
            this.kyhoc.DataPropertyName = "kyhoc";
            this.kyhoc.HeaderText = "Tên học kỳ";
            this.kyhoc.Name = "kyhoc";
            // 
            // soluonglophoc
            // 
            this.soluonglophoc.DataPropertyName = "soluonglophoc";
            this.soluonglophoc.HeaderText = "Tổng số lớp học";
            this.soluonglophoc.Name = "soluonglophoc";
            // 
            // FormHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.RadioButton tbtn_hockyhienco;
        private System.Windows.Forms.RadioButton tbtn_hockydaxoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluonglophoc;
    }
}