using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_net.Model
{
    internal class diem_Model
    {
        private int id_diem, id_daudiem, id_sv;
        private float diem;
        private bool is_xoa;

        public diem_Model(int id_diem, int id_daudiem, int id_sv, float diem, bool is_xoa)
        {
            this.id_diem = id_diem;
            this.id_daudiem = id_daudiem;
            this.id_sv = id_sv;
            this.diem = diem;
            this.is_xoa = is_xoa;
        }

        public int Id_diem { get => id_diem; set => id_diem = value; }
        public int Id_daudiem { get => id_daudiem; set => id_daudiem = value; }
        public int Id_sv { get => id_sv; set => id_sv = value; }
        public float Diem { get => diem; set => diem = value; }
        public bool Is_xoa { get => is_xoa; set => is_xoa = value; }
    }
}
