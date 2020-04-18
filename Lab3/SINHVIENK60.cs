using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class SINHVIENK60
    {
        string ten;
        static int ns;
        double nang, cao, BMI = 0;
        //Phương thức thiết lập
        public SINHVIENK60(string t="", double c=1.6,double n=56)
        {
            ten = t;//Viết một cách tưởng minh
            ns = 2000;
            cao = c;
            nang = n;
        }
        public byte KT()
        {
            byte kt = 0;
            BMI = nang / Math.Pow(cao, 2);
            if (BMI < 19)
                kt = 0;
            else if (BMI > 25)
                kt = 1;
            else
                kt = 2;
            return kt;
        }
        public void tanggiam()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double nangs = 0;
            if (BMI < 19)
            {
                nangs = 22 * Math.Pow(cao, 2) - nang;
                Console.WriteLine("Cần tăng thêm: {0}kg", nangs);
            }
            else if (BMI > 25)
            {
                nangs = nang - 25 * Math.Pow(cao, 2);
                Console.WriteLine("Cần giảm đi: {0}kg", nangs);
            }
                
        }
        public void xuat()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("{0}\tHeight: {1}m\t Weight: {2}kg\tNăm: {3}", ten,cao,nang, SINHVIENK60.ns);
            if (KT() == 0)
                Console.WriteLine("Cố gắng ăn nhiều nhé.");
            else if (KT() == 1)
                Console.WriteLine("Tập thể dục thường xuyên vào nhé. ");
            else
                Console.WriteLine("Sức khỏe tốt cố gắng duy trì nhé.");

        }
    }
}
