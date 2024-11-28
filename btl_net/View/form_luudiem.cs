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
    public partial class form_luudiem : Form
    {
        Dbconnect db = new Dbconnect();
        private int _idLopHoc;
        private int _idSv;
        public form_luudiem(int idLopHoc, int idSv)
        {
            InitializeComponent();
            _idLopHoc = idLopHoc;
            _idSv = idSv;
            LoadFormData();
        }
        private void LoadFormData()
        {

           
            // Lấy thông tin lớp học
            DataTable lopHocData = db.GetLopHoc();
            DataRow lopHocRow = lopHocData.Select($"id_lophoc = {_idLopHoc}").FirstOrDefault();
            if (lopHocRow != null)
            {
                txtLopHoc.Text = lopHocRow["display_name"].ToString();
            }

            // Lấy thông tin sinh viên
            DataTable sinhVienData = db.GetSinhVien();
            DataRow sinhVienRow = sinhVienData.Select($"id_sv = {_idSv}").FirstOrDefault();
            if (sinhVienRow != null)
            {
                txtMSV.Text = sinhVienRow["display_name"].ToString();
            }

            // Hiển thị bảng điểm của sinh viên
            Luoi_DSD.DataSource = db.GetDiem(_idSv, _idLopHoc);

            // Cập nhật ComboBox đầu điểm
            cbTenDauDiem.DataSource = db.GetDauDiem(_idLopHoc);
            cbTenDauDiem.DisplayMember = "tendaudiem";
            cbTenDauDiem.ValueMember = "id_daudiem";
        }
        private void TaiDuLieuDiem()
        {
            Luoi_DSD.DataSource = db.GetDiem(_idSv, _idLopHoc);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int idSinhVien = _idSv; 
                int idDauDiem = Convert.ToInt32(cbTenDauDiem.SelectedValue);
                float diem = float.Parse(txtDiem.Text);

                if (db.KiemTraTonTaiDiem(idSinhVien, idDauDiem))
                {
                    MessageBox.Show("Sinh viên này đã có điểm cho đầu điểm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                diem_Model d = new diem_Model(0, idDauDiem, idSinhVien, diem, false);
                db.them_diem(d);
                TaiDuLieuDiem();
                MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int idSinhVien = _idSv; 
                int idDauDiem = Convert.ToInt32(cbTenDauDiem.SelectedValue);
                float diem = float.Parse(txtDiem.Text);
                int idDiem = Convert.ToInt32(Luoi_DSD.SelectedRows[0].Cells["id_diem"].Value);

                if (db.KiemTraTonTaiDiemSua(idSinhVien, idDauDiem, idDiem))
                {
                    MessageBox.Show("Sinh viên này đã có điểm cho đầu điểm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                diem_Model d = new diem_Model(idDiem, idDauDiem, idSinhVien, diem, false);
                db.sua_diem(d);
                TaiDuLieuDiem();

                MessageBox.Show("Sửa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Luoi_DSD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in Luoi_DSD.SelectedRows)
            {
                txtDiem.Text = row.Cells["diem"].Value.ToString();
                cbTenDauDiem.Text = row.Cells["tendaudiem"].Value.ToString();
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
