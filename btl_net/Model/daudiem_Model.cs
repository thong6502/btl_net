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
        private decimal tyle;
        private bool is_xoa;

        public daudiem_Model(int id_daudiem, int id_monhoc, string tendaudiem, decimal tyle, bool is_xoa)
        {
            this.id_daudiem = id_daudiem;
            this.id_monhoc = id_monhoc;
            this.tendaudiem = tendaudiem;
            this.tyle = tyle;
            this.is_xoa = is_xoa;
        }

        public int Id_daudiem { get => id_daudiem; set => id_daudiem = value; }
        public int Id_monhoc { get => id_monhoc; set => id_monhoc = value; }
        public string Tendaudiem { get => tendaudiem; set => tendaudiem = value; }
        public decimal Tyle { get => tyle; set => tyle = value; }
        public bool Is_xoa { get => is_xoa; set => is_xoa = value; }
    }
}
