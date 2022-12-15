using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class HTG
    {

        double Canh1, Canh2, Canh3;

            public double canh1
            {
                get => Canh1;
                set
                {
                    Canh1 = value;
                }
            }

            public double canh2
            {
                get => Canh2;
                set
                {
                    Canh2 = value;
                }
            }

            public double canh3
            {
                get => Canh3;
                set
                {
                    Canh3 = value;
                }
            }

            

            public HTG(double a = 0, double b = 0, double c = 0)
            {
                Canh1 = a;
                Canh2 = b;
                Canh3 = c;
            }

            public double LayChuVi()
            {
                return Canh1 + Canh2 + Canh3;
            }

            public double LayDienTich()
            {
                double p = (Canh1 * 1.0 + Canh2 + Canh3) / 2;
                return Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));
            }

            public string Loi()
            {
                return "Lỗi!";
            }

            public string KiemTraTG()
            {
                if (Canh1 < Canh2 + Canh3 && Canh2 < Canh1 + Canh3 && Canh3 < Canh1 + Canh2)
                {
                    if (Canh1 * Canh1 == Canh2 * Canh2 + Canh3 * Canh3 || Canh2 * Canh2 == Canh1 * Canh1 + Canh3 * Canh3 || Canh3 * Canh3 == Canh1 * Canh1 + Canh2 * Canh2)
                    {
                        return "Tam giác vuông";
                    }
                    else if (Canh1 == Canh2 && Canh2 == Canh3)
                    {
                        return "Tam giác đều";
                    }
                    else if (Canh1 == Canh2 || Canh1 == Canh3 || Canh2 == Canh3)
                    {
                        return "Tam giác cân";
                    }
                    else if ((Canh1 * Canh1 > Canh2 * Canh2 + Canh3 * Canh3) || (Canh2 * Canh2 > Canh1 * Canh1 + Canh3 * Canh3) || (Canh3 * Canh3 > Canh1 * Canh1 + Canh2 * Canh2))
                        return "Tam giác tù";
                    else
                        return "Tam giác nhọn";
                }
                else
                {
                    return "Không phải tam giác";
                }
            }

            
        
    }
}
