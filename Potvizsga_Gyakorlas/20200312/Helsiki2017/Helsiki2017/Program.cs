using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsiki2017
{
    public class Program
    {
        static List<Versenyzo> donto = new List<Versenyzo>();
        static List<Versenyzo> rovidprogram = new List<Versenyzo>();


        public static double osszpontszam(string nev)
        {
            double sum = 0.0;

            foreach (Versenyzo v in rovidprogram)
            {
                if (v.nev == nev)
                {
                    sum = v.komponens + v.technika - v.levonas;
                }
            }

            foreach (Versenyzo v in donto)
            {
                if (v.nev == nev)
                {
                    sum = 0.0;
                    sum = v.komponens + v.technika - v.levonas;
                }
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            

            List<string> dontoSorok = File.ReadAllLines("../../donto.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (string sor in dontoSorok)
            {
                string[] adatok = sor.Split(';');

                Versenyzo v = new Versenyzo();
                v.nev = adatok[0];
                v.orszag = adatok[1];

                v.technika = double.Parse(adatok[2], CultureInfo.InvariantCulture);
                v.komponens = double.Parse(adatok[3], CultureInfo.InvariantCulture); 
                v.levonas = Convert.ToInt32(adatok[4]);

                donto.Add(v);
            }

            List<string> rovidprogramSorok = File.ReadAllLines("../../rovidprogram.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (string sor in rovidprogramSorok)
            {
                string[] adatok = sor.Split(';');

                Versenyzo v = new Versenyzo();
                v.nev = adatok[0];
                v.orszag = adatok[1];

                v.technika = double.Parse(adatok[2], CultureInfo.InvariantCulture);
                v.komponens = double.Parse(adatok[3], CultureInfo.InvariantCulture);
                v.levonas = Convert.ToInt32(adatok[4]);

                rovidprogram.Add(v);
            }

            /*2. feladat */
            // 
            Console.WriteLine(rovidprogram.Count);

            /*3. feladat */
            foreach (var i in donto)
            {
                if (i.orszag == "HUN")
                {
                    Console.WriteLine("Bejutott");
                }
            }



            

        }
    }
}
