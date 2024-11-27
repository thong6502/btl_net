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
    public partial class form_lklophoc_by_sinhvien : Form
    {
        private int id_sv;
        private string name_sv;
        Dbconnect db = new Dbconnect();
        public form_lklophoc_by_sinhvien(int id_sv, string name_sv)
        {
            this.id_sv = id_sv;
            this.name_sv = name_sv;
            InitializeComponent();

            init();
        }
        private void init()
        {
            txt_head.Text = $"DANH SÁCH LỚP HỌC CỦA SINH VIÊN '{name_sv.ToUpper()}'";
            DataTable dt = db.list_lophoc_by_idsinhvien(id_sv);
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = 0";
            dgv_lophoc_by_idsv.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
