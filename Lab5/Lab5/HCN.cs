using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class HCN
    {
        protected float Canh1, Canh2;
        public HCN() { Canh1 = 0; Canh2 = 0; }
        public HCN(float Canh1, float Canh2) 
        {
            this.Canh1 = Canh1;
            this.Canh2 = Canh2; 
        }
        public void NhapKT(float x, float y)
        {
            Canh1 = x; Canh2 = y;
        }
        public float ChuVi()
        {
            return (Canh1 + Canh2) *2;
        }
        public float DienTich()
        {
            return Canh1 * Canh2;
        }
    }
}
