using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footgold
{
    public class Versenyzo
    {
      public string Nev { get; set; }
        public string Kategoria { get; set; }
        public string Egyesulet { get; set; }

        public Versenyzo(string nev, string kategoria, string egyesulet)
        {
            Nev = nev;
            Kategoria = kategoria;
            Egyesulet = egyesulet;
        }

        public override string ToString()
        {
            return Nev + " " + Kategoria + " " + Egyesulet;
        }
    }
}
