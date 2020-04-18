using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTHK1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ma, tuyen;
            DateTime ngay;
            double kc; int gia;
            byte n;
            vekhuhoi vkh = new vekhuhoi();
            List<vekhuhoi> ls = new List<vekhuhoi>();

            FileStream f = new FileStream("C:\\Users\\ASUS\\Documents\\Visual Studio 2019\\Project\\KTHK1\\data.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader rd = new StreamReader(f, Encoding.UTF8);
            do
            {
                Console.Write("So ve khu hoi la: ");
                n = byte.Parse(Console.ReadLine());
            } while (n < 3 || n > 50);

            for (byte i = 0; i < n; i++)
            {
                ma = rd.ReadLine();
                tuyen = rd.ReadLine();
                ngay = DateTime.Parse(rd.ReadLine());
                gia = int.Parse(rd.ReadLine());
                kc = double.Parse(rd.ReadLine());
                
                vekhuhoi v = new vekhuhoi(ma, ngay, kc, gia, tuyen);
                ls.Add(v);
            }
            vekhuhoi1 v1 = new vekhuhoi1();
            ls.Sort(v1);
            foreach (vekhuhoi v in ls)
                Console.WriteLine(v.ToString());
            for(byte j = 0; j < n; j++)
            {
                int giaTB = 0;
                giaTB = (giaTB + vkh.GIAVE());
            }

            for (byte j = 0; j < ls.Count; j++)
                if (ls[j].Tuyen == "NT-KH")
                {
                    ls.RemoveAt(j);
                    break;
                }

            Console.ReadKey();
        }
    }
}
