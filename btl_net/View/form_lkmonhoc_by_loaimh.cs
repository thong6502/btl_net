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
    public partial class form_lkmonhoc_by_loaimh : Form
    {
        Dbconnect db = new Dbconnect();
        int id_phanloai;
        string tenloai;
        public form_lkmonhoc_by_loaimh(int id_phanloai, string tenloai)
        {
            this.id_phanloai = id_phanloai;
            this.tenloai = tenloai;
            InitializeComponent();
            init();
        }
        private void init()
        {
            txt_head.Text = $"DANH SÁCH CÁC MÔN HỌC CỦA LOẠI '{tenloai.ToUpper()}'";
            DataTable dt = db.list_monhoc_by_idloai(this.id_phanloai) ;
            DataView dv = new DataView(dt) ;
            dv.RowFilter = "is_xoa = 0";
            dgv_monhoc_by_loai.DataSource = dv ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
