using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5
{
    class MONHOC
    {        
        string maMh;
        string tenMh;
        float diemKt, diemTB;
        float tyLe, diemThi, donVi;

        
        public float TyLe { get => tyLe; set => tyLe = value; }
        public float DiemThi { get => diemThi; set => diemThi = value; }
        public float DonVi { get => donVi; set => donVi = value; }
        public float DiemKt { get => diemKt; set => diemKt = value; }
        public float DiemTB1 { get => diemTB; set => diemTB = value; }

        public void NhapMh()
        {
            /*Console.Write("\nNhap ma mon hoc : ");
            maMh = Console.ReadLine();
            Console.Write("\nNhap ten mon hoc : ");
            tenMh = Console.ReadLine();
            Console.Write("\nNhap don vi tin chi : ");
            donVi = float.Parse(Console.ReadLine());
            Console.Write("\nNhap ty le : ");
            tyLe = float.Parse(Console.ReadLine());
            Console.Write("\nNhap diem kiem tra : ");
            diemKt = float.Parse(Console.ReadLine());
            Console.Write("\nNhap diem thi : ");
            diemThi = float.Parse(Console.ReadLine());*/
            FileStream f = new FileStream("F:\\data1.txt", FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.UTF8);
            // doc cac dong trong file cho toi cuối file                

            while (!rd.EndOfStream)
            {//mỗi lần đọc từ file thông tin của 1 sinh viên đưa vào list
                maMh = rd.ReadLine();
                tenMh = rd.ReadLine();
                donVi = float.Parse(rd.ReadLine());
                tyLe = float.Parse(rd.ReadLine());
                DiemKt = float.Parse(rd.ReadLine());
                diemThi = float.Parse(rd.ReadLine());
            }
        }

        public float DiemTB()
        {
            DiemTB1 = 0;
            DiemTB1 = (tyLe * DiemKt) + ((1 - tyLe) * diemThi);
            return DiemTB1;
        }

        public override string ToString()
        {

            return "\nTen mon hoc: " + tenMh + "\nMa mon hoc : " + maMh + "\nDiem kiem tra : " + DiemKt + "\ndiem thi : " + diemThi + "\nDiem trung binh : " + DiemTB() + "\n";


        }
    }
    
}
