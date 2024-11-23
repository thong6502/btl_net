using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_net.Model
{
    internal class chuyennganh_Model
    {
        private int id_chuyennganh;
        private string tenchuyennganh;
        private bool is_xoa;

        public chuyennganh_Model(int id_chuyennganh, string tenchuyennganh, bool is_xoa)
        {
            this.id_chuyennganh = id_chuyennganh;
            this.tenchuyennganh = tenchuyennganh;
            this.is_xoa = is_xoa;
        }

        public int Id_chuyennganh { get => id_chuyennganh; set => id_chuyennganh = value; }
        public string Tenchuyennganh { get => tenchuyennganh; set => tenchuyennganh = value; }
        public bool Is_xoa { get => is_xoa; set => is_xoa = value; }
    }
}
