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

        public kyhoc_Model(int id_kyhoc, string kyhoc)
        {
            this.id_kyhoc = id_kyhoc;
            this.kyhoc = kyhoc;
        }

        public int Id_kyhoc { get => id_kyhoc; set => id_kyhoc = value; }
        public string Kyhoc { get => kyhoc; set => kyhoc = value; }
    }
}
