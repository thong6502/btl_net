using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_net.Model
{
    internal class sinhvien_Model
    {
        private int id_sv, id_chuyennganh;
        private DateTime ngaysinh;
        private bool is_conhoc;
        private string email, diachi, gioitinh, cccd, khoahoc, hoten, msv;

        public sinhvien_Model(int id_sv, int id_chuyennganh, DateTime ngaysinh, bool is_conhoc, string email, string diachi, string gioitinh, string cccd, string khoahoc, string hoten, string msv)
        {
            this.id_sv = id_sv;
            this.id_chuyennganh = id_chuyennganh;
            this.ngaysinh = ngaysinh;
            this.is_conhoc = is_conhoc;
            this.email = email;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
            this.cccd = cccd;
            this.khoahoc = khoahoc;
            this.hoten = hoten;
            this.msv = msv;
        }

        public int Id_sv { get => id_sv; set => id_sv = value; }
        public int Id_chuyennganh { get => id_chuyennganh; set => id_chuyennganh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public bool Is_conhoc { get => is_conhoc; set => is_conhoc = value; }
        public string Email { get => email; set => email = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Khoahoc { get => khoahoc; set => khoahoc = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Msv { get => msv; set => msv = value; }
    }
}
