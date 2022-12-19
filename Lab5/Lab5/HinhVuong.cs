using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    public class HinhVuong
    {
        private double canh;
        public HinhVuong () { canh = 0; }
        public HinhVuong (double canh)
        {
            this.canh = canh;
        }
        public double Canh
        {
            get { return canh; }
            set { canh = value; }
        }
        public double LayChuVi() => canh * 4;
        public double LayDienTich() => canh * canh;
        public string Xuat() => "Hình vuông độ dài: " + canh.ToString() + "\nChu vi: " + LayChuVi().ToString() + "\nDiện tích: " + LayDienTich().ToString();

    }
}