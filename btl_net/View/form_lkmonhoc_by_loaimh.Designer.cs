namespace btl_net.View
{
    partial class form_lkmonhoc_by_loaimh
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
            this.txt_head = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_monhoc_by_loai = new System.Windows.Forms.DataGridView();
            this.loaimh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_xoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc_by_loai)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_head
            // 
            this.txt_head.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_head.Location = new System.Drawing.Point(1, 42);
            this.txt_head.Name = "txt_head";
            this.txt_head.Size = new System.Drawing.Size(815, 61);
            this.txt_head.TabIndex = 9;
            this.txt_head.Text = "DANH SÁCH CÁC MÔN HỌC CỦA ";
            this.txt_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_monhoc_by_loai);
            this.groupBox1.Location = new System.Drawing.Point(23, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(780, 244);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị bảng";
            // 
            // dgv_monhoc_by_loai
            // 
            this.dgv_monhoc_by_loai.AllowUserToAddRows = false;
            this.dgv_monhoc_by_loai.AllowUserToDeleteRows = false;
            this.dgv_monhoc_by_loai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_monhoc_by_loai.ColumnHeadersHeight = 29;
            this.dgv_monhoc_by_loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_monhoc_by_loai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loaimh,
            this.is_xoa});
            this.dgv_monhoc_by_loai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_monhoc_by_loai.Location = new System.Drawing.Point(2, 17);
            this.dgv_monhoc_by_loai.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_monhoc_by_loai.MultiSelect = false;
            this.dgv_monhoc_by_loai.Name = "dgv_monhoc_by_loai";
            this.dgv_monhoc_by_loai.ReadOnly = true;
            this.dgv_monhoc_by_loai.RowHeadersWidth = 82;
            this.dgv_monhoc_by_loai.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_monhoc_by_loai.RowTemplate.Height = 33;
            this.dgv_monhoc_by_loai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_monhoc_by_loai.Size = new System.Drawing.Size(776, 225);
            this.dgv_monhoc_by_loai.TabIndex = 0;
            // 
            // loaimh
            // 
            this.loaimh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaimh.DataPropertyName = "tenmonhoc";
            this.loaimh.HeaderText = "Tên môn học";
            this.loaimh.MinimumWidth = 6;
            this.loaimh.Name = "loaimh";
            this.loaimh.ReadOnly = true;
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(698, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_lkmonhoc_by_loaimh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_head);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_lkmonhoc_by_loaimh";
            this.Text = "form_lkmonhoc_by_loaimh";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc_by_loai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt_head;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_monhoc_by_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaimh;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_xoa;
        private System.Windows.Forms.Button button1;
    }
}