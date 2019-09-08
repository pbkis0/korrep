using System;
using System.Collections.Generic;
using System.Text;

namespace helsinki
{
    public class Versenyzo
    {
        public string Nev { get; set; }

        public string Orszag { get; set; }

        public double Technikai { get; set; }

        public double Komponens { get; set; }

        public int Levonas { get; set; }

        public Versenyzo(string nev, string orszag, double technikai, double komponens, int levonas)
        {
            Nev = nev;
            Orszag = orszag;
            Technikai = technikai;
            Komponens = komponens;
            Levonas = levonas;
            //Kivülről jövő lista, egyenlő a belső listával.
            //A kintről jövő adatot adja értékül a listának.
        }

        public override string ToString()
        {
            return Nev + " " + Orszag + " " + Technikai + " " + Komponens + " " + Levonas;

        }

    }
}
