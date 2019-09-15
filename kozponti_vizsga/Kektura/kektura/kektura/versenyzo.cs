using System;
using System.Collections.Generic;
using System.Text;

namespace kektura
{
    public class Versenyzo
    {
        public string TuraKiinduloPont { get; set; }

        public string TuraVegPont { get; set; }

        public double TuraszakaszHossza { get; set; }

        public double EmelkedesOsszege { get; set; }

        public double LejtesekOsszege { get; set; }

        public string Pecsetelohely { get; set; }

        public Versenyzo(string turaKiinduloPont, string turaVegPont, double turaszakaszHossz, double emelkedesOsszege, double lejtesekOsszege, string pecsetelohely)
        {
            TuraKiinduloPont = turaKiinduloPont;
            TuraVegPont = turaVegPont;
            TuraszakaszHossza = turaszakaszHossz;
            EmelkedesOsszege = emelkedesOsszege;
            LejtesekOsszege = lejtesekOsszege;
            Pecsetelohely = pecsetelohely;
        }

        // Az adott példánynak megjeleniti az adat tagjait! 
        //Mindig kötelező kiirni !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public override string ToString()
        {
            return TuraKiinduloPont + " " + TuraVegPont + " " + TuraszakaszHossza + " " + EmelkedesOsszege + " " + LejtesekOsszege + " " + Pecsetelohely;
        }

    }
}
