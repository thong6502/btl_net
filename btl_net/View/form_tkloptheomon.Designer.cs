namespace btl_net.View
{
    partial class form_tkloptheomon
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
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.lblTongSoLop = new System.Windows.Forms.GroupBox();
            this.Luoi_DSL = new System.Windows.Forms.DataGridView();
            this.id_lophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhvientoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.lblTongSoLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ LỚP THEO MÔN HỌC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenMonHoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên môn học:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Enabled = false;
            this.txtTenMonHoc.Location = new System.Drawing.Point(502, 106);
            this.txtTenMonHoc.Multiline = true;
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(271, 36);
            this.txtTenMonHoc.TabIndex = 1;
            // 
            // lblTongSoLop
            // 
            this.lblTongSoLop.Controls.Add(this.Luoi_DSL);
            this.lblTongSoLop.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoLop.Location = new System.Drawing.Point(13, 402);
            this.lblTongSoLop.Name = "lblTongSoLop";
            this.lblTongSoLop.Size = new System.Drawing.Size(1151, 301);
            this.lblTongSoLop.TabIndex = 2;
            this.lblTongSoLop.TabStop = false;
            this.lblTongSoLop.Text = "Tổng số lớp học: 0";
            // 
            // Luoi_DSL
            // 
            this.Luoi_DSL.AllowUserToAddRows = false;
            this.Luoi_DSL.AllowUserToDeleteRows = false;
            this.Luoi_DSL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Luoi_DSL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_DSL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lophoc,
            this.tenlop,
            this.kyhoc,
            this.sinhvientoida});
            this.Luoi_DSL.Location = new System.Drawing.Point(6, 34);
            this.Luoi_DSL.Name = "Luoi_DSL";
            this.Luoi_DSL.ReadOnly = true;
            this.Luoi_DSL.RowHeadersWidth = 62;
            this.Luoi_DSL.RowTemplate.Height = 28;
            this.Luoi_DSL.Size = new System.Drawing.Size(1139, 261);
            this.Luoi_DSL.TabIndex = 0;
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
            // tenlop
            // 
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên lớp học";
            this.tenlop.MinimumWidth = 8;
            this.tenlop.Name = "tenlop";
            this.tenlop.ReadOnly = true;
            // 
            // kyhoc
            // 
            this.kyhoc.DataPropertyName = "kyhoc";
            this.kyhoc.HeaderText = "Kỳ học";
            this.kyhoc.MinimumWidth = 8;
            this.kyhoc.Name = "kyhoc";
            this.kyhoc.ReadOnly = true;
            // 
            // sinhvientoida
            // 
            this.sinhvientoida.DataPropertyName = "sinhvientoida";
            this.sinhvientoida.HeaderText = "Sinh viên tối đa";
            this.sinhvientoida.MinimumWidth = 8;
            this.sinhvientoida.Name = "sinhvientoida";
            this.sinhvientoida.ReadOnly = true;
            // 
            // form_tkloptheomon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 715);
            this.Controls.Add(this.lblTongSoLop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "form_tkloptheomon";
            this.Text = "form_tkloptheomon";
            this.Load += new System.EventHandler(this.form_tkloptheomon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lblTongSoLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_DSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox lblTongSoLop;
        private System.Windows.Forms.DataGridView Luoi_DSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhvientoida;
    }
}