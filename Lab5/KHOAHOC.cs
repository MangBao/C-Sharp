using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class KHOAHOC
    {
        string ten;
        byte soluong;
        List<HOCVIEN> ls = new List<HOCVIEN>();
        
        //phương thức nhập
        public KHOAHOC(string t = "OOP", byte n = 3)
        {
            ten = t;
            soluong = n;
            for (byte i = 0; i < soluong; i++)
            { //nhập thông tin cho 1 học viên
                Console.Write("Nhập sinh viên thứ {0}\n", i + 1);
                Console.Write("Nhập mã:");
                string ms = Console.ReadLine();
                Console.Write("Nhập họ tên:");
                string ht = Console.ReadLine();
                Console.Write("Nhập giới tính:");
                bool gt = bool.Parse(Console.ReadLine());
                Console.Write("Nhập ngày sinh:");
                DateTime ns = DateTime.Parse(Console.ReadLine());
                Console.Write("Nhập học phí:");
                double hp = double.Parse(Console.ReadLine());
                HOCVIEN hv = new HOCVIEN(ms, ht, gt, ns, hp);
                //đưa học viên vào list
                ls.Add(hv);
            }
        }
        //xuất danh sách theo thứ tự học phí
        public void Xuat()
        {
            ls.Sort();
            foreach (var h in ls)
                Console.WriteLine(h.ToString());
        }
        /*public void Xuat1()
        {
            HOCVIEN1 hv1 = new HOCVIEN1();
            ls.Sort(hv1);
            foreach (var h in ls)
                Console.WriteLine(h.ToString());
        }*/
        //tìm và xuất học viên có mã số x
        public void Tim(string x)
        {
            foreach (var h in ls)
                if (x.CompareTo(h.Ms) == 0)
                    Console.WriteLine(h.ToString());
        }

    }
}
