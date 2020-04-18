using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Monhoc
    {
        string maMH, tenMH;
        float tlkt, dktra;
        float dthi;
        byte dvht; //so don vi hoc trinh
        public Monhoc(string maMH, string tenMH, byte dvht, float tlkt, float dktra, float dthi)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.dvht = dvht;
            this.tlkt = tlkt;
            this.dktra = dktra;
            this.dthi = dthi;
        }

        public byte Dvht { get => dvht; set => dvht = value; }
        public float Dthi { get => dthi; set => dthi = value; }

        public float TinhTB()
        {
            float tb = 0;
            tb = tlkt * dktra + (1 - tlkt) * dthi;
            return tb;
        }

        public void Xuat()
        {
            float tb = TinhTB();
            Console.WriteLine("Mon: {0}\tDKT: {1}\tDT: {2}\tDTB: {3}", tenMH, dktra, dthi, tb);
        }
    }
}
