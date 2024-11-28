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
    public partial class form_qlmonhoc : Form
    {
        Dbconnect db = new Dbconnect();
        public form_qlmonhoc()
        {
            InitializeComponent();
        }
        private void TaiDuLieuMonHoc(bool is_xoa)
        {
            DataTable dt = db.list_monhoc(is_xoa);
            Luoi_MonHoc.DataSource = dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            load_data_cb_phanloai();
            TaiDuLieuMonHoc(false);
            vohieuhoa(false);
            btnKhoiPhuc.Enabled = false;
            reset();
        }
        public void load_data_cb_phanloai()
        {
            cbLoaiMonHoc.DataSource = db.list_loaimonhoc();
            cbLoaiMonHoc.DisplayMember = "loaimh";
            cbLoaiMonHoc.ValueMember = "id_phanloai_monhoc";
        }
        public void reset()
        {
            txtTenMonHoc.Text = string.Empty;
            txtSoTC.Text = string.Empty;
            txtSoBuoiHoc.Text = string.Empty;
            txtGioiHanNghi.Text = string.Empty;
            txtDiemQuaMon.Text = string.Empty;
            load_data_cb_phanloai();
            cbLoaiMonHoc.SelectedIndex = -1;

        }
        void vohieuhoa(bool gt)
        {
            txtTenMonHoc.Enabled = gt;
            cbLoaiMonHoc.Enabled = gt;
            txtSoBuoiHoc.Enabled = gt;
            txtSoTC.Enabled = gt;
            txtGioiHanNghi.Enabled = gt;
            txtDiemQuaMon.Enabled = gt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                vohieuhoa(true);
                reset();
                btnThem.Text = "Lưu";
                txtTenMonHoc.Focus();

                btnSua.Enabled = false;
                btnKhoiPhuc.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text) ||
                    string.IsNullOrWhiteSpace(txtSoTC.Text) ||
                    string.IsNullOrWhiteSpace(txtSoBuoiHoc.Text) ||
                    string.IsNullOrWhiteSpace(txtGioiHanNghi.Text)||
                    string.IsNullOrWhiteSpace(cbLoaiMonHoc.Text)||
                    string.IsNullOrWhiteSpace(txtDiemQuaMon.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu.");
                    btnThem.Text = "Lưu";
                }
                else if (!int.TryParse(txtSoTC.Text, out int soTinChi))
                {
                    MessageBox.Show("Số tín chỉ phải là một số nguyên.");
                    txtSoTC.Focus();
                    btnThem.Text = "Lưu";
                    return;
                }
                else if (!int.TryParse(txtSoBuoiHoc.Text, out int tongSoBuoiHoc))
                {
                    MessageBox.Show("Tổng số buổi học phải là một số nguyên.");
                    txtSoBuoiHoc.Focus();
                    btnThem.Text = "Lưu";
                    return;
                }
                else if (!int.TryParse(txtGioiHanNghi.Text, out int gioiHanSoBuoiNghi))
                {
                    MessageBox.Show("Giới hạn số buổi nghỉ phải là một số nguyên.");
                    txtGioiHanNghi.Focus();
                    btnThem.Text = "Lưu";
                    return;
                }
                else if (!float.TryParse(txtDiemQuaMon.Text, out float diemQuaMon))
                {
                    MessageBox.Show("Điểm qua môn phải là một kiểu số.");
                    txtGioiHanNghi.Focus();
                    btnThem.Text = "Lưu";
                    return;
                }
                else
                {
                    try
                    {
                        string tenMonHoc = txtTenMonHoc.Text;
                        int idPhanLoaiMonHoc = Convert.ToInt32(cbLoaiMonHoc.SelectedValue); 

                        monhoc_Model mh = new monhoc_Model(0, soTinChi, tongSoBuoiHoc, gioiHanSoBuoiNghi, idPhanLoaiMonHoc, tenMonHoc, false, diemQuaMon);
                        db.them_monhoc(mh);
                        MessageBox.Show("Thêm môn học thành công!");
                        TaiDuLieuMonHoc(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
                    }
                    TaiDuLieuMonHoc(false);
                    reset();
                    vohieuhoa(false);
                    btnThem.Text = "Thêm";
                    btnSua.Enabled = true;
                    btnKhoiPhuc.Enabled = false;
                    btnXoa.Enabled = true;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenMonHoc.Text != "")
            {
                if (btnSua.Text == "Sửa")
                {
                    vohieuhoa(true);
                    btnSua.Text = "Cập nhật";

                    btnThem.Enabled = false;
                    btnKhoiPhuc.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text) ||
                         string.IsNullOrWhiteSpace(txtSoTC.Text) ||
                         string.IsNullOrWhiteSpace(txtSoBuoiHoc.Text) ||
                         string.IsNullOrWhiteSpace(txtGioiHanNghi.Text) ||
                         string.IsNullOrWhiteSpace(cbLoaiMonHoc.Text)||
                         string.IsNullOrWhiteSpace(txtDiemQuaMon.Text))

                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu!");
                    btnSua.Text = "Cập nhật";
                }
                else if (!int.TryParse(txtSoTC.Text, out int soTinChi))
                {
                    MessageBox.Show("Số tín chỉ phải là một số nguyên.");
                    txtSoTC.Focus();
                    btnSua.Text = "Cập nhật";
                    return;
                }
                else if (!int.TryParse(txtSoBuoiHoc.Text, out int tongSoBuoiHoc))
                {
                    MessageBox.Show("Tổng số buổi học phải là một số nguyên.");
                    txtSoBuoiHoc.Focus();
                    btnSua.Text = "Cập nhật";
                    return;
                }
                else if (!int.TryParse(txtGioiHanNghi.Text, out int gioiHanSoBuoiNghi))
                {
                    MessageBox.Show("Giới hạn số buổi nghỉ phải là một số nguyên.");
                    txtGioiHanNghi.Focus();
                    btnSua.Text = "Cập nhật";
                    return;
                }
                else if (!float.TryParse(txtDiemQuaMon.Text, out float diemQuaMon))
                {
                    MessageBox.Show("Điểm qua môn phải là một kiểu số.");
                    txtGioiHanNghi.Focus();
                    btnThem.Text = "Lưu";
                    return;
                }
                else
                {
                    int idMonHoc = Convert.ToInt32(Luoi_MonHoc.SelectedRows[0].Cells["id_monhoc"].Value); 
                    string tenMonHoc = txtTenMonHoc.Text;
                    int idPhanLoaiMonHoc = Convert.ToInt32(cbLoaiMonHoc.SelectedValue);

                    monhoc_Model mh = new monhoc_Model(idMonHoc, soTinChi, tongSoBuoiHoc, gioiHanSoBuoiNghi, idPhanLoaiMonHoc, tenMonHoc, false, diemQuaMon);

                    db.sua_monhoc(mh);
                    MessageBox.Show("Sửa môn học thành công!");
                    TaiDuLieuMonHoc(false);
                    reset();
                    vohieuhoa(false);
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnKhoiPhuc.Enabled = false;
                    btnXoa.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người cần sửa!");
            }               
        }

        private void Luoi_MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in Luoi_MonHoc.SelectedRows)
            {
                txtTenMonHoc.Text = row.Cells["tenmonhoc"].Value.ToString();
                cbLoaiMonHoc.Text = row.Cells["loaimh"].Value.ToString();
                txtSoTC.Text = row.Cells["sotc"].Value.ToString();
                txtSoBuoiHoc.Text = row.Cells["tongsobh"].Value.ToString();
                txtGioiHanNghi.Text = row.Cells["max_bh_chophep"].Value.ToString();
                txtDiemQuaMon.Text = row.Cells["diemquamon"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Luoi_MonHoc.CurrentRow == null ||
                string.IsNullOrWhiteSpace(txtTenMonHoc.Text) ||
                string.IsNullOrWhiteSpace(txtSoTC.Text) ||
                string.IsNullOrWhiteSpace(txtSoBuoiHoc.Text) ||
                string.IsNullOrWhiteSpace(txtGioiHanNghi.Text) ||
                string.IsNullOrWhiteSpace(cbLoaiMonHoc.Text) ||
                string.IsNullOrWhiteSpace(txtDiemQuaMon.Text))
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id_monhoc = (int)Luoi_MonHoc.CurrentRow.Cells["id_monhoc"].Value;
                db.xoa_monhoc(id_monhoc);
                TaiDuLieuMonHoc(false);
                MessageBox.Show("Xóa môn học thành công.");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbtn_MonHocHienCo_CheckedChanged(object sender, EventArgs e)
        {
            TaiDuLieuMonHoc(false);
            vohieuhoa(false);
            btnKhoiPhuc.Enabled = false;

        }

        private void tbtn_MonHocDaXoa_CheckedChanged(object sender, EventArgs e)
        {
            TaiDuLieuMonHoc(true);
            vohieuhoa(false);
            btnKhoiPhuc.Enabled=true;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (Luoi_MonHoc.CurrentRow == null ||
                string.IsNullOrWhiteSpace(txtTenMonHoc.Text) ||
                string.IsNullOrWhiteSpace(txtSoTC.Text) ||
                string.IsNullOrWhiteSpace(txtSoBuoiHoc.Text) ||
                string.IsNullOrWhiteSpace(txtGioiHanNghi.Text) ||
                string.IsNullOrWhiteSpace(cbLoaiMonHoc.Text) ||
                string.IsNullOrWhiteSpace(txtDiemQuaMon.Text))
            {
                MessageBox.Show("Vui lòng chọn môn học cần khôi phục.");
                return;
            }

            int id_monhoc = (int)Luoi_MonHoc.CurrentRow.Cells["id_monhoc"].Value;
            db.khoi_phuc_monhoc(id_monhoc);
            TaiDuLieuMonHoc(true);
            MessageBox.Show("Khôi phục môn học thành công.");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string tenMonHoc = txtTenMonHoc.Text;
            if (string.IsNullOrEmpty(tenMonHoc))
            {
                MessageBox.Show("Vui lòng chọn môn học trước khi thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form thống kê và truyền dữ liệu
            form_tkloptheomon thongKeForm = new form_tkloptheomon(tenMonHoc);
            thongKeForm.Show();
        }
    }
}
