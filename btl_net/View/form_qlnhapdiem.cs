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
    public partial class form_qlnhapdiem : Form
    {
        Dbconnect db = new Dbconnect();
        public form_qlnhapdiem()
        {
            InitializeComponent();
            LoadLopHoc();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadLopHoc()
        {
            try
            {
                DataTable dtLopHoc = db.list_cblophoc();
                cbTenLopHoc.DataSource = dtLopHoc;
                cbTenLopHoc.DisplayMember = "display_name"; // Tên lớp học hiển thị
                cbTenLopHoc.ValueMember = "id_lophoc";     // Giá trị của ComboBox là id_lophoc
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp học: " + ex.Message);
            }



        }

        private void cbTenLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenLopHoc.SelectedValue is int idLopHoc)
            {
                DataTable dtSinhVien = db.list_sinhvien_by_lophoc(idLopHoc);

                // Lấy danh sách đủ điểm từ cơ sở dữ liệu
                DataTable dtDuDiem = db.GetSinhVienDuDiem(idLopHoc);

                // Nếu chưa có cột "DuDiem", thêm vào DataTable
                if (!dtSinhVien.Columns.Contains("DuDiem"))
                {
                    dtSinhVien.Columns.Add("DuDiem", typeof(bool)); // Thêm cột "DuDiem" kiểu bool
                }

                // Lặp qua từng sinh viên trong danh sách và cập nhật cột "DuDiem"
                foreach (DataRow sinhVienRow in dtSinhVien.Rows)
                {
                    // Tìm sinh viên trong dtDuDiem bằng id_sv
                    DataRow[] rows = dtDuDiem.Select($"id_sv = {sinhVienRow["id_sv"]}");
                    if (rows.Length > 0)
                    {
                        // Gán giá trị "DuDiem" (true/false) từ dtDuDiem vào dtSinhVien
                        sinhVienRow["DuDiem"] = Convert.ToBoolean(rows[0]["DuDiem"]);
                    }
                    else
                    {
                        sinhVienRow["DuDiem"] = false; // Mặc định nếu không có thông tin
                    }
                }

                // Gán lại DataTable cho DataGridView
                Luoi_DSSV.DataSource = dtSinhVien;

                // Kiểm tra nếu cột "DuDiem" đã tồn tại, xóa cột đó trước
                if (Luoi_DSSV.Columns["DuDiem"] != null)
                {
                    Luoi_DSSV.Columns.Remove("DuDiem");
                }

                // Thêm cột checkbox "DuDiem" vào DataGridView
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "DuDiem",
                    HeaderText = "Đủ điểm",
                    DataPropertyName = "DuDiem", // Gắn với cột "DuDiem" trong DataTable
                    TrueValue = true,   // Giá trị nếu checkbox được tích
                    FalseValue = false, // Giá trị nếu checkbox không tích
                    ReadOnly = true     // Chỉ hiển thị, không cho phép chỉnh sửa
                };
                Luoi_DSSV.Columns.Add(checkColumn);

                // Cập nhật thông tin số sinh viên hiện có và tối đa
                int currentCount, maxCount;
                db.GetStudentCountInfo(idLopHoc, out currentCount, out maxCount);
                lblTongSoSV.Text = $"Danh sách sinh viên: {currentCount}/{maxCount}";

            }
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn hàng nào chưa
            if (Luoi_DSSV.SelectedRows.Count > 0)
            {
                // Lấy giá trị id_lophoc và id_sv từ hàng được chọn
                int id_lophoc = Convert.ToInt32(Luoi_DSSV.SelectedRows[0].Cells["id_lophoc"].Value);
                int id_sv = Convert.ToInt32(Luoi_DSSV.SelectedRows[0].Cells["id_sv"].Value);

                // Mở form Nhập điểm và truyền giá trị sang
                form_luudiem frmNhapDiem = new form_luudiem(id_lophoc, id_sv);
                frmNhapDiem.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
