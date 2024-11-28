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
    public partial class FormThongKeLHKH : Form
    {
        private string tenHocKy;
        Dbconnect db = new Dbconnect();
        public FormThongKeLHKH(string tenHocKy)
        {
            InitializeComponent();
            this.tenHocKy = tenHocKy;
            
        }
        private void TaiDuLieuThongKeLopHoc()
        {
            DataTable dt = db.GetLopHocTheoHocKy(tenHocKy);
            if (dt != null)
            {
                LUOI_LHHK.DataSource = dt; // Hiển thị danh sách lớp học
                lblTongSoLop.Text = $"Tổng số lớp học: {dt.Rows.Count}"; // Cập nhật tổng số lớp
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu lớp học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormThongKeLHKH_Load(object sender, EventArgs e)
        {
            txtTenHocKy.Text = tenHocKy;
            TaiDuLieuThongKeLopHoc();
        }
    }
}
