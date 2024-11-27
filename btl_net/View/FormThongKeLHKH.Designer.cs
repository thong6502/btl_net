namespace btl_net.View
{
    partial class FormThongKeLHKH
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
            this.txtTenHocKy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongSoLop = new System.Windows.Forms.GroupBox();
            this.LUOI_LHHK = new System.Windows.Forms.DataGridView();
            this.id_kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.lblTongSoLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUOI_LHHK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ SỐ LỚP HỌC CỦA KỲ HỌC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenHocKy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1144, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học kỳ";
            // 
            // txtTenHocKy
            // 
            this.txtTenHocKy.Enabled = false;
            this.txtTenHocKy.Location = new System.Drawing.Point(396, 88);
            this.txtTenHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHocKy.Multiline = true;
            this.txtTenHocKy.Name = "txtTenHocKy";
            this.txtTenHocKy.Size = new System.Drawing.Size(361, 37);
            this.txtTenHocKy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên học kỳ";
            // 
            // lblTongSoLop
            // 
            this.lblTongSoLop.Controls.Add(this.LUOI_LHHK);
            this.lblTongSoLop.Location = new System.Drawing.Point(11, 281);
            this.lblTongSoLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTongSoLop.Name = "lblTongSoLop";
            this.lblTongSoLop.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTongSoLop.Size = new System.Drawing.Size(1145, 296);
            this.lblTongSoLop.TabIndex = 2;
            this.lblTongSoLop.TabStop = false;
            this.lblTongSoLop.Text = "Tổng số lớp học: 0";
            // 
            // LUOI_LHHK
            // 
            this.LUOI_LHHK.AllowUserToAddRows = false;
            this.LUOI_LHHK.AllowUserToDeleteRows = false;
            this.LUOI_LHHK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LUOI_LHHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LUOI_LHHK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_kyhoc,
            this.id_lophoc,
            this.tenlop});
            this.LUOI_LHHK.Location = new System.Drawing.Point(15, 20);
            this.LUOI_LHHK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LUOI_LHHK.MultiSelect = false;
            this.LUOI_LHHK.Name = "LUOI_LHHK";
            this.LUOI_LHHK.ReadOnly = true;
            this.LUOI_LHHK.RowHeadersWidth = 62;
            this.LUOI_LHHK.RowTemplate.Height = 28;
            this.LUOI_LHHK.Size = new System.Drawing.Size(1124, 271);
            this.LUOI_LHHK.TabIndex = 0;
            // 
            // id_kyhoc
            // 
            this.id_kyhoc.DataPropertyName = "id_kyhoc";
            this.id_kyhoc.HeaderText = "ID học kỳ";
            this.id_kyhoc.MinimumWidth = 8;
            this.id_kyhoc.Name = "id_kyhoc";
            this.id_kyhoc.ReadOnly = true;
            this.id_kyhoc.Visible = false;
            // 
            // id_lophoc
            // 
            this.id_lophoc.DataPropertyName = "id_lophoc";
            this.id_lophoc.HeaderText = "ID Lớp học";
            this.id_lophoc.MinimumWidth = 8;
            this.id_lophoc.Name = "id_lophoc";
            this.id_lophoc.ReadOnly = true;
            // 
            // tenlop
            // 
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên lớp học";
            this.tenlop.MinimumWidth = 8;
            this.tenlop.Name = "tenlop";
            this.tenlop.ReadOnly = true;
            // 
            // FormThongKeLHKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 595);
            this.Controls.Add(this.lblTongSoLop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThongKeLHKH";
            this.Text = "FormThongKeLHKH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lblTongSoLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LUOI_LHHK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox lblTongSoLop;
        private System.Windows.Forms.DataGridView LUOI_LHHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
    }
}