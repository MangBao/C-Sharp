using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KIEMTRA
{
    class HocVien : Nguoi
    {
        string ms, ht, lh;
        DateTime ngay;
        int sth;
        double hp1t;
        double hp;
        byte n;
        List<HocVien> ls = new List<HocVien>();
        public HocVien(string ms = " ", string ht = " ", DateTime ns = new DateTime(), int sth = 0, string lh = "", double hp1t = 0) : base(ms, ht, ns)
        {
            this.lh = lh;
            this.sth = sth;
            this.hp1t = hp1t;        
        }

        public double Hp { get => hp; set => hp = value; }
        public double Hp1t { get => hp1t; set => hp1t = value; }
        public int Sth { get => sth; set => sth = value; }

        public void info()
        {
            do
            {
                Console.Write("Nhập số sinh viên cần xuất: ");
                n = byte.Parse(Console.ReadLine());

            }
            while (n < 2 || n > 15);
            // tao instance cua StreamReader de doc mot file.               

            FileStream f = new FileStream("C:\\Users\\ASUS\\Documents\\Visual Studio 2019\\Project\\KIEMTRA\\data.txt", FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.UTF8);           

            for (byte i = 0; i < n; i++)
            {
                ms = rd.ReadLine();
                ht = rd.ReadLine();
                ngay = DateTime.Parse(rd.ReadLine());
                lh = rd.ReadLine();
                sth = int.Parse(rd.ReadLine());
                hp1t = double.Parse(rd.ReadLine());
                HocVien hv = new HocVien(ms, ht, ngay, sth, lh, hp1t);
                ls.Add(hv);
            }
            HocVien1 hv1 = new HocVien1();
            ls.Sort(hv1);
            foreach (HocVien hv in ls)
                Console.WriteLine(hv.ToString());
            //Thêm 
            StreamWriter wr = new StreamWriter(f, Encoding.UTF8);
            Console.Write("Nhập số sinh viên thêm: ");
            byte m = byte.Parse(Console.ReadLine());
            for (byte i = 0; i < m; i++)
            {
                Console.Write("\nNhập mã số:");
                ms = Console.ReadLine();
                wr.WriteLine(ms);
                wr.Flush();
                Console.Write("Nhập họ tên:");
                ht = Console.ReadLine();
                wr.WriteLine(ht);
                wr.Flush();
                Console.Write("Ngày sinh:");
                ngay = DateTime.Parse(Console.ReadLine());
                wr.WriteLine(ngay);
                wr.Flush();
                Console.Write("Lớp:");
                lh = Console.ReadLine();
                wr.WriteLine(lh);
                wr.Flush();
                Console.Write("Số tiết:");
                sth = int.Parse(Console.ReadLine());
                wr.WriteLine(sth);
                wr.Flush();
                Console.Write("Học phí 1 tiết:");
                hp1t = double.Parse(Console.ReadLine());
                wr.WriteLine(hp1t);
                wr.Flush();
                HocVien nv = new HocVien(ms, ht, ngay, sth, lh, hp1t);
                ls.Add(nv);
                break;
            }

            Console.WriteLine("Ds sinh viên sau khi thêm: ");
            ls.Sort(hv1);
            foreach (HocVien hv in ls)
                Console.WriteLine(hv.ToString());
            // Xóa
            for (byte j = 0; j < ls.Count; j++)
                if (ls[j].sth == 0)
                {
                    ls.RemoveAt(j);
                    break;
                }
            Console.WriteLine("");
            Console.WriteLine("Ds sinh viên sau khi xóa:");
            ls.Sort(hv1);
            foreach (HocVien hv in ls)
                Console.WriteLine(hv.ToString());


        }

        public double TinhHP()
        {
                hp = 0;
                if (sth > 50)
                    return hp = sth * hp1t * (double)0.9;
                else
                    return hp = sth * hp1t;
        }
        public override string ToString()
        {
            return "\n" + Ms + " " + Ht + " " + Ns.ToShortDateString() + " " + sth + " " + TinhHP();
        }


    }
    class HocVien1 : IComparer<HocVien>
    {
        public int Compare(HocVien hv1, HocVien hv2)
        {
            if (hv1.Hp < hv2.Hp)
                return 1;
            else if (hv1.Hp == hv2.Hp)
                return 0;
            else
                return -1;
        }

    }
}

