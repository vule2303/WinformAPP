using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    public class HinhTron
    {
        private double R;
        public HinhTron() { R = 0; }
        public HinhTron( double R)
        {
            this.R = R;
        }
        
        public double BanKinh
        {
            get => R;
            set
            {
                R = value;
            }
        }
        public double LayChuVi() => (2 * 3.14 * R);
        public double LayDienTich() => (3.14 * R * R);
        public string Xuat() => "Hình tròn bk: " + R.ToString() + "\nChu vi: " + LayChuVi().ToString() + "\nDiện tích: " + LayDienTich().ToString();
    }
}