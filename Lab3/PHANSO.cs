using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class PHANSO
    {
        int ts, ms;
        public PHANSO(int t = 0, int m = 1)
        {
            ts = t; ms = m;

        }
       //phương thức thành phần
        public PHANSO Cong(PHANSO p)
        {
            PHANSO kq = new PHANSO();
            kq.ts = ts * p.ms + p.ts * ms;
            kq.ms = ms * p.ms;
            return kq;
        }
        public PHANSO Tru(PHANSO p)
        {
            PHANSO kq = new PHANSO();
            kq.ts = ts * p.ms - p.ts * ms;
            kq.ms = ms * p.ms;
            return kq;
        }
        public PHANSO Nhan(PHANSO p)
        {
            PHANSO kq = new PHANSO();
            kq.ts = ts * p.ts;
            kq.ms = ms * p.ms;
            return kq;
        }
        
        public PHANSO Chia(PHANSO p)
        {
            PHANSO kq = new PHANSO();
            kq.ts = ts * p.ms;
            kq.ms = ms * p.ts;
            return kq;
        }
        
        //phân số rút gọn: tử/ước số chung(tử,mẫu) ; mẫu = mẫu/ ước số chung (tử, mẫu)
        int USC(int a, int b)//tìm ước số chung lớn nhất
        {
            a = Math.Abs(a); b = Math.Abs(b);
            int j, ucln = 1;
            if (a < b)
            {
                j = a;
            }
            else
            {
                j = b;
            }
            for(int i=1; i<=j; i++)
            {
                if( a % i == 0 && b % i == 0)
                {
                    ucln = i;
                }
            }
            return ucln;
        }
        public PHANSO RutGon()
        {
            PHANSO kq = new PHANSO();
            kq.ts = ts / USC(ts, ms);
            kq.ms = ms / USC(ts, ms);
            return kq;
        }
        public void Xuat()
        {
            Console.Write("{0}/{1}", ts, ms);
        }
        //toán tử +
        public static PHANSO operator +(PHANSO p1, PHANSO p2)
        {
            PHANSO kq = new PHANSO();
            kq.ts = p1.ts * p2.ms + p2.ts * p1.ms;
            kq.ms = p1.ms * p2.ms;
            return kq;
        }
        //toán tử -
        public static PHANSO operator -(PHANSO p1, PHANSO p2)
        {
            PHANSO kq = new PHANSO();
            kq.ts = p1.ts * p2.ms - p2.ts * p1.ms;
            kq.ms = p1.ms * p2.ms;
            return kq;
        }
        //toán tử *
        public static PHANSO operator *(PHANSO p1, PHANSO p2)
        {
            PHANSO kq = new PHANSO();
            kq.ts = p1.ts * p2.ts;
            kq.ms = p1.ms * p2.ms;
            return kq;
        }
        //toán tử /
        public static PHANSO operator /(PHANSO p1, PHANSO p2)
        {
            PHANSO kq = new PHANSO();
            kq.ts = p1.ts * p2.ms;
            kq.ms = p1.ms * p2.ts;
            return kq;
        }
    }

}
