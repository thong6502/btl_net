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
    public partial class form_lkmonhoc_by_sinhvien : Form
    {

        Dbconnect db = new Dbconnect();
        private int global_danghoc = 0;
        private int id_sv;
        private string name_sv;
        public form_lkmonhoc_by_sinhvien(int id_sv, string name_sv)
        {
            InitializeComponent();
            this.id_sv = id_sv;
            this.name_sv = name_sv;
            init();
        }
        private void init()
        {
            txt_head.Text = $"DANH SÁCH MÔN HỌC CỦA SINH VIÊN '{name_sv.ToUpper()}'";
            DataTable dt = db.list_monhoc_by_idsv(id_sv);
            DataView dv = new DataView(dt);
            if (global_danghoc == 0)
            {
                dv.RowFilter = "is_xoa = 0 AND xeplichthi = 0";
            }
            else
            {
                dv.RowFilter = "is_xoa = 0 AND xeplichthi <> 0";
            }
            dgv_monhoc_by_idsv.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            global_danghoc = 0;
            init();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            global_danghoc = 1;
            init();
        }
    }
}
