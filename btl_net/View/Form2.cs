using btl_net.Controller;
using btl_net.Model;
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
    public partial class Form2 : Form
    {
        Dbconnect db = new Dbconnect();
        public Form2()
        {
            InitializeComponent();
        }
        private void TaiDuLieuMonHoc()
        {
            DataTable dt = db.list_monhoc();
            Luoi_MonHoc.DataSource = dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            TaiDuLieuMonHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text) ||
                string.IsNullOrWhiteSpace(txtIDPhanLoai.Text) ||
                string.IsNullOrWhiteSpace(txtSoTC.Text) ||
                string.IsNullOrWhiteSpace(txtSoBuoiHoc.Text) ||
                string.IsNullOrWhiteSpace(txtGioiHanNghi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            try
            {
                string tenmonhoc = txtTenMonHoc.Text;
                int id_phanloai_mh = int.Parse(txtIDPhanLoai.Text);
                int sotc = int.Parse(txtSoTC.Text);
                int tongsobh = int.Parse(txtSoBuoiHoc.Text);
                int max_bh_chophep = int.Parse(txtGioiHanNghi.Text);

                if (!db.kiemTraIdPhanLoaiMonHoc(id_phanloai_mh))
                {
                    MessageBox.Show("ID Phân Loại Môn Học không tồn tại. Vui lòng kiểm tra lại.");
                    return;
                }
                monhoc_Model monhoc = new monhoc_Model(0, sotc, tongsobh, max_bh_chophep, id_phanloai_mh, tenmonhoc);
                db.them_monhoc(monhoc);
                TaiDuLieuMonHoc(); 
                MessageBox.Show("Thêm môn học thành công.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng dữ liệu cho Số tín chỉ, Tổng số buổi học và Giới hạn buổi nghỉ(Kiểu số).");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
