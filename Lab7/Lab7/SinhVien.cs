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
        public SinhVien(string masv = "", string hoten = "", string sdt = "", string phai = "")
        {
            this.Masv = masv;
            this.Hoten = hoten;
            this.Sdt = sdt;
            this.Phai = phai;
            
        }
        public SinhVien(SinhVien t)
        {
            this.Masv = t.Masv;
            this.Hoten = t.Hoten;
            this.Sdt = t.Sdt;
            this.Phai = t.Phai;
        
        }
        public string Masv { get => masv; set => masv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
