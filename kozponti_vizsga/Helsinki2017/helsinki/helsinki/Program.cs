using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace helsinki
{
    class Program
    {
        static List<Versenyzo> rovidProgram;
        static List<Versenyzo> donto;

        static void FileBeolvasasRovidProgram()
        {
            var sorok = File.ReadAllLines("../../rovidprogram.csv", Encoding.UTF8).Skip(1);

            foreach (var sor in sorok)
            {
                var adat = sor.Split(';');

                string nev = adat[0];
                string orszag = adat[1];
                double technikai = double.Parse(adat[2], CultureInfo.InvariantCulture);
                double komponens = double.Parse(adat[3], CultureInfo.InvariantCulture);
                int levonas = Convert.ToInt32(adat[4]);

                Versenyzo v = new Versenyzo(nev, orszag, technikai, komponens, levonas);
                rovidProgram.Add(v);
            }
        }

        static void FileBeolvasasDonto()
        {
            var sorok = File.ReadAllLines("../../donto.csv", Encoding.UTF8).Skip(1);

            foreach (var sor in sorok)
            {
                var adat = sor.Split(';');

                string nev = adat[0];
                string orszag = adat[1];
                double technikai = double.Parse(adat[2], CultureInfo.InvariantCulture);
                double komponens = double.Parse(adat[3], CultureInfo.InvariantCulture);
                int levonas = int.Parse(adat[4]);

                // int.TryParse(adat[4], out int levonas2);

                /*Ha a bemeneti adatban, ponttal "." - van megadva az adat, akkor kell használni "CultureInfo.InvariantCulture"-
                 * pl: Parse(adat[3], CultureInfo.InvariantCulture); */

                Versenyzo v = new Versenyzo(nev, orszag, technikai, komponens, levonas);
                donto.Add(v);
            }
        }

        static double osszPontaszam(string nev, List<Versenyzo> rovidProgram, List<Versenyzo> donto)
        {
            double sum = 0.0;

            foreach (Versenyzo v in rovidProgram)
            {
                if (v.Nev == nev)
                {
                    sum = (v.Komponens + v.Technikai) - v.Levonas;
                }
            }

            foreach (Versenyzo v in donto)
            {
                if (v.Nev == nev)
                    sum += (v.Komponens + v.Technikai) - v.Levonas;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            rovidProgram = new List<Versenyzo>();
            donto = new List<Versenyzo>();

            FileBeolvasasDonto();
            FileBeolvasasRovidProgram();


            //2. feladat
            Console.WriteLine("2. feladat\n\tA rövid programban " + rovidProgram.Count + " induló volt.");

            //3. feladat
            foreach (var v in donto) // in -után mindig a kollekció/list-át kell megadni. (Amin végig megyek)
            {
                if (v.Orszag == "HUN")
                {
                    Console.WriteLine("3. feladat\n\tA magyar versenyző bejutott a kűrbe.");
                }
            }

            //5. feladat
            string vanBenne = "Nincs ilyen versenyzo!";
            string nev = Console.ReadLine();
            foreach (var versenyzo in rovidProgram)
            {
                if (versenyzo.Nev == nev)
                {
                    vanBenne = versenyzo.Nev;
                }

            }
            Console.WriteLine(vanBenne);

            //6.feladat
            double osszpontszam = osszPontaszam(vanBenne, rovidProgram, donto);
            Console.WriteLine("6. feladat\n\tA versenyzo osszpontszáma: " + osszpontszam);

            //7.feladat
            SortedSet<string> orszagok = new SortedSet<string>();
            foreach (var versenyzo in donto)
            {
                orszagok.Add(versenyzo.Orszag);
            }

            foreach (var orszag in orszagok)
            {
                int versenyzokSzama = 0;

                foreach (var v in donto)
                {
                    if (v.Orszag == orszag)
                    {
                        versenyzokSzama++;
                    }
                }

                if (versenyzokSzama > 1)
                {
                    Console.WriteLine(orszag + ":" + versenyzokSzama + " versenyzők\n");
                }
            }

            //8. feladat

            int helyezes = 1;
            string fajlba = "";


            foreach (var v in donto)
            {
                fajlba += helyezes++ + ";" + v.Nev + ";" + v.Orszag + ";" + osszPontaszam(v.Nev, rovidProgram, donto) + "\n";
            }

            File.WriteAllText("../../vegeredmeny.csv", fajlba, Encoding.UTF8);

            Console.ReadKey();
        }
    }
}
