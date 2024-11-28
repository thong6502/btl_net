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
    public partial class Form6 : Form
    {
        Dbconnect db = new Dbconnect();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadLopHoc();
            TaiDuLieuDiem();
        }
        private void LoadLopHoc()
        {
            try
            {
                DataTable dtLopHoc = db.list_cblophoc();
                cbTenLopHoc.DataSource = dtLopHoc;
                cbTenLopHoc.DisplayMember = "display_name";
                cbTenLopHoc.ValueMember = "id_lophoc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        // Tải danh sách sinh viên theo lớp học
        //private void LoadSinhVien(int idLopHoc)
        //{
        //    try
        //    {
        //        //DataTable dtSinhVien = db.list_sinhvien_by_lophoc(idLopHoc);
        //        cbMSV.DataSource = dtSinhVien;
        //        cbMSV.DisplayMember = "display_name";
        //        cbMSV.ValueMember = "id_sv";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //}

        // Tải danh sách đầu điểm theo lớp học
        private void LoadDauDiem(int idLopHoc)
        {
            try
            {
                DataTable dtDauDiem = db.list_daudiem_by_lophoc(idLopHoc);
                cbTenDauDiem.DataSource = dtDauDiem;
                cbTenDauDiem.DisplayMember = "tendaudiem";
                cbTenDauDiem.ValueMember = "id_daudiem";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void TaiDuLieuDiem()
        {
            DataTable dt = db.list_diem();
            Luoi_DSD.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {          
            int idSinhVien = Convert.ToInt32(cbMSV.SelectedValue);
            int idDauDiem = Convert.ToInt32(cbTenDauDiem.SelectedValue);
            float diem = float.Parse(txtDiem.Text);

            diem_Model d = new diem_Model(0, idDauDiem, idSinhVien, diem, false);
            db.them_diem(d);
            TaiDuLieuDiem();
            MessageBox.Show("Thêm điểm thành công");
        }

        private void cbTenLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenLopHoc.SelectedValue is int idLopHoc)
            {
                //LoadSinhVien(idLopHoc);
                LoadDauDiem(idLopHoc);
            }
        }
    }
}
