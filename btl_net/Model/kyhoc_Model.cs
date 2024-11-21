using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_net.Model
{
    internal class kyhoc_Model
    {
        private int id_kyhoc;
        private string kyhoc;
        private bool is_xoa;
        public kyhoc_Model(int id_kyhoc, string kyhoc, bool is_xoa)
        {
            this.id_kyhoc = id_kyhoc;
            this.kyhoc = kyhoc;
            this.is_xoa = is_xoa;
        }

        public int Id_kyhoc { get => id_kyhoc; set => id_kyhoc = value; }
        public string Kyhoc { get => kyhoc; set => kyhoc = value; }
        public bool Is_xoa { get => is_xoa; set => is_xoa = value; }
    }
}
