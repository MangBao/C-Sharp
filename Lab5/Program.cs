using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void bai1()
        {
            KHOAHOC k = new KHOAHOC();
            /*HOCVIEN1 HV1 = new HOCVIEN1();*/
            k.Xuat();
            Console.Write("Nhập mã số học viên cần tìm:");
            string x = Console.ReadLine();
            k.Tim(x);
            
        }
        static void bai2()
        {
            KHOAHOC1 k = new KHOAHOC1();
            /*HOCVIEN1 HV1 = new HOCVIEN1();*/
            k.Xuat();
            Console.Write("Nhập mã số học viên cần tìm:");
            string x = Console.ReadLine();
            k.Tim(x);
        }
        static void bai3()
        {
            SINHVIEN sv = new SINHVIEN();
            sv.NhapSV();
            
            Console.Write("Điểm trung bình học kỳ: ");
            sv.DiemTBHK();
            sv.XetHB();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            bai1();
            //bai2();
            //bai3();
            Console.ReadKey();
        }
    }
}
