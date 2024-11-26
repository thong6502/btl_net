using btl_net.Controller;
using btl_net.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace btl_net.View
{
    public partial class form_loaimonhoc : Form
    {
        private Dbconnect db = new Dbconnect();
        private int localIsChuaxoa = 0;

        public form_loaimonhoc()
        {
            InitializeComponent();
            ResetForm();
        }

        private void ResetForm()
        {
            txtloaimh.Clear();

            if (localIsChuaxoa == 0)
            {
                EnableButtons(true, true, true, false);
            }
            else
            {
                EnableButtons(false, false, false, true);
            }

            LoadLoaiMonHocData();
        }

        private void EnableButtons(bool them, bool sua, bool xoa, bool capnhat)
        {
            btnthem.Enabled = them;
            btnsua.Enabled = sua;
            btnxoa.Enabled = xoa;
            btncapnhat.Enabled = capnhat;
        }

        private void LoadLoaiMonHocData()
        {
            try
            {
                DataTable dt = db.list_loaimonhocth();
                if (dt != null)
                {
                    DataView dv = new DataView(dt)
                    {
                        RowFilter = $"is_xoa = {localIsChuaxoa}" // Lọc dữ liệu
                    };
                    dgv_Loai.DataSource = dv; // Gán DataView cho DataGridView
                }
                else
                {
                    MessageBox.Show("Không thể tải dữ liệu từ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtloaimh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loaiMH = txtloaimh.Text.Trim();
            phanloaimonhoc_Model monHoc = new phanloaimonhoc_Model(0, loaiMH, true);

            try
            {
                db.ThemPhanLoaiMonHoc(monHoc);
                MessageBox.Show("Thêm phân loại môn học thành công.", "Thông báo");
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm phân loại môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgv_Loai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phân loại để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtloaimh.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phân loại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgv_Loai.SelectedRows)
            {
                int idMonHoc = (int)row.Cells[0].Value;
                string loaiMH = txtloaimh.Text.Trim();
                phanloaimonhoc_Model plMonHoc = new phanloaimonhoc_Model(idMonHoc, loaiMH, true);

                try
                {
                    db.SuaPhanLoaiMonHoc(plMonHoc);
                    MessageBox.Show("Sửa thành công.", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi sửa phân loại môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ResetForm();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgv_Loai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phân loại để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phân loại này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv_Loai.SelectedRows)
                {
                    int id = (int)row.Cells[0].Value;

                    try
                    {
                        db.XoaPhanLoaiMonHoc(id);
                        MessageBox.Show("Xóa thành công.", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa phân loại môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            ResetForm();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_Loai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phân loại để khôi phục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgv_Loai.SelectedRows)
            {
                int id = (int)row.Cells[0].Value;

                try
                {
                    db.KhoiPhucPhanLoaiMonHoc(id);
                    MessageBox.Show("Khôi phục thành công.", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi khôi phục phân loại môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ResetForm();
        }

        private void dgv_Loai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dgv_Loai.Rows[e.RowIndex];
                txtloaimh.Text = row.Cells[1].Value.ToString();
                    
            }    
           
         
        }

        private void radaxoa_CheckedChanged(object sender, EventArgs e)
        {
            localIsChuaxoa = 1;
            ResetForm();
        }

        private void rachuaxoa_CheckedChanged(object sender, EventArgs e)
        {
            localIsChuaxoa = 0;
            ResetForm();
        }
        private void FormQLMH_Load(object sender, EventArgs e)
        {
            
            rachuaxoa.Checked = true;
            
        }
    }
}
