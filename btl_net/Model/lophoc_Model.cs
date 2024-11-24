using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_net.Model
{
    internal class lophoc_Model
    {
        private int id_lophoc, id_monhoc, id_kyhoc;
        private string tenlophoc;
        private int sinhvientoida;
        private bool is_xoa;


        public lophoc_Model(int id_lophoc, int id_monhoc, int id_kyhoc, string tenlophoc, bool is_xoa, int sinhvientoida)
        {
            this.id_lophoc = id_lophoc;
            this.id_monhoc = id_monhoc;
            this.id_kyhoc = id_kyhoc;
            this.tenlophoc = tenlophoc;
            this.is_xoa = is_xoa;
            this.sinhvientoida = sinhvientoida;
        }

        public int Id_lophoc { get => id_lophoc; set => id_lophoc = value; }
        public int Id_monhoc { get => id_monhoc; set => id_monhoc = value; }
        public int Id_kyhoc { get => id_kyhoc; set => id_kyhoc = value; }
        public string Tenlophoc { get => tenlophoc; set => tenlophoc = value; }
        public bool Is_xoa { get => is_xoa; set => is_xoa = value; }
        public int Sinhvientoida { get => sinhvientoida; set => sinhvientoida = value; }
    }
}
