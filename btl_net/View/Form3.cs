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
            DataTable dt = db.list_daudiem();
            Luoi_DauDiem.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIDMonHoc.Text) || string.IsNullOrEmpty(txtTenDauDiem.Text) || string.IsNullOrEmpty(txtTyLe.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                int id_monhoc = int.Parse(txtIDMonHoc.Text);
                string tendaudiem = txtTenDauDiem.Text;
                float tyle;

                if (!float.TryParse(txtTyLe.Text, out tyle))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho tỷ lệ.");
                    return;
                }

                Dbconnect db = new Dbconnect();
                if (!db.KiemTraTonTaiMonHoc(id_monhoc))
                {
                    MessageBox.Show("ID môn học không tồn tại.");
                    return;
                }

                daudiem_Model daudiem = new daudiem_Model(0, id_monhoc, tendaudiem, tyle);

                db.them_daudiem(daudiem);
                TaiDuLieuDauDiem();
                MessageBox.Show("Thêm đầu điểm thành công.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng dữ liệu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TaiDuLieuDauDiem();
        }
    }
}
