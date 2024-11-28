namespace btl_net.View
{
    partial class form_lklophoc_by_sinhvien
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
            this.dgv_lophoc_by_idsv = new System.Windows.Forms.DataGridView();
            this.is_xoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lophoc_by_idsv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(778, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_head
            // 
            this.txt_head.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_head.Location = new System.Drawing.Point(-12, 30);
            this.txt_head.Name = "txt_head";
            this.txt_head.Size = new System.Drawing.Size(903, 61);
            this.txt_head.TabIndex = 12;
            this.txt_head.Text = "DANH SÁCH LỚP HỌC CỦA SINH VIÊN ";
            this.txt_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_lophoc_by_idsv);
            this.groupBox1.Location = new System.Drawing.Point(10, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(859, 244);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị bảng";
            // 
            // dgv_lophoc_by_idsv
            // 
            this.dgv_lophoc_by_idsv.AllowUserToAddRows = false;
            this.dgv_lophoc_by_idsv.AllowUserToDeleteRows = false;
            this.dgv_lophoc_by_idsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lophoc_by_idsv.ColumnHeadersHeight = 29;
            this.dgv_lophoc_by_idsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_lophoc_by_idsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.is_xoa,
            this.kyhoc,
            this.tenlophoc});
            this.dgv_lophoc_by_idsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_lophoc_by_idsv.Location = new System.Drawing.Point(2, 17);
            this.dgv_lophoc_by_idsv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_lophoc_by_idsv.MultiSelect = false;
            this.dgv_lophoc_by_idsv.Name = "dgv_lophoc_by_idsv";
            this.dgv_lophoc_by_idsv.ReadOnly = true;
            this.dgv_lophoc_by_idsv.RowHeadersWidth = 82;
            this.dgv_lophoc_by_idsv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_lophoc_by_idsv.RowTemplate.Height = 33;
            this.dgv_lophoc_by_idsv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lophoc_by_idsv.Size = new System.Drawing.Size(855, 225);
            this.dgv_lophoc_by_idsv.TabIndex = 0;
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
            // form_lklophoc_by_sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_head);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_lklophoc_by_sinhvien";
            this.Text = "form_lklophoc_by_sinhvien";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lophoc_by_idsv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_head;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_lophoc_by_idsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlophoc;
    }
}