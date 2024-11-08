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
    public partial class Form3 : Form
    {
        Dbconnect db = new Dbconnect();
        public Form3()
        {
            InitializeComponent();
        }
        private void TaiDuLieuDauDiem()
        {
            DataTable dt = db.TraDSDiem();
            Luoi_DauDiem.DataSource = dt;
        }
        int i = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbIDMonHoc.SelectedValue == null || string.IsNullOrEmpty(txtTenDauDiem.Text) || string.IsNullOrEmpty(txtTyLe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }


            DataTable dt = (DataTable)Luoi_DauDiem.DataSource;
            DataRow dr = dt.NewRow();

            dr[0] = ++i;
            dr[1] = cbIDMonHoc.SelectedValue.ToString();
            dr[2] = txtTenDauDiem.Text;
            dr[3] = txtTyLe.Text;  // Sử dụng biến số thực đã được kiểm tra

            dt.Rows.Add(dr);

            // Cập nhật DataTable vào DataGridView
            Luoi_DauDiem.DataSource = dt;
            Luoi_DauDiem.Refresh();
        }

        private void Luoi_DauDiem_SelectionChanged(object sender, EventArgs e)
        {
            if (Luoi_DauDiem.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Luoi_DauDiem.SelectedRows[0];

                // Gán giá trị từ hàng đã chọn vào các TextBox
                txtTenDauDiem.Text = selectedRow.Cells[2].Value.ToString();
                txtTyLe.Text = selectedRow.Cells[3].Value.ToString();
                cbIDMonHoc.SelectedValue = selectedRow.Cells[1].Value.ToString();
            }
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            TaiDuLieuDauDiem();
            cbIDMonHoc.DataSource = db.LayDLMon();
            cbIDMonHoc.DisplayMember = "tenmonhoc";
            cbIDMonHoc.ValueMember = "id_monhoc";
            Luoi_DauDiem.SelectionChanged += Luoi_DauDiem_SelectionChanged;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Luoi_DauDiem.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Luoi_DauDiem.SelectedRows[0];

                selectedRow.Cells[1].Value = cbIDMonHoc.SelectedValue.ToString();
                selectedRow.Cells[2].Value = txtTenDauDiem.Text;
                selectedRow.Cells[3].Value = txtTyLe.Text;

                Luoi_DauDiem.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Luoi_DauDiem.SelectedRows.Count > 0)
            {
                DataTable dt = (DataTable)Luoi_DauDiem.DataSource;
                foreach (DataGridViewRow row in Luoi_DauDiem.SelectedRows)
                {
                    dt.Rows.RemoveAt(row.Index);
                }

                Luoi_DauDiem.DataSource = dt;
                Luoi_DauDiem.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }

    }
}
