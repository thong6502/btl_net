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
    public partial class form_thongke : Form
    {
        Dbconnect db = new Dbconnect();
        int global_is_pass = 1;
        int dk_truot = -1;
        public form_thongke()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            load_cbtenlophoc();
            load_cbkyhoc();
            load_cbmonhoc();
            load_cbnganhhoc();
        }
        private void load_cbtenlophoc()
        {
            DataTable dt = db.list_lophoc();
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = 0";
            cb_tenlophoc.DataSource = dv;
            cb_tenlophoc.DisplayMember = "tenlophoc";
            cb_tenlophoc.SelectedIndex = -1;
        }
        private void load_cbkyhoc()
        {
            DataTable dt = db.th_list_kyhoc();
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = 0";
            cb_kyhoc.DataSource = dv;
            cb_kyhoc.DisplayMember = "kyhoc";
            cb_kyhoc.SelectedIndex = -1;
        }
        private void load_cbmonhoc()
        {
            DataTable dt = db.th_list_monhoc();
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = 0";
            cb_monhoc.DataSource = dv;
            cb_monhoc.DisplayMember = "tenmonhoc";
            cb_monhoc.SelectedIndex = -1;
        }
        private void load_cbnganhhoc()
        {
            DataTable dt = db.list_chuyennganh();
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = 0";
            cb_nganhhoc.DataSource = dv;
            cb_nganhhoc.DisplayMember = "tenchuyennganh";
            cb_nganhhoc.SelectedIndex = -1;
        }

        private void search_thongke()
        {
            string msv = txt_msv.Text;
            string tensv = txt_ten.Text;
            string tenlophoc = cb_tenlophoc.Text;
            string kyhoc = cb_kyhoc.Text;
            string monhoc = cb_monhoc.Text;
            string nghanhhoc = cb_nganhhoc.Text;

            DataTable dt = db.search_thongke(msv, tensv, tenlophoc, kyhoc, monhoc, nghanhhoc);
            DataView dv = new DataView(dt);
            if(global_is_pass == 1)
            {
                dv.RowFilter = $"is_pass = {global_is_pass}";
            }
            else
            {
                if(dk_truot == 0)
                {
                    dv.RowFilter = $"is_pass = {global_is_pass}";
                }
                else if(dk_truot == 1)
                {
                    dv.RowFilter = $"is_pass = {global_is_pass} AND sobuoinghi >  max_bh_chophep";
                }else if(dk_truot == 2)
                {
                    dv.RowFilter = $"is_pass = {global_is_pass} AND diem_tong_ket <  diemquamon";
                }
            }
            
            Datagridview.DataSource = dv;

            gb_thongke.Text =  "Tổng số: "+ Datagridview.Rows.Count.ToString();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            search_thongke();
        }

        private void rbt_pass_CheckedChanged(object sender, EventArgs e)
        {
            global_is_pass = 1;
            comboBox1.Visible = false;
            comboBox1.SelectedIndex = -1;
        }

        private void rbt_notpass_CheckedChanged(object sender, EventArgs e)
        {
            global_is_pass = 0;
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dk_truot = comboBox1.SelectedIndex;
        }
    }
    
}
