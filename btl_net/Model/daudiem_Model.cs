using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_net.Model
{
    internal class daudiem_Model
    {
        private int id_daudiem, id_monhoc;
        private string tendaudiem;
        private float tyle;

        public daudiem_Model(int id_daudiem, int id_monhoc, string tendaudiem, float tyle)
        {
            this.id_daudiem = id_daudiem;
            this.id_monhoc = id_monhoc;
            this.tendaudiem = tendaudiem;
            this.tyle = tyle;
        }

        public int Id_daudiem { get => id_daudiem; set => id_daudiem = value; }
        public int Id_monhoc { get => id_monhoc; set => id_monhoc = value; }
        public string Tendaudiem { get => tendaudiem; set => tendaudiem = value; }
        public float Tyle { get => tyle; set => tyle = value; }
    }
}
