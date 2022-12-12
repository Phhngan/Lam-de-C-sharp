using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class HinhChuNhat
    {
        public double chieuDai;
        public double chieuRong;
        public double chuVi;
        public double dienTich;

        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        public double tinhChuVi()
        {
            chuVi = (chieuDai + chieuRong) * 2;
            return chuVi;
        }
        public double tinhDienTich()
        {
            dienTich = chieuDai * chieuRong;
            return dienTich;
        }
    }
}

