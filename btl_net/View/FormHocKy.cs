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
    public partial class FormHocKy : Form
    {
        Dbconnect db = new Dbconnect();
        
        public FormHocKy()
        {
            InitializeComponent();
        }
        private void TaiDuLieuKyHoc(bool is_xoa)
        {
            Dbconnect db = new Dbconnect();
            DataTable dt = db.list_kyhoc(is_xoa);
            Luoi_DSHK.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormHocKy_Load(object sender, EventArgs e)
        {
            TaiDuLieuKyHoc(false);
            btnKhoiPhuc.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                txtTenHocKy.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                chb_thungrac.Enabled = false;
                btnThem.Text = "Lưu";
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenHocKy.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên học kỳ.");
                    return;
                }
                kyhoc_Model kyhoc = new kyhoc_Model(0, txtTenHocKy.Text, false);
                Dbconnect db = new Dbconnect();
                db.them_kyhoc(kyhoc);
                TaiDuLieuKyHoc(false);
                MessageBox.Show("Thêm học kỳ thành công.");

                txtTenHocKy.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                chb_thungrac.Enabled = false;
                btnThem.Text = "Thêm";
            }
            

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                txtTenHocKy.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                chb_thungrac.Enabled = false;
                btnSua.Text = "Cập nhật";
            }
            else
            {
                if (Luoi_DSHK.CurrentRow == null || string.IsNullOrEmpty(txtTenHocKy.Text))
                {
                    MessageBox.Show("Vui lòng chọn học kỳ và nhập tên học kỳ mới.");
                    return;
                }

                int id_kyhoc = (int)Luoi_DSHK.CurrentRow.Cells["id_kyhoc"].Value;
                kyhoc_Model kyhoc = new kyhoc_Model(id_kyhoc, txtTenHocKy.Text, false);
                Dbconnect db = new Dbconnect();
                db.sua_kyhoc(kyhoc);
                TaiDuLieuKyHoc(false);
                txtTenHocKy.Text = string.Empty;
                MessageBox.Show("Sửa học kỳ thành công.");

                txtTenHocKy.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                chb_thungrac.Enabled = true;
                btnSua.Text = "Sửa";
            }
            
        }

        private void Luoi_DSHK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in Luoi_DSHK.SelectedRows)
            {
                txtTenHocKy.Text = row.Cells["kyhoc"].Value.ToString();
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Luoi_DSHK.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ để xóa.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa học kỳ này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id_kyhoc = (int)Luoi_DSHK.CurrentRow.Cells["id_kyhoc"].Value;
                db.xoa_kyhoc(id_kyhoc);
                TaiDuLieuKyHoc(false); 
                MessageBox.Show("Xóa học kỳ thành công.");
            }
            else
            {
                MessageBox.Show("Hủy bỏ thao tác xóa.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (Luoi_DSHK.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ để khôi phục.");
                return;
            }

            int id_kyhoc = (int)Luoi_DSHK.CurrentRow.Cells["id_kyhoc"].Value;
            Dbconnect db = new Dbconnect();
            db.khoi_phuc_kyhoc(id_kyhoc);
            TaiDuLieuKyHoc(true); 
            MessageBox.Show("Khôi phục học kỳ thành công.");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string tenHocKy = txtTenHocKy.Text.Trim();
            if (string.IsNullOrEmpty(tenHocKy))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập tên học kỳ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormThongKeLHKH tkForm = new FormThongKeLHKH(tenHocKy);
            tkForm.ShowDialog();
        }

        private void chb_thungrac_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_thungrac.Checked)
            {
                TaiDuLieuKyHoc(true);
                txtTenHocKy.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnKhoiPhuc.Enabled = true;
            }
            else
            {
                TaiDuLieuKyHoc(false);
                txtTenHocKy.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnKhoiPhuc.Enabled = false;
            }
        }
    }
}
