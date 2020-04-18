using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Array
    {
        byte n;// số phần tử mảng
        int[] a;
        //Phương thức thiết lập
        public Array(byte n1 = 5)
        {
            n = n1;
            a = new int[n];
            Random r = new Random();
            for (byte i = 0; i < n; i++)
                a[i] = r.Next(1, 100);
        }
        //Xuất mảng ra màn hình
        public void Xuat()
        {
            foreach (int x in a)
                Console.WriteLine("\t{0}", a);
        }
        public float TinhTBC()
        {
            float s = 0;
            foreach (int x in a)
                s += x;
            return s / n;
        }
        public void sapxep()
        {
            for(byte i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n - 1; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = 0;
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
            Console.Write("Mang tang dan: ");
            for (int i = 0; i < n; i++)
                Console.Write("{0}\t", a[i]);
        }
    }
}
