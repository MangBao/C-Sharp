using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class PTB2
    {
        int a1, b1, c1;
        int a, b, c;
        double delta = 0, x1, x2;
        public PTB2(int a,int b, int c)
        {
            a = a1; b = b1; c = c1;
        }
        void GiaiPTB1()
        {
            if (b == 0)
                if (c == 0)
                    Console.Write("Vo so nghiem.");
                else
                    Console.Write("Vo nghiem.");
            else
                x1= -Convert.ToSingle(b) / Convert.ToSingle(a);
                Console.WriteLine("Nghiem: {0}", x1);
        }
        public void GiaiPTB2()
        {
            if (a == 0)
            {
                GiaiPTB1();
            }
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = {0}\nx2 = {1}", x1, x2);
                }
                else
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = {0}", x1);
                }
            }
            
        }
    }
}
