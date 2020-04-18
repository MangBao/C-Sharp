using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class SV
    {
        string maSV;
        string tenSV;
        byte n;//so mon hoc
        Monhoc[] dsmh;
        public SV(string maSV, string tenSV, byte n)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.n = n;
            dsmh = new Monhoc[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap thong tin mon hoc {0}: ", i + 1);
                Console.Write("Nhap ma mon hoc: ");
                string maMH = Console.ReadLine();
                Console.Write("Nhap ten mon hoc: ");
                string tenMH = Console.ReadLine();
                Console.Write("Nhap so don vi hoc trinh: ");
                byte dvht = byte.Parse(Console.ReadLine());
                Console.Write("Nhap ti le kiem tra: ");
                float tlkt = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem kiem tra: ");
                float dktra = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem thi: ");
                float dthi = float.Parse(Console.ReadLine());
                dsmh[i] = new Monhoc(maMH, tenMH, dvht, tlkt, dktra, dthi);
            }
        }
        public float TB_hocky()
        {
            float t1 = 0;//tong diem trung binh * so don vi hoc ttrinh
            byte t2 = 0;//tong so don vi hoc trinh
            foreach (Monhoc m in dsmh)
            {
                t1 += (m.TinhTB() * m.Dvht);
                t2 += m.Dvht;
            }
            return t1 / (float)t2;
        }

        public float TB_tichluy()
        {
            float t1 = 0;//tong diem trung binh * so don vi hoc ttrinh
            byte t2 = 0;//tong so don vi hoc trinh
            foreach (Monhoc m in dsmh)
            {
                if (m.TinhTB() >= 5)
                {
                    t1 += (m.TinhTB() * m.Dvht);
                    t2 += m.Dvht;
                }
            }
            return t1 / (float)t2;
        }

        public byte XetHB()
        {
            byte kt = 1;
            foreach (Monhoc m in dsmh)
            {
                if (m.TinhTB() < 5.5f || m.Dthi < 5.5f)
                {
                    kt = 0;
                    break;
                }
            }
            if (TB_hocky() > 7 && kt == 1)
                return 1;
            return 0;
        }

        public void Info()
        {
            Console.WriteLine();
            Console.WriteLine("Thong tin sinh vien: ");
            Console.WriteLine("Ma so: {0}\nTen: {1}\nDiem TB hoc ky: {2}\nDiem TB tich luy: {3}", maSV, tenSV, TB_hocky(), TB_tichluy());
        }
    }
}
