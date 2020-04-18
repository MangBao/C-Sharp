using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class HOCVIEN : IComparable<HOCVIEN>
    {
        string ht, ms;
        DateTime ns;
        bool gt;
        double hp;

        public string Ms { get => ms; set => ms = value; }

        //phương thức thiết lập
        public HOCVIEN(string ms = "", string ht = "", bool gt = true, DateTime ngaysinh = new DateTime(), double hp = 0)
        {
            this.ms = ms; this.ht = ht; this.gt = gt; this.ns = ngaysinh; this.hp = hp;
        }
        //phương thức xuất
        public override string ToString()
        {
            if (gt)
                return ms + " " + ht + " nam " + ns.ToShortDateString() + " " + hp;
            else
                return ms + " " + ht + " nu " + ns.ToShortDateString() + " " + hp;
        }
        //phương thức so sánh
        public int CompareTo(HOCVIEN h)
        {
            if (hp > h.hp) return 1;
            else if (hp == h.hp) return 0;
            else return -1;
        }
    /*public class HOCVIEN1 : IComparer<HOCVIEN>
        {
            public HOCVIEN1()
            {

            }
            public int Compare(HOCVIEN hv1, HOCVIEN hv2)
            {
                if (hv1.hp > hv2.hp) return 1;
                else if (hv1.hp == hv2.hp) return 0;
                else return -1;
            }
        }*/
        
        
    }
}
