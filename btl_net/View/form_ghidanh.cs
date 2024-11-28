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
    public partial class form_ghidanh : Form
    {
        Dbconnect db = new Dbconnect();
        private DataTable fullData;
        public form_ghidanh()
        {
            InitializeComponent();
        }

        private void Luoi_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void load_data_cb()
        {
            cbTenSV.DataSource = db.list_cbsinhvien();
            cbTenSV.DisplayMember = "display_name";
            cbTenSV.ValueMember = "id_sv";

            fullData = db.list_cblophoc();
            cbTenLopHoc.DataSource = fullData;
            cbTenLopHoc.DisplayMember = "display_name";
            cbTenLopHoc.ValueMember = "id_lophoc";

            
        }

        private void form_ghidanh_Load(object sender, EventArgs e)
        {
            load_data_cb();
            btnKhoiPhuc.Enabled = false;
            TaiDuLieuGhiDanhTheoLop(false);
            reset();
            cbTenLopHoc.DropDownStyle = ComboBoxStyle.DropDown;

            cbTenLopHoc.KeyUp += cbTenLopHoc_KeyUp;
        }
         void vohieuhoa(bool gt)
        {
            cbTenLopHoc.Enabled = gt;
            cbTenSV.Enabled = gt;
            txtSoBuoiNghi.Enabled = gt;
            txtXepLichThi.Enabled = gt;
        }

        void reset()
        {

            cbTenSV.SelectedIndex=-1;
            txtSoBuoiNghi.Text = string.Empty;
            txtXepLichThi.Text = string.Empty;
        }

        private void TaiDuLieuGhiDanhTheoLop(bool is_xoa)
        {
            if (cbTenLopHoc.SelectedValue is int idLopHoc)
            {

                DataTable dt = db.list_ghidanh1(idLopHoc, is_xoa);
                Luoi_DSGD.DataSource = dt;

                int currentCount, maxCount;
                db.GetStudentCountInfo(idLopHoc, out currentCount, out maxCount);
                lblTongSoSinhVien.Text = $"Danh sách sinh viên: {currentCount}/{maxCount}";

            }
        }
        private void tbtn_GhiDanhHienCo_CheckedChanged(object sender, EventArgs e)
        {
            if (tbtn_GhiDanhHienCo.Checked)
            {
                TaiDuLieuGhiDanhTheoLop(false); 
                vohieuhoa(true); 
                btnKhoiPhuc.Enabled = false; 
            }
        }

        private void tbtn_GhiDanhDaXoa_CheckedChanged(object sender, EventArgs e)
        {
            if (tbtn_GhiDanhDaXoa.Checked)
            {
                TaiDuLieuGhiDanhTheoLop(true); 
                vohieuhoa(false); 
                cbTenLopHoc.Enabled = true;
                btnKhoiPhuc.Enabled = true; 
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbTenSV.Text) ||
                string.IsNullOrEmpty(cbTenLopHoc.Text) ||
                string.IsNullOrEmpty(txtSoBuoiNghi.Text) ||
                string.IsNullOrEmpty(txtXepLichThi.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.");
                return;
            }

            int id_sv = Convert.ToInt32(cbTenSV.SelectedValue);
            int id_lophoc = Convert.ToInt32(cbTenLopHoc.SelectedValue);
            int sobuoinghi = Convert.ToInt32(txtSoBuoiNghi.Text);
            int xeplichthi = Convert.ToInt32(txtXepLichThi.Text);

            int currentCount, maxCount;
            db.GetStudentCountInfo(id_lophoc, out currentCount, out maxCount);
            if (currentCount >= maxCount)
            {
                MessageBox.Show($"Không thể thêm sinh viên vào lớp này vì số sinh viên đã đạt tối đa ({maxCount}).");
                return;
            }

            if (db.Ktratontaisv(id_sv, id_lophoc))
            {
                MessageBox.Show("Sinh viên này đã tồn tại trong lớp học này.");
                return;
            }
            ghidanh_Model ghidanh = new ghidanh_Model(0, id_sv, id_lophoc, sobuoinghi, xeplichthi, false);
            db.them_ghidanh(ghidanh);
            TaiDuLieuGhiDanhTheoLop(false);

            MessageBox.Show("Thêm ghi danh thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Luoi_DSGD.CurrentRow == null ||
                string.IsNullOrEmpty(cbTenLopHoc.Text) ||
                string.IsNullOrEmpty(cbTenSV.Text) ||
                string.IsNullOrEmpty(txtSoBuoiNghi.Text) ||
                string.IsNullOrEmpty(txtXepLichThi.Text))
            {
                MessageBox.Show("Vui lòng chọn ghi danh cần sửa.");
                return;
            }

            int id_ghidanh = (int)Luoi_DSGD.CurrentRow.Cells["id_ghidanh"].Value;
            int id_sv = Convert.ToInt32(cbTenSV.SelectedValue);
            int id_lophoc = Convert.ToInt32(cbTenLopHoc.SelectedValue);
            int sobuoinghi = Convert.ToInt32(txtSoBuoiNghi.Text);
            int xeplichthi = Convert.ToInt32(txtXepLichThi.Text);

            ghidanh_Model ghidanh = new ghidanh_Model(id_ghidanh, id_sv, id_lophoc, sobuoinghi, xeplichthi, false);
            db.sua_ghidanh(ghidanh);
            TaiDuLieuGhiDanhTheoLop(false);
            MessageBox.Show("Sửa ghi danh thành công.");
        }

        private void Luoi_DSGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in Luoi_DSGD.SelectedRows)
            {

                string tenLopHoc = row.Cells["tenlop"].Value.ToString();
                string tenHocKy = row.Cells["kyhoc"].Value.ToString(); 
                string tenMon = row.Cells["tenmonhoc"].Value.ToString(); 

                cbTenLopHoc.Text = $"{tenLopHoc} - {tenHocKy} - {tenMon}";

                string msv = row.Cells["msv"].Value.ToString();
                string hoTenSV = row.Cells["hoten"].Value.ToString(); 
                cbTenSV.Text = $"{msv} - {hoTenSV}";

                txtSoBuoiNghi.Text = row.Cells["sobuoinghi"].Value.ToString();
                txtXepLichThi.Text = row.Cells["xeplichthi"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Luoi_DSGD.CurrentRow == null ||
                string.IsNullOrEmpty(cbTenLopHoc.Text) ||
                string.IsNullOrEmpty(cbTenSV.Text) ||
                string.IsNullOrEmpty(txtSoBuoiNghi.Text) ||
                string.IsNullOrEmpty(txtXepLichThi.Text))
            {
                MessageBox.Show("Vui lòng chọn ghi danh cần xóa.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ghi danh này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id_ghidanh = (int)Luoi_DSGD.CurrentRow.Cells["id_ghidanh"].Value;
                db.xoa_ghidanh(id_ghidanh);
                TaiDuLieuGhiDanhTheoLop(false);
                MessageBox.Show("Xóa ghi danh thành công.");
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
            if (Luoi_DSGD.CurrentRow == null ||
                string.IsNullOrEmpty(cbTenLopHoc.Text) ||
                string.IsNullOrEmpty(cbTenSV.Text) ||
                string.IsNullOrEmpty(txtSoBuoiNghi.Text) ||
                string.IsNullOrEmpty(txtXepLichThi.Text))
            {
                MessageBox.Show("Vui lòng chọn ghi danh cần khôi phục.");
                return;
            }

            int id_ghidanh = (int)Luoi_DSGD.CurrentRow.Cells["id_ghidanh"].Value;
            int id_lophoc = Convert.ToInt32(cbTenLopHoc.SelectedValue);

            int currentCount, maxCount;
            db.GetStudentCountInfo(id_lophoc, out currentCount, out maxCount);

            if (currentCount >= maxCount)
            {
                MessageBox.Show($"Không thể khôi phục sinh viên vào lớp này vì số sinh viên đã đạt tối đa ({maxCount}).");
                return;
            }

            // Thực hiện khôi phục ghi danh
            db.khoi_phuc_ghidanh(id_ghidanh);
            TaiDuLieuGhiDanhTheoLop(true);
            MessageBox.Show("Khôi phục ghi danh thành công.");
        }

        private void cbTenLopHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTenLopHoc_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = cbTenLopHoc.Text?.ToLower() ?? "";

            var filteredRows = fullData.AsEnumerable()
                .Where(row => row["display_name"].ToString().ToLower().Contains(searchText))
                .ToList();

            if (filteredRows.Any())
            {
                cbTenLopHoc.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                cbTenLopHoc.DataSource = fullData.Clone();
            }

            cbTenLopHoc.DisplayMember = "display_name";
            cbTenLopHoc.ValueMember = "id_lophoc";

            cbTenLopHoc.DroppedDown = true;
            cbTenLopHoc.Text = searchText;
            cbTenLopHoc.SelectionStart = searchText.Length;
        }

        private void cbTenLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbtn_GhiDanhHienCo.Checked)
                TaiDuLieuGhiDanhTheoLop(false);
            else if (tbtn_GhiDanhDaXoa.Checked)
                TaiDuLieuGhiDanhTheoLop(true);


        }
    }
}
