﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_net.Model
{
    internal class monhoc_Model
    {
        private int id_monhoc, sotc, tongsobh, max_bh_chophep, id_phanloai_mh;
        private float diemquamon;
        private string tenmonhoc;
        private bool is_xoa;

        public monhoc_Model(int id_monhoc, int sotc, int tongsobh, int max_bh_chophep, int id_phanloai_mh, string tenmonhoc, bool is_xoa, float diemquamon)
        {
            this.id_monhoc = id_monhoc;
            this.sotc = sotc;
            this.tongsobh = tongsobh;
            this.max_bh_chophep = max_bh_chophep;
            this.id_phanloai_mh = id_phanloai_mh;
            this.tenmonhoc = tenmonhoc;
            this.is_xoa = is_xoa;
            this.diemquamon = diemquamon;
        }

        public int Id_monhoc { get => id_monhoc; set => id_monhoc = value; }
        public int Sotc { get => sotc; set => sotc = value; }
        public int Tongsobh { get => tongsobh; set => tongsobh = value; }
        public int Max_bh_chophep { get => max_bh_chophep; set => max_bh_chophep = value; }
        public int Id_phanloai_mh { get => id_phanloai_mh; set => id_phanloai_mh = value; }
        public string Tenmonhoc { get => tenmonhoc; set => tenmonhoc = value; }
        public bool Is_xoa { get => is_xoa; set => is_xoa = value; }
        public float Diemquamon { get => diemquamon; set => diemquamon = value; }
    }
}
