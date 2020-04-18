using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTHK1
{
    class ve1chieu
    {
        string ma, tuyen;
        DateTime ngay;      
        double kc, gia;
        
        public ve1chieu(string ma = "", DateTime ngay = new DateTime(), string tuyen = "", double kc = 0, double gia = 0)
        {
            this.ma = ma; this.tuyen = tuyen; this.kc = kc; this.gia = gia; this.ngay = ngay;
        }

        public string Tuyen { get => tuyen; set => tuyen = value; }
        public string Ma { get => ma; set => ma = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public double Kc { get => kc; set => kc = value; }
        public double Gia { get => gia; set => gia = value; }

        public override string ToString()
        {
            return "\n" + ma + " " + tuyen + " " + ngay.ToShortDateString() + " " + kc + " " + gia;
        }

    }
}
