using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekocsi
{
    public class Auto
    {
        public string indulas { get; set; }
        public string cel { get; set; }
        public string rendszam { get; set; }
        public string telefonszam { get; set; }
        public int ferohely { get; set; }

        public override string ToString()
        {
            return indulas + " " + cel + " " + rendszam + " " + telefonszam + " " + ferohely;
        }
    }
}
