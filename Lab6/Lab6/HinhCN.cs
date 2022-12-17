using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    public class HinhCN
    {
        private double dai;
        private double rong;
        public HinhCN() { dai = 0; rong = 0; }
        public HinhCN(double dai,double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public double ChieuDai
        {
            get => dai;
            set
            {
                dai = value;
            }
        }

        public double ChieuRong
        {
            get => rong;
            set
            {
                rong = value;
            }
        }
        public double LayChuVi() => 2 * (dai+rong);
        public double LayDienTich() => dai * rong;
        public string Xuat() => "Hình chữ nhật độ dài: " + dai.ToString() + ", chiều rộng : " + rong.ToString() + "\nChu vi: " + LayChuVi().ToString() + "\nDiện tích: " + LayDienTich().ToString();

    }
}