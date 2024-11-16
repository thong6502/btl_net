using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_net.Model
{
    internal class phanloaimonhoc_Model
    {
        private int id_phanloai_mh;
        private string loaimh;
        private bool is_xoa;

        public phanloaimonhoc_Model(int id_phanloai_mh, string loaimh, bool is_xoa)
        {
            this.id_phanloai_mh = id_phanloai_mh;
            this.loaimh = loaimh;
            this.is_xoa = is_xoa;
        }

        public int Id_phanloai_mh { get => id_phanloai_mh; set => id_phanloai_mh = value; }
        public string Loaimh { get => loaimh; set => loaimh = value; }
        public bool Is_xoa { get => is_xoa; set => is_xoa = value; }
    }
}
