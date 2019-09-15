using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatonkor
{
    public class Versenyzo
    {
        public string Nev { get; set; }

        public double ElsoSzakasz { get; set; }

        public double MasodikSzakasz { get; set; }

        public double HarmadikSzakasz { get; set; }

        public Versenyzo(string nev, double elsoSzakasz, double masodikSzakasz, double harmadikSzakasz)
        {
            Nev = nev;
            ElsoSzakasz = elsoSzakasz;
            MasodikSzakasz = masodikSzakasz;
            HarmadikSzakasz = harmadikSzakasz;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
