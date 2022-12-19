using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class SinhVien
    {

        string masv, hoten, phai, sdt;
        public SinhVien(string masv = "", string hoten = "", string phai = "", string sdt = "")
        {
            this.Masv = masv;
            this.Hoten = hoten;
            this.Phai = phai;
            this.Sdt = sdt;
        }
        public SinhVien(SinhVien t)
        {
            this.Masv = t.Masv;
            this.Hoten = t.Hoten;
            this.Phai = t.Phai;
            this.Sdt = t.Sdt;
        }
        public string Masv { get => masv; set => masv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
