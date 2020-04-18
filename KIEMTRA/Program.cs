using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KIEMTRA
{
    class Program
    {
        static void KTTH()
        {
            HocVien hv = new HocVien();
            hv.info();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            KTTH();
            Console.ReadKey();
        }
    }
}
