using btl_net.Controller;
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
    public partial class FormQLMH : Form
    {
        Dbconnect db = new Dbconnect();
        int local_is_chuaxoa = 1;
        public FormQLMH()
        {
            InitializeComponent();
        }
        public void xoaText()
        {
            txtloaimh.ResetText();
            if (local_is_chuaxoa == 1)
            {
                btnthem.Enabled = true;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btncapnhat.Enabled = false;
            }
            else
            {
                btnthem.Enabled = true;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btncapnhat.Enabled = false;

            }
        }
        public void TaiDuLieuQL()
        {
            DataTable dt = db.list_sinhvien();

            DataView dv = new DataView(dt);
            dv.RowFilter = "is_conhoc = " + local_is_chuaxoa; // Lọc dữ liệu

            dgv_Loai.DataSource = dv; // Gán DataView cho DataGridView
        }
        private void FormQLMH_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtloaimh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            else
            {
                string loaimh = txtloaimh.Text.Trim();

            }
        }
    }
}
