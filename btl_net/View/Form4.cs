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
    public partial class Form4 : Form
    {
        Dbconnect db = new Dbconnect();
        public Form4()
        {
            InitializeComponent();
        }
        private void TaiDuLieuChuyenNganh(bool is_xoa)
        {

            DataTable dt = db.list_chuyennganhvaslsv(is_xoa);
            Luoi_CN.DataSource = dt;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TaiDuLieuChuyenNganh(true);
            btnKhoiPhuc.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenChuyenNganh.Text))
            {
                MessageBox.Show("Vui lòng nhập tên chuyên ngành.");
                return;
            }

            chuyennganh_Model chuyennganh = new chuyennganh_Model(0, txtTenChuyenNganh.Text,true);
            Dbconnect db = new Dbconnect();
            db.them_chuyennganh(chuyennganh);
            TaiDuLieuChuyenNganh(true);
            MessageBox.Show("Thêm chuyên ngành thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Luoi_CN.CurrentRow == null || string.IsNullOrEmpty(txtTenChuyenNganh.Text))
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành và nhập tên chuyên ngành mới.");
                return;
            }

            int id_chuyennganh = (int)Luoi_CN.CurrentRow.Cells["id_chuyennganh"].Value;
            chuyennganh_Model chuyennganh = new chuyennganh_Model(id_chuyennganh, txtTenChuyenNganh.Text, true);
            Dbconnect db = new Dbconnect();
            db.sua_chuyennganh(chuyennganh);
            TaiDuLieuChuyenNganh(true);
            MessageBox.Show("Sửa chuyên ngành thành công.");
        }

        private void Luoi_CN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in Luoi_CN.SelectedRows)
            {
                txtTenChuyenNganh.Text = row.Cells["tenchuyennganh"].Value.ToString();
                

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Luoi_CN.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành để xóa.");
                return;
            }

            // Hiển thị hộp thoại xác nhận trước khi xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chuyên ngành này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            // Nếu người dùng chọn Yes, tiếp tục thực hiện xóa
            if (dialogResult == DialogResult.Yes)
            {
                int id_chuyennganh = (int)Luoi_CN.CurrentRow.Cells["id_chuyennganh"].Value;
                Dbconnect db = new Dbconnect();
                db.xoa_chuyennganh(id_chuyennganh);
                TaiDuLieuChuyenNganh(true);
                MessageBox.Show("Xóa chuyên ngành thành công.");
            }
            else
            {
                // Nếu người dùng chọn No, không làm gì và thoát
                MessageBox.Show("Hủy bỏ thao tác xóa.");
            }
        }

        private void tbtn_chuyenganhhienco_CheckedChanged(object sender, EventArgs e)
        {
            TaiDuLieuChuyenNganh(true);
            txtTenChuyenNganh.Enabled = true;
            btnKhoiPhuc.Enabled = false;
        }

        private void tbtn_chuyennganhdaxoa_CheckedChanged(object sender, EventArgs e)
        {
            TaiDuLieuChuyenNganh(false);
            txtTenChuyenNganh.Enabled = false;
            btnKhoiPhuc.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (Luoi_CN.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành để khôi phục.");
                return;
            }

            int id_chuyennganh = (int)Luoi_CN.CurrentRow.Cells["id_chuyennganh"].Value;
            db.khoi_phuc_chuyenganh(id_chuyennganh);
            TaiDuLieuChuyenNganh(false);
            MessageBox.Show("Khôi phục chuyên ngành thành công.");

        }
    }
}
