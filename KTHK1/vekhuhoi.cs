using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTHK1
{
    class vekhuhoi : ve1chieu
    {
        string tuyen;
        private double kc;
        private double gia;

        public vekhuhoi(string ma = "", DateTime ngay = new DateTime(), double kc = 0, double gia = 0, string tuyen = "") : base(ma, ngay, tuyen, kc, gia)
        {
            this.tuyen = tuyen;
            this.gia = gia;
            this.kc = kc;
        }

        

        public double GIAVE()
        {          
            if (kc < 500)
                return gia + gia * (double)0.75;
            else if (kc >= 500 && kc <= 1000)
                return gia * (double)1.3 + (gia * (double)1.3) * (double)0.75;
            return gia * (double)1.5 + (gia * (double)1.5) * (double)0.75;
        }

        public double VEKHUHOI()
        {

            return 0;
        }

        public override string ToString()
        {
            return "\n" + Ma + " " + Tuyen + " " + Ngay.ToShortDateString() + " " + kc + " " + GIAVE();
        }

    }
    class vekhuhoi1 : IComparer<vekhuhoi> // sử dụng IComparer
    {
        public int Compare(vekhuhoi v1, vekhuhoi v2)
        {
            if (v1.Ngay < v2.Ngay)
                return 1;
            else if (v1.Ngay == v2.Ngay)
                return 0;
            else
                return -1;
        }
    }
}
