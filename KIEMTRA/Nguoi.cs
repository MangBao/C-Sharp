using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIEMTRA
{
    class Nguoi
    {
        string ms, ht;
        DateTime ns;
        public string Ms { get => ms; set => ms = value; }
        public string Ht { get => ht; set => ht = value; }
        public DateTime Ns { get => ns; set => ns = value; }

        // phương thức thiết lập
        public Nguoi(string ms = " ", string ht = " ", DateTime ns = new DateTime())
        {
            this.ms = ms;
            this.ht = ht;
            this.ns = ns;
        }

        // phương thức xuất
        public override string ToString()
        {
            return "\n" + ms + " " + ht + " " + ns.ToShortDateString();
        }

    }
}
