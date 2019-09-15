using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesztverseny
{
    public class Program
    {
        static List<Versenyzok> versenyzok;

        static void FileBeolvasas()
        {
            var sorok = File.ReadAllLines("../../valaszok.txt", Encoding.UTF8).Skip(1);

            foreach (var sor in sorok)
            {
                var adatok = sor.Split(' ');

                string kod = adatok[0];
                string valaszok = adatok[1];

                Versenyzok v = new Versenyzok(kod, valaszok);
                versenyzok.Add(v);
            }
        }

        static void Main(string[] args)
        {
            // Entry-point, belépési pont (fordító)

            // Technikai
            versenyzok = new List<Versenyzok>();
            FileBeolvasas();

            // Feladatok:

            // 1. feladat
            Console.WriteLine("1. feladat: Az adatok beolvasása");

            // 2. feladat
            Console.WriteLine("2. feladat: " + versenyzok.Count + " versenyző indult.");

            // 3. feladat
            string kod = Console.ReadLine();
            string valasz = "";

            Console.WriteLine("3. feladat: A versenyző azonosítója = " + kod);

            foreach (var v in versenyzok)
            {
                if (v.Kod == kod)
                {
                    valasz = v.Valaszok;
                }
            }

            Console.WriteLine(valasz + "\t(a versenyző válasza)");

            // 4. feladat


            string helyesValasz = File.ReadAllLines("../../valaszok.txt", Encoding.UTF8)[0];
            Console.WriteLine("4. feladat:\n" + helyesValasz + "\t(a helyes megoldás)");


            Console.ReadKey();
        }
    }
}
