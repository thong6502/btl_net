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

        public chuyennganh_Model(int id_chuyennganh, string tenchuyennganh)
        {
            this.id_chuyennganh = id_chuyennganh;
            this.tenchuyennganh = tenchuyennganh;
        }

        public int Id_chuyennganh { get => id_chuyennganh; set => id_chuyennganh = value; }
        public string Tenchuyennganh { get => tenchuyennganh; set => tenchuyennganh = value; }
    }
}
