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
        List<int> arr_sua = new List<int>();
        List<int> arr_xoa = new List<int>();
        public Form3()
        {
            InitializeComponent();
        }
        public void reset()
        {
            txtTenDauDiem.Text = string.Empty;
            txtTyLe.Text = string.Empty;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbIDMonHoc.SelectedValue == null || string.IsNullOrEmpty(txtTenDauDiem.Text) || string.IsNullOrEmpty(txtTyLe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }


            DataTable dt;
            if (Luoi_DauDiem.DataSource == null)
            {
                dt = new DataTable();
                dt.Columns.Add("id_daudiem", typeof(Int32));
                dt.Columns.Add("id_monhoc", typeof(Int32));
                dt.Columns.Add("tendaudiem", typeof(string));
                dt.Columns.Add("tyle", typeof(decimal));
                Luoi_DauDiem.DataSource = dt;
            }
            else
            {
                dt = (DataTable)Luoi_DauDiem.DataSource;
            }
            DataRow dr = dt.NewRow();
            dr = dt.NewRow();
            dr["id_monhoc"] = cbIDMonHoc.SelectedValue.ToString();
            dr["tendaudiem"] = txtTenDauDiem.Text;

            decimal tyLe;
            if (decimal.TryParse(txtTyLe.Text, out tyLe))
            {
                dr["tyle"] = tyLe;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tỷ lệ đúng định dạng số thập phân (ví dụ: 1,2 hoặc 0,5).");
                return; 
            }

            decimal tong = decimal.Parse(txtTyLe.Text);
            foreach (DataGridViewRow row in Luoi_DauDiem.Rows)
            {
                if (row.Cells["tyle"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["tyle"].Value.ToString(), out decimal giaTri))
                    {
                        tong += giaTri;
                    }
                }
            }

            if(tong > 1)
            {
                MessageBox.Show("Tổng giá trị tỷ lệ đã lớn hơn 1, Vui lòng nhập lại !!!");
                return;
            }

            dt.Rows.Add(dr);

            Luoi_DauDiem.DataSource = dt;
            Luoi_DauDiem.Refresh();
            MessageBox.Show("Thêm thành công!");
            reset();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            cbIDMonHoc.DataSource = db.LayDLMon();
            cbIDMonHoc.DisplayMember = "tenmonhoc";
            cbIDMonHoc.ValueMember = "id_monhoc";
            cbIDMonHoc.Text = "";

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
                if (selectedRow.Cells["id_daudiem"].Value.ToString() != "")
                {
                    arr_sua.Add((int)selectedRow.Cells["id_daudiem"].Value);
                }
                decimal tong = decimal.Parse(txtTyLe.Text);

                foreach (DataGridViewRow row in Luoi_DauDiem.Rows)
                {
                    if (row != Luoi_DauDiem.SelectedRows[0])
                    {
                        if (decimal.TryParse(row.Cells["tyle"].Value.ToString(), out decimal giaTri))
                        {
                            tong += giaTri;
                        }
                    }
                }

                if (tong > 1)
                {
                    MessageBox.Show("Tổng giá trị tỷ lệ đã lớn hơn 1, Vui lòng nhập lại !!!");
                    return;
                }
                selectedRow.Cells[2].Value = txtTenDauDiem.Text;
                selectedRow.Cells[3].Value = txtTyLe.Text;

                Luoi_DauDiem.Refresh();
                MessageBox.Show("Sủa thành công");
                reset();
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
                DataGridViewRow selectedRow = Luoi_DauDiem.SelectedRows[0];
                int id_daudiem;

                if (int.TryParse(selectedRow.Cells["id_daudiem"].Value?.ToString(), out id_daudiem))
                {
                    arr_sua.Remove(id_daudiem);
                    arr_xoa.Add(id_daudiem);
                }
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

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in Luoi_DauDiem.Rows)
            {
                if (decimal.TryParse(row.Cells["tyle"].Value.ToString(), out decimal giaTri))
                {
                   tong += giaTri;
                }
            }

            if (tong != 1)
            {
                MessageBox.Show("Tổng giá trị tỷ lệ chưa bằng 1, Vui lòng chỉnh sửa lại !!!");
                return;
            }
            foreach (DataGridViewRow row in Luoi_DauDiem.Rows)
            {
                int id_monhoc;
                int.TryParse(cbIDMonHoc.SelectedValue.ToString(), out id_monhoc);
                string tendaudiem = row.Cells["tendaudiem"].Value.ToString();
                decimal tyle = decimal.Parse(row.Cells["tyle"].Value.ToString());
                int id_daudiem;
                if (int.TryParse(row.Cells["id_daudiem"].Value?.ToString(), out id_daudiem))
                {                    
                    //sua
                    if (arr_sua.Contains(id_daudiem))
                    {
                        daudiem_Model daudiem = new daudiem_Model(id_daudiem, id_monhoc, tendaudiem, tyle);
                        db.sua_daudiem(daudiem);
                    }
                   
                }
                else
                {
                    //them
                    daudiem_Model daudiem = new daudiem_Model(0, id_monhoc, tendaudiem, tyle);
                    db.them_daudiem(daudiem);

                }
            }
            //xoa
            foreach(int id_daudiem in arr_xoa)
            {
                db.xoa_daudiem(id_daudiem);
            }
            MessageBox.Show("Cập nhật thành công");
            arr_xoa.Clear();
            arr_sua.Clear();
            Form3_Load(sender, e);
            cbIDMonHoc_SelectedIndexChanged(sender, e);
        }

        private void cbIDMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_monhoc;
            if (int.TryParse(cbIDMonHoc.SelectedValue.ToString(), out id_monhoc))
            {
                Luoi_DauDiem.DataSource = db.search_daudiem_by_id_monhoc(id_monhoc);
            }
        }

        private void Luoi_DauDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Luoi_DauDiem.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Luoi_DauDiem.SelectedRows[0];

                txtTenDauDiem.Text = selectedRow.Cells["tendaudiem"].Value.ToString();
                txtTyLe.Text = selectedRow.Cells["tyle"].Value.ToString();
            }
        }
    }
}
