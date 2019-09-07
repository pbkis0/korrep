using System;
using System.Collections.Generic;
using System.Text;

namespace Helsinki2017
{
    public class Versenyzo
    {
        public string Nev { get; set; }

        public string Orszag { get; set; }

        public string Techinikai { get; set; }

        public string Komponens { get; set; }

        public List<int> levonas { get; set; }

        public Versenyzo(string nev, string orszag, string technikai, string komponens, List<int> levonas)
        {
            Nev = new;
            Orszag = orszag;
            Techinikai = technikai;
            Komponens = komponens;
            this.levonas = levonas;
            //Kivülről jövő lista, egyenlő a belső listával.
            //A kintről jövő adatot adja értékül a listának.
        }

        public override string ToString()
        {
            return Nev + " " + Orszag + " " + Techinikai + " " + Komponens;

        }

    }
}
