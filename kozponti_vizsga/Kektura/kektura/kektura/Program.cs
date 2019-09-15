using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace kektura
{
    class Program
    {
        static List<versenyzo> versenyzok;

        static void FileBeolvasas()
        {
            var sor = File.ReadAllLines("../../kektura.csv", Encoding.UTF8).ToList();

            foreach (var sor in sor)
            {
                var adat = sor.Split(';');

                string turaKiinduloPont = adat[0];
                string turaVegPont = adat[1];
                double turaszakaszHossz = adat[2];
                double emelkedesOsszege = adat[3];
                double lejtesekOsszege = adat[4];
                bool pecsetelohely = adat[5];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
