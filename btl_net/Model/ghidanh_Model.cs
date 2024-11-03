﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_net.Model
{
    internal class ghidanh_Model
    {
        private int id_ghidanh, id_sv, id_lophoc, sobuoinghi, xeplichthi;

        public ghidanh_Model(int id_ghidanh, int id_sv, int id_lophoc, int sobuoinghi, int xeplichthi)
        {
            this.id_ghidanh = id_ghidanh;
            this.id_sv = id_sv;
            this.id_lophoc = id_lophoc;
            this.sobuoinghi = sobuoinghi;
            this.xeplichthi = xeplichthi;
        }

        public int Id_ghidanh { get => id_ghidanh; set => id_ghidanh = value; }
        public int Id_sv { get => id_sv; set => id_sv = value; }
        public int Id_lophoc { get => id_lophoc; set => id_lophoc = value; }
        public int Sobuoinghi { get => sobuoinghi; set => sobuoinghi = value; }
        public int Xeplichthi { get => xeplichthi; set => xeplichthi = value; }
    }
}