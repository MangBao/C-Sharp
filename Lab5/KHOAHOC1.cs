using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class KHOAHOC1
    {
       
        string ten;
        byte soluong;
        List<HOCVIEN2> ls = new List<HOCVIEN2>();

        //phương thức nhập
        public KHOAHOC1(string t = "OOP", byte n = 3)
        {
            ten = t;
            soluong = n;
            string ms, ht;
            bool gt;
            DateTime ngay;
            float hp;
            // tao instance cua StreamReader de doc mot file.               
            FileStream f = new FileStream("F:\\data.txt", FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.UTF8);
               // doc cac dong trong file cho toi cuối file                

            while (!rd.EndOfStream)
            {//mỗi lần đọc từ file thông tin của 1 sinh viên đưa vào list
                ms = rd.ReadLine();
                ht = rd.ReadLine();
                gt = bool.Parse(rd.ReadLine());
                ngay = DateTime.Parse(rd.ReadLine());
                hp = float.Parse(rd.ReadLine());
                HOCVIEN2 sv2 = new HOCVIEN2(ms, ht, gt, ngay, hp);
                ls.Add(sv2);
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
