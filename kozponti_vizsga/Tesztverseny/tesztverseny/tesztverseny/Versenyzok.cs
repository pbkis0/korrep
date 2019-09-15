using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesztverseny
{
    public class Versenyzok
    {
        public string Kod { get; set; }
        public string Valaszok { get; set; }

        public Versenyzok(string kod, string valaszok)
        {
            Kod = kod;
            Valaszok = valaszok;
        }

        public override string ToString()
        {
            return Kod + " " + Valaszok;
        }
    }
}
