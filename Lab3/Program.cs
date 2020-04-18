using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void bai1()
        {
            string ten;
            int ns;
            double cao, nang;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập tên: ");
            ten = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập năm sinh : ");
            ns = int.Parse(Console.ReadLine());
            Console.Write("Nhập chiều cao: ");
            cao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cân nặng: ");
            nang = Convert.ToDouble(Console.ReadLine());
            SINHVIENK60 k60 = new SINHVIENK60(ten, cao, nang);
            Console.Write("Thông tin: ");
            k60.xuat();
            k60.tanggiam();
        }
        static void bai2()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            PHANSO p1 = new PHANSO(3, 6);
            PHANSO p2 = new PHANSO(9, 3);
            //cộng, trừ, nhân, chia 2 phân số dùng phương thức thành phần
            Console.Write("Cộng 2 phân số dùng phương thức thành phần:");
            PHANSO p3 = new PHANSO();
            p3 = p1.Cong(p2);
            p3 = p3.RutGon();
            p3.Xuat();
            Console.Write("\nTrừ 2 phân số dùng phương thức thành phần:");
            p3 = p1.Tru(p2);
            p3 = p3.RutGon();
            p3.Xuat();
            Console.Write("\nNhân 2 phân số dùng phương thức thành phần:");
            p3 = p1.Nhan(p2);
            p3 = p3.RutGon();
            p3.Xuat();
            Console.Write("\nChia 2 phân số dùng phương thức thành phần:");
            p3 = p1.Chia(p2);
            p3 = p3.RutGon();
            p3.Xuat();
            //dùng toán tử
            Console.Write("\nCộng 2 phân số dùng toán tử:");
            p3 = p1 + p2;
            p3 = p3.RutGon();
            p3.Xuat();
            Console.Write("\nTrừ 2 phân số dùng toán tử:");
            p3 = p1 - p2;
            p3 = p3.RutGon();
            p3.Xuat();
            Console.Write("\nNhân 2 phân số dùng toán tử:");
            p3 = p1 * p2;
            p3 = p3.RutGon();
            p3.Xuat();
            Console.Write("\nChia 2 phân số dùng toán tử:");
            p3 = p1 / p2;
            p3 = p3.RutGon();
            p3.Xuat();
        }
        static void bai3()
        {
            Console.Write("Nhap ma so Sinh vien: ");
            string maSV = Console.ReadLine();
            Console.Write("Nhap ten Sinh vien: ");
            string tenSV = Console.ReadLine();
            Console.Write("Nhap so mon hoc: ");
            byte n = byte.Parse(Console.ReadLine());
            SV sv = new SV(maSV, tenSV, n);
            sv.Info();
            if (sv.XetHB() == 1)
                Console.WriteLine("Du dieu kien xet hoc bong.");
            else
                Console.WriteLine("Khong du dieu kien xet hoc bong.");
        }
        static void Main(string[] args)
        {

            //bai2();
            //bai1();
            bai3();
            Console.ReadKey();
        }
    }
}
