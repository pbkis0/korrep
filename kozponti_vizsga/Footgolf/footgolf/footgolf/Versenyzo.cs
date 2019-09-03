using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footgolf
{
    public class Versenyzo
    {
        public string Nev { get; set; }  //get-ret és set-tterként és müködnek.
        public string Kategoria { get; set; }
        public string Egyesulet { get; set; }

        public List<int> fordulok { get; set; }

        //két enter, és konstruktor generálása. oldalt jelennjen meg az ikon,és azzal generálni a konstruktort.
        public Versenyzo(string nev, string kategoria, string egyesulet, List<int> fordulok)
        {
            Nev = nev;
            Kategoria = kategoria;
            Egyesulet = egyesulet;
            this.fordulok = fordulok;
            // kivülről jövö lista, egyenlő belső listával.
            // (A kintről jövő adatot adja értékül adja neki.)
        }

        public override string ToString()
        {
            return Nev + " " + Kategoria + " " + Egyesulet;
        }
    }
}
