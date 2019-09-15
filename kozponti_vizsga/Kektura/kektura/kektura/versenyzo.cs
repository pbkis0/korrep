using System;
using System.Collections.Generic;
using System.Text;

namespace kektura
{
    public class versenyzo
    {
        public string TuraKiinduloPont { get; set; }

        public string TuraVegPont { get; set; }

        public double TuraszakaszHossza { get; set; }

        public double EmelkedesOsszege { get; set; }

        public double LejtesekOsszege { get; set; }

        public bool Pecsetelohely { get; set; }

        public versenyzo(string turaKiinduloPont, string turaVegPont, double turaszakaszHossz, double emelkedesOsszege, double lejtesekOsszege, bool pecsetelohely)
        {
            TuraKiinduloPont = turaKiinduloPont;
            TuraVegPont = turaVegPont;
            TuraszakaszHossza = turaszakaszHossz;
            EmelkedesOsszege = emelkedesOsszege;
            LejtesekOsszege = lejtesekOsszege;
            Pecsetelohely = pecsetelohely;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
