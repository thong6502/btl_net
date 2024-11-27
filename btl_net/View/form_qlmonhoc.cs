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
        int global_is_xoa = 0;
        public form_qlmonhoc()
        {
            InitializeComponent();
        }
        private void TaiDuLieuMonHoc()
        {
            DataTable dt = db.list_monhoc();
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = " + global_is_xoa;
            Luoi_MonHoc.DataSource = dv;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            load_data_cb_phanloai();
            TaiDuLieuMonHoc();
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
        }
        private void btnThem_Click(object sender, EventArgs e)
        {


                if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text) ||
                    string.IsNullOrWhiteSpace(txtSoTC.Text) ||
                    string.IsNullOrWhiteSpace(txtSoBuoiHoc.Text) ||
                    string.IsNullOrWhiteSpace(txtGioiHanNghi.Text) ||
                    string.IsNullOrWhiteSpace(cbLoaiMonHoc.Text))
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
                else
                {
                    try
                    {
                        string tenMonHoc = txtTenMonHoc.Text;
                        int idPhanLoaiMonHoc = Convert.ToInt32(cbLoaiMonHoc.SelectedValue);

                        monhoc_Model mh = new monhoc_Model(0, soTinChi, tongSoBuoiHoc, gioiHanSoBuoiNghi, idPhanLoaiMonHoc, tenMonHoc, false);
                        db.them_monhoc(mh);
                        MessageBox.Show("Thêm môn học thành công!");
                        TaiDuLieuMonHoc();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
                    }
                    TaiDuLieuMonHoc();
                    reset();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenMonHoc.Text != "")
            {

                if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text) ||
                         string.IsNullOrWhiteSpace(txtSoTC.Text) ||
                         string.IsNullOrWhiteSpace(txtSoBuoiHoc.Text) ||
                         string.IsNullOrWhiteSpace(txtGioiHanNghi.Text) ||
                         string.IsNullOrWhiteSpace(cbLoaiMonHoc.Text))

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
                else
                {
                    int idMonHoc = Convert.ToInt32(Luoi_MonHoc.SelectedRows[0].Cells["id_monhoc"].Value);
                    string tenMonHoc = txtTenMonHoc.Text;
                    int idPhanLoaiMonHoc = Convert.ToInt32(cbLoaiMonHoc.SelectedValue);

                    monhoc_Model mh = new monhoc_Model(idMonHoc, soTinChi, tongSoBuoiHoc, gioiHanSoBuoiNghi, idPhanLoaiMonHoc, tenMonHoc, false);

                    db.sua_monhoc(mh);
                    MessageBox.Show("Sửa môn học thành công!");
                    TaiDuLieuMonHoc();
                    reset();
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

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (Luoi_MonHoc.SelectedRows.Count > 0)
                {

                    foreach (DataGridViewRow row in Luoi_MonHoc.SelectedRows)
                    {
                        int idMonHoc = Convert.ToInt32(row.Cells["id_monhoc"].Value);

                        db.xoa_monhoc(idMonHoc);
                    }

                    MessageBox.Show("Xóa môn học thành công!");
                    TaiDuLieuMonHoc();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_khoiphuc_Click(object sender, EventArgs e)
        {
            if (Luoi_MonHoc.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in Luoi_MonHoc.SelectedRows)
                {
                    int idMonHoc = Convert.ToInt32(row.Cells["id_monhoc"].Value);
                    db.khoiphuc_monhoc(idMonHoc);
                }

                MessageBox.Show("Khôi phục môn học thành công!");
                TaiDuLieuMonHoc();
            }
        }

        private void chb_thungrac_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_thungrac.Checked)
            {
                global_is_xoa = 1;
                TaiDuLieuMonHoc();
                btn_khoiphuc.Enabled = true;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtGioiHanNghi.Text = "";
                txtSoBuoiHoc.Text = "";
                txtSoTC.Text = "";
                txtTenMonHoc.Text = "";
                cbLoaiMonHoc.SelectedIndex = -1;
            }
            else
            {
                global_is_xoa = 0;
                TaiDuLieuMonHoc();
                btn_khoiphuc.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string tenMonHoc = txtTenMonHoc.Text;
            string PhanLoaiMonHoc = cbLoaiMonHoc.Text;

            DataTable dt = db.search_monhoc(PhanLoaiMonHoc, tenMonHoc);
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = " + global_is_xoa;
            Luoi_MonHoc.DataSource = dv;
        }
    }
}
