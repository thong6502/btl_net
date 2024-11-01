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

        public phanloaimonhoc_Model(int id_phanloai_mh, string loaimh)
        {
            this.id_phanloai_mh = id_phanloai_mh;
            this.loaimh = loaimh;
        }

        public int Id_phanloai_mh { get => id_phanloai_mh; set => id_phanloai_mh = value; }
        public string Loaimh { get => loaimh; set => loaimh = value; }
    }
}
