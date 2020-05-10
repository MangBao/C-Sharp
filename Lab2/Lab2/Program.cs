using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class BT1
    {
        static void bai4()
        {
            string s;
            int col, row;
            Console.Write("Nhap chuoi: ");
            s = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap cot: ");
            col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap hang: ");
            row = Convert.ToInt32(Console.ReadLine());
            chuoi c = new chuoi();
            c.hienthi();
            c.RunChu();

        }
        static void bai3()
        {
            string ma, ten;
            bool gioitinh;
            DateTime ngaysinh;
            Console.Write("Ho ten: ");
            ten = Convert.ToString(Console.ReadLine());
            Console.Write("Ma so sinh vien: ");
            ma = Convert.ToString(Console.ReadLine());
            Console.Write("Nam sinh : ");
            ngaysinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Gioi tinh: ");
            gioitinh = bool.TryParse(Console.ReadLine(), out gioitinh);
            Student sv = new Student();
            sv.xuat();
        }
        static void bai2()
        {
            byte n;
            Console.WriteLine("So phan tu mang: ");
            n = byte.Parse(Console.ReadLine());
            Array m = new Array();
            m.Xuat();
            m.TinhTBC();
        }
        static void bai1()
        {
            int a, b, c;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = int.Parse(Console.ReadLine());
            PTB2 pt = new PTB2(a, b, c);
            pt.GiaiPTB2();
        }
        static void Main(string[] args)
        {
            //bai4();
            //bai3();
            //bai2();
            bai1();            
            Console.ReadKey();
        }
    }
        
}
