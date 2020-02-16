using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nobel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Lista, amiben letárolom a beolvasott sorokból készült objektumokat */
            List<NobelModel> nobelModellek = new List<NobelModel>();

            /*File beolvasás */
            var sorok = File.ReadAllLines("../../nobel.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (var sor in sorok) // 923 sor, sor változó ahanyadik sor string, ahol a ciklusfutás éppen tart
            {
                var adatok = sor.Split(';');

                NobelModel n = new NobelModel(); /* int szam = tipus (int) + azonosito (szam), NobelModel (tipus), n (azonositó) */
                n.evszam = Convert.ToInt32(adatok[0]);
                n.típus = adatok[1];
                n.keresztnev = adatok[2];
                n.vezeteknev = adatok[3];

                //NobelModel n = new NobelModel
                //{
                //    evszam = Convert.ToInt32(adatok[0]),
                //    típus = adatok[1],
                //    keresztnev = adatok[2],
                //    vezeteknev = adatok[3]
                //};

                nobelModellek.Add(n);
            }
            /* File beolvasás vége */

            /* 3. feladat. Lineáris keresés */
            string tipus = "";
            foreach (var n in nobelModellek)
            {
                if (n.keresztnev == "Arthur B." && n.vezeteknev == "McDonald")
                {
                    tipus = n.típus;
                    break;
                }
            }

            Console.WriteLine("3. feladat: " + tipus);

            /*4. feladat */
            string nev = "";
            foreach (var n in nobelModellek)
            {
                if (n.evszam == 2017 && n.típus == "irodalmi")
                {
                    nev = n.vezeteknev + " " + n.keresztnev;
                    break;
                }
            }

            Console.WriteLine("4. feladat:"+ nev);

            /* 5.feladat */
            string szervezetek = "";
            foreach (var n in nobelModellek)
            {
                if(n.evszam >=1990 && n.vezeteknev == "")
                {
                    szervezetek += n.evszam + ": " + n.keresztnev + "\n";  /* A +=-hozzáfüzöm a stringhez, a \n új sorba írja a szervezeteket.*/
                }
            }

            Console.WriteLine("5. feladat: " + szervezetek);

            /*6. feladat */
            string kuri = "";
            foreach (var n in nobelModellek)
            {
                if (n.vezeteknev.Contains("Curie")) /* A "Contains" metódus, a paraméterül átadott értékeket keresi, meg.*/
                {
                    kuri += n.evszam + ": " + n.keresztnev + " " + n.vezeteknev + " (" + n.típus + ")\n"; 
                }
            }
            Console.WriteLine("6. feladat:" +kuri);

            /*7.feladat */

            //SortedSet<string> dijKategoriakHalmaza = new SortedSet<string>(); // Halmaz egy elemet csak egyszer tárol

            //foreach (var n in nobelModellek) // 923x lefut a ciklus, kb. 500 az orvosi
            //{
            //    dijKategoriakHalmaza.Add(n.típus);
            //}

            //foreach (var kategoria in dijKategoriakHalmaza)
            //{
            //    Console.WriteLine(kategoria);
            //}

            //int fizikaiDB = 0;
            //int orvosiDB = 0;
            //int bekeDB = 0;
            //int irodalmiDB = 0;

            //foreach (var n in nobelModellek)
            //{
            //    if (n.típus=="fizikai")
            //    {
            //        fizikaiDB++;
            //    }
            //}

            //foreach (var n in nobelModellek)
            //{
            //    if (n.típus == "orvosi")
            //    {
            //        orvosiDB++;
            //    }
            //}

            /*8. feladat */
            string fajlba = "";

            foreach (var n in nobelModellek)
            {
                if (n.típus == "orvosi")
                {
                    fajlba += n.evszam + ":" + n.keresztnev + " " + n.vezeteknev + "\n";
                }
            }

            File.WriteAllText("../../orvosi.txt", fajlba, Encoding.UTF8);

            Console.ReadKey();
        }
    }
}
