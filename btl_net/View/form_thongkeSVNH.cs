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
    public partial class form_thongkeSVNH : Form
    {
        private string tenChuyenNganh;
        Dbconnect db = new Dbconnect();
        public form_thongkeSVNH(string tenChuyenNganh)
        {
            InitializeComponent();
            this.tenChuyenNganh = tenChuyenNganh;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void form_thongkeSVNH_Load(object sender, EventArgs e)
        {
            txtTenChuyenNganh.Text=tenChuyenNganh;
            TaiDanhSachSinhVien();

        }
        private void TaiDanhSachSinhVien()
        {
            DataTable dt = db.GetSinhVienTheoChuyenNganh(tenChuyenNganh);

            if (dt != null)
            {
                LUOI_SVCN.DataSource = dt;
                lblTongSoSV.Text = $"Tổng số sinh viên: {dt.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
