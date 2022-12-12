using System;
using Test2;

namespace Test
{
    internal class Bai2
    {
        public static void Main(string[] args)
        {
            HinhChuNhat hcn1 = new HinhChuNhat(5, 2);
            hcn1.tinhChuVi();
            hcn1.tinhDienTich();
            HinhChuNhat hcn2 = new HinhChuNhat(24, 15);
            hcn2.tinhChuVi();
            hcn2.tinhDienTich();
            HinhChuNhat hcn3 = new HinhChuNhat(10, 5);
            hcn3.tinhChuVi();
            hcn3.tinhDienTich();
            HinhChuNhat hcn4 = new HinhChuNhat(20, 10);
            hcn4.tinhChuVi();
            hcn4.tinhDienTich();
            HinhChuNhat hcn5 = new HinhChuNhat(12, 6);
            hcn5.tinhChuVi();
            hcn5.tinhDienTich();
            HinhChuNhat hcn6 = new HinhChuNhat(5.5, 2);
            hcn6.tinhChuVi();
            hcn6.tinhDienTich();
            HinhChuNhat hcn7 = new HinhChuNhat(8, 5);
            hcn7.tinhChuVi();
            hcn7.tinhDienTich();
            HinhChuNhat hcn8 = new HinhChuNhat(15, 2);
            hcn8.tinhChuVi();
            hcn8.tinhDienTich();
            HinhChuNhat hcn9 = new HinhChuNhat(22, 11);
            hcn9.tinhChuVi();
            hcn9.tinhDienTich();
            HinhChuNhat hcn10 = new HinhChuNhat(16, 10);
            hcn10.tinhChuVi();
            hcn10.tinhDienTich();

            double[] chuViHCN = { hcn1.chuVi, hcn2.chuVi, hcn3.chuVi, hcn4.chuVi, hcn5.chuVi, hcn6.chuVi, hcn7.chuVi, hcn8.chuVi, hcn9.chuVi, hcn10.chuVi };
            Array.Sort(chuViHCN);
            Array.Reverse(chuViHCN);
            foreach (int i in chuViHCN)
            {
                Console.Write(i+ " ");
            };
        }
    }
}
