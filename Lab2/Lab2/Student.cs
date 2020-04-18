using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        string ma, ten;
        bool gioitinh;
        DateTime ngaysinh;
        public Student(string m = "60130041", string ht = "Mang Bảo", bool gt = true, DateTime d = new DateTime())
        {
            ma = m; ten = ht; gioitinh = gt; ngaysinh = d;

        }
        public void xuat()
        {
            Console.OutputEncoding = Encoding.Unicode;
            if (gioitinh)
                Console.Write("{0}\t{1}\t Nam\t{2}", ma, ten, ngaysinh.ToShortDateString());
            else
                Console.Write("{0}\t{1}\t Nu\t{2}", ma, ten, ngaysinh.ToShortDateString());
        }
    }
}
