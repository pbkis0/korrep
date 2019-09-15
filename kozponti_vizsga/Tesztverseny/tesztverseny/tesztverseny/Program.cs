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
                    break;
                }
            }

            Console.WriteLine(valasz + "\t(a versenyző válasza)");

            // 4. feladat


            string helyesValasz = File.ReadAllLines("../../valaszok.txt", Encoding.UTF8)[0];
            Console.WriteLine("4. feladat:\n" + helyesValasz + "\t(a helyes megoldás)");

            string osszehasonlitas = "";

            for (int i = 0; i < valasz.Length; i++)
            {
                if (valasz[i] == helyesValasz[i])
                {
                    osszehasonlitas += "+";
                }
                else
                {
                    osszehasonlitas += " ";
                }
            }

            Console.WriteLine(osszehasonlitas + "\t(a versenyző helyes válaszai)");

            // 5. feladat

            int sorszam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5. feladat: A feladat sorszáma = " + sorszam);

            int hanyEmbernekLettJo = 0;

            foreach (var v in versenyzok)
            {
                if (v.Valaszok[sorszam - 1] == helyesValasz[sorszam - 1])
                {
                    hanyEmbernekLettJo++;
                }
            }


            double szazalekosEredmeny = hanyEmbernekLettJo / (double)versenyzok.Count * 100;

            Console.WriteLine("A feladatra " + hanyEmbernekLettJo + " fő, a versenyzők " + szazalekosEredmeny.ToString("0.00") + "% adott helyes választ.");

            // 6. feladat

            Console.WriteLine("A versenyzők pontszámának meghatározása");

            Dictionary<string, int> versenyzoPontok = new Dictionary<string, int>();

            for (int i = 0; i < versenyzok.Count; i++)
            {
                int pontszam = 0;

                for (int j = 0; j < helyesValasz.Length; j++)
                {
                    if (versenyzok[i].Valaszok[j] == helyesValasz[j])
                    {
                        if (j <= 4)
                        {
                            pontszam += 3;
                        }
                        else if (j <= 9)
                        {
                            pontszam += 4;
                        }
                        else if (j <= 12)
                        {
                            pontszam += 5;
                        }
                        else
                        {
                            pontszam += 6;
                        }
                    }
                }

                versenyzoPontok.Add(versenyzok[i].Kod, pontszam);
            }

            string fajlba = "";

            foreach (var pont in versenyzoPontok)
            {
                fajlba += pont.Key + " " + pont.Value + "\n";
            }

            File.WriteAllText("../../pontok.txt", fajlba, Encoding.UTF8);

            // 7. feladat

            Console.WriteLine("7. feladat: A verseny legjobbjai:");

            int kor = 1;

            foreach (var v in versenyzoPontok.OrderByDescending(dictionary => dictionary.Value))
            {
                Console.WriteLine(kor + ". díj (" + v.Value + " pont): " + v.Key);
                kor++;
            }

            Console.ReadKey();
        }
    }
}
