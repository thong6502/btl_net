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
    public partial class form_lophoc : Form
    {
        Dbconnect db = new Dbconnect();
        int global_is_xoa = 0;
        public form_lophoc()
        {
            InitializeComponent();
            init();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void init()
        {
            load_cb_kyhoc();
            load_cb_loaimonhoc();
            load_datagridview();
            txt_tenlophoc.Text = string.Empty;
            txt_toidasv.Text = "40";
        }
        private void load_datagridview()
        {
            DataTable dt = db.list_lophoc();
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = "+ global_is_xoa;
            datagridview.DataSource = dv;
        }
        private void load_cb_kyhoc()
        {
            DataTable dt = db.th_list_kyhoc();
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = 0";
            cb_kyhoc.DataSource = dv;
            cb_kyhoc.DisplayMember = "kyhoc";
            cb_kyhoc.ValueMember = "id_kyhoc";
            cb_kyhoc.SelectedIndex = -1;
        }
        private void load_cb_loaimonhoc()
        {
            DataTable dt = db.list_loaimonhoc();
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = 0";
            cb_lmh.DataSource = dv;
            cb_lmh.DisplayMember = "loaimh";
            cb_lmh.ValueMember = "id_phanloai_monhoc";
            cb_lmh.SelectedIndex = -1;
        }
        private void load_cb_monhoc()
        {
            cb_monhoc.Text = string.Empty;
            if (cb_lmh.SelectedValue != null && cb_lmh.SelectedIndex != -1 && int.TryParse(cb_lmh.SelectedValue.ToString(), out int id_phanloaimh))
            {
                DataTable dt = db.th_list_monhoc();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("is_xoa = 0 AND id_phanloai_monhoc = {0}", id_phanloaimh);
                cb_monhoc.DataSource = dv;
                cb_monhoc.DisplayMember = "tenmonhoc";
                cb_monhoc.ValueMember = "id_monhoc";
            }
            else
            {
                DataTable dt = db.th_list_monhoc();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("is_xoa = 0");
                cb_monhoc.DataSource = dv;
                cb_monhoc.DisplayMember = "tenmonhoc";
                cb_monhoc.ValueMember = "id_monhoc";
            }
            cb_monhoc.SelectedIndex = -1;
        }

        private void cb_lmh_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_cb_monhoc();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int id_monhoc = Int32.Parse(cb_monhoc.SelectedValue.ToString());
            int id_kyhoc = Int32.Parse(cb_kyhoc.SelectedValue.ToString());
            string tenlophoc = txt_tenlophoc.Text;
            int maxsv = Int32.Parse(txt_toidasv.Text);

            lophoc_Model lh = new lophoc_Model(0, id_monhoc, id_kyhoc, tenlophoc, false, maxsv);

            db.them_lophoc(lh);

            init();
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= datagridview.Rows.Count)
            {
                return;
            }

            DataGridViewRow selectedRow = datagridview.Rows[e.RowIndex];

            txt_tenlophoc.Text = selectedRow.Cells["tenlophoc"].Value?.ToString();
            cb_kyhoc.Text = selectedRow.Cells["kyhoc"].Value?.ToString(); // Added ?. for null safety
            cb_monhoc.Text = selectedRow.Cells["tenmonhoc"].Value?.ToString(); // Added ?. for null safety

            string tiLeSinhVien = selectedRow.Cells["ti_le_sinh_vien"].Value?.ToString();

            if (!string.IsNullOrEmpty(tiLeSinhVien) && tiLeSinhVien.Contains('/'))
            {
                string[] parts = tiLeSinhVien.Split('/');
                if (parts.Length > 1) // Check if there's a second element after the split
                {
                    txt_toidasv.Text = parts[1];
                }
                else
                {
                    txt_toidasv.Text = ""; // Or handle the case where there's no '/' or only one element after the split
                }

            }
            else
            {
                txt_toidasv.Text = ""; // Or another default value
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int id_lophoc = Int32.Parse(datagridview.SelectedRows[0].Cells["id_lophoc"].Value.ToString());
            int id_monhoc = Int32.Parse(cb_monhoc.SelectedValue.ToString());
            int id_kyhoc = Int32.Parse(cb_kyhoc.SelectedValue.ToString());
            string tenlophoc = txt_tenlophoc.Text;
            int maxsv = Int32.Parse(txt_toidasv.Text);

            lophoc_Model lh = new lophoc_Model(id_lophoc, id_monhoc, id_kyhoc, tenlophoc, false, maxsv);

            db.sua_lophoc(lh);

            init();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int id_lophoc = Int32.Parse(datagridview.SelectedRows[0].Cells["id_lophoc"].Value.ToString());
            db.xoa_lophoc(id_lophoc);

            init();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string kyhoc = cb_kyhoc.Text;
            string tenlophoc = txt_tenlophoc.Text;
            string monhoc = cb_monhoc.Text;

            DataTable dt = db.search_lophoc(tenlophoc, kyhoc, monhoc);
            DataView dv = new DataView(dt);
            dv.RowFilter = "is_xoa = " + global_is_xoa;
            datagridview.DataSource = dv;

        }

        private void chb_thungrac_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_thungrac.Checked)
            {
                global_is_xoa = 1;
                btn_khoiphuc.Enabled = true;
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
            }
            else
            {
                global_is_xoa = 0;
                btn_khoiphuc.Enabled = false;
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
            }
            cb_kyhoc.SelectedIndex = -1;
            cb_lmh.SelectedIndex = -1;
            cb_monhoc.SelectedIndex = -1;
            load_datagridview();
            txt_tenlophoc.Text = string.Empty;
            txt_toidasv.Text = "40";
        }

        private void btn_khoiphuc_Click(object sender, EventArgs e)
        {
            int id_lophoc = Int32.Parse(datagridview.SelectedRows[0].Cells["id_lophoc"].Value.ToString());
            db.khoiphuc_lophoc(id_lophoc);

            init();
        }
    }
}
