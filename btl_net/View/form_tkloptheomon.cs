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
    public partial class form_tkloptheomon : Form
    {
        Dbconnect db = new Dbconnect();
        private string tenMonHoc;
        public form_tkloptheomon(string tenMonHoc)
        {
            InitializeComponent();
            this.tenMonHoc = tenMonHoc;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void form_tkloptheomon_Load(object sender, EventArgs e)
        {
            txtTenMonHoc.Text = tenMonHoc;
            TaiDanhSachLopHoc();
        }

        private void TaiDanhSachLopHoc()
        {
            
            DataTable dt = db.GetLopHocTheoMon(tenMonHoc);

            if (dt != null)
            {
                Luoi_DSL.DataSource = dt;
                lblTongSoLop.Text = $"Tổng số lớp học: {dt.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách lớp học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
