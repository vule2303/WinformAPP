using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTPSo
{
   public class PS
    {
        int tu, mau;
        public int TuSo
        {
            get { return tu; } set { tu = value; } 
        }
        public int MauSo
        {
            get { return mau; } 
            set { 
                if (value != 0)
                    mau = value; 
            } 
        }
        public PS (int tu, int mau)
        {
            this.tu = tu; this.mau = mau;
            
        }
        public PS()
        {

        }
        public int UCLN(int a, int b)
        {
            if (b == 0)

                return a;
            return UCLN(b, a % b);
        }
        public PS RutGonPhanSo() // rút gọn tử và mẫu
        {
            PS rutgon = new PS();
            int uoc = UCLN(tu, mau);
            if (uoc != 0)
            {
                rutgon.tu = tu / uoc;
                rutgon.mau = mau / uoc;
            }
            else
            {
                rutgon.tu = tu;
                rutgon.mau = mau;
            }
            MessageBox.Show("PSDRG: "+ rutgon.tu + "/"+ rutgon.mau);
            return rutgon;
        }
        public static PS operator +(PS ps1, PS ps2)
        {
            PS KQ = new PS();
            KQ.TuSo = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo;
            KQ.MauSo = ps1.MauSo * ps2.MauSo;
            return KQ;
        }
        public static PS operator -(PS ps1, PS ps2)
        {
            PS KQ = new PS();
            KQ.TuSo = ps1.TuSo * ps2.MauSo - ps2.TuSo * ps1.MauSo;
            KQ.MauSo = ps1.MauSo * ps2.MauSo;
            return KQ;
        }
        public static PS operator *(PS ps1, PS ps2)
        {
            PS KQ = new PS();
            KQ.TuSo = ps1.TuSo * ps2.TuSo;
            KQ.MauSo = ps1.MauSo * ps2.MauSo;
            return KQ;
        }
        public static PS operator /(PS ps1, PS ps2)
        {
            PS KQ = new PS();
            KQ.TuSo = ps1.TuSo * ps2.MauSo;
            KQ.MauSo = ps1.MauSo * ps2.TuSo;
            return KQ;
        }


    }
}
