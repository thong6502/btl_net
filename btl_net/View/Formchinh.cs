using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_net.View
{
    public partial class Formchinh : Form
    {
        // Biến lưu trữ form con hiện tại
        private Form currentChildForm;

        public Formchinh()
        {
            InitializeComponent();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_sinhvien());
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_qlmonhoc());
        }

        private void đầuĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_daudiem());
        }

        private void OpenChildForm(Form childForm)
        {
            // Kiểm tra và đóng form con hiện tại nếu có
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            // Thiết lập form con mới
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // Đặt form con vừa khít với form cha
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
