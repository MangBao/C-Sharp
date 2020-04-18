using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab6
{
    class MONHOC
    {
        string ID, NAME;
        int STC;
        public MONHOC(string NAME = " ", string ID = " ", int STC = 0)
        {
            this.ID = ID; this.NAME = NAME; this.STC = STC;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string NAME1 { get => NAME; set => NAME = value; }
        public int STC1 { get => STC; set => STC = value; }


    }

}
