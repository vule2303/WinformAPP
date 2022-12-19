using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    public class HinhTG
    {
        private double c1;
        private double c2;
        private double c3;
        public HinhTG() { c1 = 0; c2 = 0;c3 = 0; }
        public HinhTG(double c1, double c2, double c3)
        {
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        public double Canh1
        {
            get => c1;
            set
            {
                c1 = value;
            }
        }

        public double Canh2
        {
            get => c2;
            set
            {
                c2= value;
            }
        }

        public double Canh3
        {
            get => c3;
            set
            {
                c3 = value;
            }
        }
        public double LayChuVi() => c1 + c2 + c3;
        public double LayDienTich() => Math.Sqrt(LayChuVi() * (LayChuVi() - c1) * (LayChuVi() - c2) * (LayChuVi() - c3));
        public string Loi() => "Lỗi!";
        public string PhanLoaiTG()
        {
            if (c1 < c2 + c3 && c2 < c1 + c3 && c3 < c1 + c2)
            {
                if (c1 * c1 == c2 * c2 + c3 * c3 || c2 * c2 == c1 * c1 + c3 * c3 || c3 * c3 == c1 * c1 + c2 * c2)
                    return "Tam giác vuông";
                else if (c1 == c2 && c2 == c3)
                    return "Tam giác đều";
                else if (c1 == c2 || c1 == c3 || c2 == c3)
                    return "Tam giác cân";
                else if ((c1 * c1 > c2 * c2 + c3 * c3) || (c2 * c2 > c1 * c1 + c3 * c3) || (c3 * c3 > c1 * c1 + c2 * c2))
                    return "Tam giác tù";
                else
                    return "Tam giác nhọn";
            }
            else
            {
                return "Không phải tam giác";
            }
        }
        public string Xuat()
        {
            if (PhanLoaiTG() == "Không phải tam giác")
            {
                return "3 cạnh bạn vừa nhập không thể tạo thành 1 tam giác!";
            }

            return "Hình tam giác có 3 cạnh lần lượt là: " + c1.ToString() + " " + c2.ToString() + " " + c3.ToString()
                 + "\nTam giác này thuộc loại: " + PhanLoaiTG()
                 + "\nChu vi: " + LayChuVi().ToString()
                 + "\nDiện tích: " + LayDienTich().ToString();
        }
    }
}