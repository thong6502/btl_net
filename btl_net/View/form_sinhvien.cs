﻿using btl_net.Controller;
using btl_net.Model;
using btl_net.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace btl_net
{
    public partial class form_sinhvien : Form
    {
        Dbconnect db = new Dbconnect();
        int local_is_conhoc = 1;

        public form_sinhvien()
        {
            InitializeComponent();
            reset();
        }
        public void reset()
        {
            txtCCCD.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtKhoaHoc.Text = string.Empty;
            txtMaSV.Text = string.Empty;
            txtSDT.Text = string.Empty;
            cbGioiTinh.SelectedIndex = 0;

            if(local_is_conhoc == 1)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btn_khoiphuc.Enabled = false;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btn_khoiphuc.Enabled = true;

            }


            load_data_cb_nganh();
            cb_nganh.SelectedIndex = -1;
            TaiDuLieuSinhVien();

        }
        public void load_data_cb_nganh()
        {
            DataTable dt = db.list_chuyennganh();
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = 0"; // Lọc dữ liệu
            cb_nganh.DataSource = dv;
            cb_nganh.DisplayMember = "tenchuyennganh";
        }
        public void TaiDuLieuSinhVien()
        {
            DataTable dt = db.list_sinhvien();

            DataView dv = new DataView(dt);
            dv.RowFilter = "is_conhoc = " + local_is_conhoc; // Lọc dữ liệu

            Luoi_SV.DataSource = dv; // Gán DataView cho DataGridView
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem các ô thông tin bắt buộc đã được nhập đầy đủ chưa
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(cb_nganh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            try
            {

                string email = txtEmail.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();
                string gioitinh = cbGioiTinh.Text.Trim();
                string cccd = txtCCCD.Text.Trim();
                string khoahoc = txtKhoaHoc.Text.Trim();
                DateTime ngaysinh = dateNgaySinh.Value;
                string hoten = txtHoTen.Text.Trim();
                string tenchuyennganh = cb_nganh.Text.Trim();
                string msv = txtMaSV.Text.Trim();
                string sdt = txtSDT.Text.Trim();


                if (!Regex.IsMatch(sdt, @"^0\d{9,10}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải bắt đầu bằng '0' và có từ 10 đến 11 số.");
                    return;
                }
                if (!email.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Email phải kết thúc bằng '@gmail.com'.");
                    return;
                }

                // Kiểm tra tuổi (phải đủ 18 tuổi)
                int currentYear = DateTime.Now.Year;
                int birthYear = ngaysinh.Year;
                if ((currentYear - birthYear) < 18)
                {
                    MessageBox.Show("Năm sinh không hợp lệ. Sinh viên phải đủ 18 tuổi.");
                    return;
                }
                if (cb_nganh.SelectedIndex == -1)
                {
                    chuyennganh_Model cn = new chuyennganh_Model(0, tenchuyennganh, false);
                    string success1 = db.them_chuyennganh(cn);
                    if (!success1.Equals("success"))
                    {
                        MessageBox.Show(success1);
                        return;
                    }
                }
                int id_chuyennganh = db.get_id_chuyenganh_by_name(tenchuyennganh.ToString());
                sinhvien_Model sv = new sinhvien_Model(0, id_chuyennganh, ngaysinh, email, diachi, gioitinh, cccd, khoahoc, hoten, msv, sdt, true);
                string success2 = db.them_sinhvien(sv);
                if (!success2.Equals("success"))
                {
                    MessageBox.Show(success2);
                    return;
                }
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi btn them: " + ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Luoi_SV.SelectedRows)
            {
                string hoten = txtHoTen.Text;
                string email = txtEmail.Text;
                string diachi = txtDiaChi.Text;
                string khoahoc = txtKhoaHoc.Text;
                string msv = txtMaSV.Text;
                string sdt = txtSDT.Text;
                string cccd = txtCCCD.Text;
                string tenchuyennganh = cb_nganh.Text;
                string gioitinh = cbGioiTinh.Text;
                DateTime ngaysinh = dateNgaySinh.Value;

                int id_sv = (int)row.Cells["id_sv"].Value;
                int id_chuyennganh = db.get_id_chuyenganh_by_name(tenchuyennganh);
                sinhvien_Model sv = new sinhvien_Model(id_sv, id_chuyennganh, ngaysinh, email, diachi, gioitinh, cccd, khoahoc, hoten, msv, sdt, true);
                string success = db.sua_sinhvien(sv);
                if (success.Equals("success"))
                {
                    MessageBox.Show("Sửa thành công");
                    reset();
                }
                else
                {
                    MessageBox.Show(success);
                }
            }
            
        }

        private void Luoi_SV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in Luoi_SV.SelectedRows)
            {
                txtHoTen.Text = row.Cells["hoten"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtDiaChi.Text = row.Cells["diachi"].Value.ToString();
                txtKhoaHoc.Text = row.Cells["khoahoc"].Value.ToString();
                txtMaSV.Text = row.Cells["msv"].Value.ToString();
                txtSDT.Text = row.Cells["sdt"].Value.ToString();
                txtCCCD.Text = row.Cells["cccd"].Value.ToString();
                cb_nganh.Text = row.Cells["tenchuyennganh"].Value.ToString();
                cbGioiTinh.Text = row.Cells["gioitinh"].Value.ToString();
                dateNgaySinh.Value = (DateTime)row.Cells["ngaysinh"].Value;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa các sinh viên đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in Luoi_SV.SelectedRows)
                    {

                        int id_sv = (int)row.Cells["id_sv"].Value;
                        string success = db.xoa_sinhvien(id_sv);

                        if (!success.Equals("success"))

                        {
                            MessageBox.Show($"Lỗi khi xóa sinh viên có mã sinh viên {id_sv}: {success}");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thành công");
                            reset();
                        }
                    }
                }
           }

        private void btn_khoiphuc_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Luoi_SV.SelectedRows)
            {

                int id_sv = (int)row.Cells["id_sv"].Value;
                string success = db.khoiphuc_sinhvien(id_sv);
                if (success.Equals("success"))
                {
                    MessageBox.Show("Khôi phục thành công");
                    reset();
                }
                else
                {
                    MessageBox.Show(success);
                }
            }
        }

        private void tbtn_conhoc_CheckedChanged(object sender, EventArgs e)
        {
            local_is_conhoc = 1;
            reset();
            
        }

        private void tbtn_bohoc_CheckedChanged(object sender, EventArgs e)
        {
            local_is_conhoc = 0;
            reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thongkelop_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có dòng nào được chọn
                if (Luoi_SV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giá trị từ các cột của dòng được chọn
                int id_sv = int.Parse(Luoi_SV.SelectedRows[0].Cells["id_sv"].Value.ToString());
                string name_sv = Luoi_SV.SelectedRows[0].Cells["hoten"].Value.ToString();

                // Tạo form mới với dữ liệu đã lấy
                Form formThongKe = new form_lklophoc_by_sinhvien(id_sv, name_sv);
                formThongKe.Show();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Không tìm thấy dữ liệu trong ô được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thongkemon_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có dòng nào được chọn
                if (Luoi_SV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giá trị từ các cột của dòng được chọn
                int id_sv = int.Parse(Luoi_SV.SelectedRows[0].Cells["id_sv"].Value.ToString());
                string name_sv = Luoi_SV.SelectedRows[0].Cells["hoten"].Value.ToString();

                // Tạo form mới với dữ liệu đã lấy
                Form formThongKe = new form_lkmonhoc_by_sinhvien(id_sv, name_sv);
                formThongKe.Show();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Không tìm thấy dữ liệu trong ô được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
