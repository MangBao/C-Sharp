using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5
{
    class SINHVIEN
    {
        string maso, hoten;
        float D2;
        List<MONHOC> ls = new List<MONHOC>();

        public SINHVIEN(string ms = " ", string ht = " ")
        {
            this.maso = ms;
            this.hoten = ht;
        }

        public void NhapSV()
        {
            Console.Write("\nNhap ma so sinh vien: ");
            maso = Console.ReadLine();
            Console.Write("\nNhap ten sinh vien : ");
            hoten = Console.ReadLine();
            Console.Write("\nNhap so luong mon hoc : ");
            byte n = byte.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap mon hoc thu {0} ", i + 1);
                MONHOC Mh = new MONHOC();
                Mh.NhapMh();
                Console.WriteLine("In ra mon hoc nay:");
                Console.WriteLine(Mh.ToString());
                ls.Add(Mh);
            }
        }

        public void DiemTBHK()
        {
            D2 = 0;
            float d1 = 0;
            float t_dv = 0;
            foreach (var d in ls)
            {
                d1 += d.DiemTB1 * d.DonVi;
                t_dv += d.DonVi;
            }
            D2 = d1 / t_dv;
            Console.WriteLine("{0}", D2);
        }

        public void XetHB()
        {
            foreach (var tim in ls)
                if (D2 > 7 && tim.DiemTB() > 5.5 && tim.DiemThi > 5.5)
                    Console.WriteLine("\nBan duoc nhan hoc bong");
                else
                    Console.WriteLine("\nBan khong duoc nhan hoc bong");
        }

    }
}
