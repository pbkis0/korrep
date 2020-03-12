using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsiki2017
{
    public class Versenyzo
    {
        public string nev { get; set; }
        public string orszag { get; set; }
        public double technika { get; set; }
        public double komponens { get; set; }
        public int levonas { get; set; }

        public override string ToString()
        {
            return nev + " " + orszag + " " + technika + " " + komponens + " " + levonas;
        }


    }
}
