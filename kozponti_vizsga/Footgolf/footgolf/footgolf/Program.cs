using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footgolf
{
    class Program
    {
        static List<Versenyzo> versenyzok;

        static void FileBeolvasas()
        {
            var sorok = File.ReadAllLines("../../fob2016.txt", Encoding.UTF8).ToList();
            //A file-t beolvassuk egy string tömbe, és átalakítjuk List-ba

            foreach (var sor in sorok) //Típus, változó név, in hol megyek rajta végig (adatok)
            {
                var adat = sor.Split(';');

                string nev = adat[0];
                string kategoria = adat[1];
                string egyesulet = adat[2];

                List<int> fordulok = new List<int>();
                fordulok.Add(Convert.ToInt32(adat[3]));
                fordulok.Add(Convert.ToInt32(adat[4]));
                fordulok.Add(Convert.ToInt32(adat[5]));
                fordulok.Add(Convert.ToInt32(adat[6]));
                fordulok.Add(Convert.ToInt32(adat[7]));
                fordulok.Add(Convert.ToInt32(adat[8]));
                fordulok.Add(Convert.ToInt32(adat[9]));
                fordulok.Add(Convert.ToInt32(adat[10]));

                //for (int i = 3; i < adat.Length; i++)
                //{
                //    fordulok.Add(Convert.ToInt32(adat[i]));
                //}

                Versenyzo v = new Versenyzo(nev, kategoria, egyesulet, fordulok);
                versenyzok.Add(v);
            }
        }

        /// <summary>
        /// 5. feladat függvénye
        /// </summary>
        /// <param name="versenyzo"></param>
        /// <returns></returns>
        public static int EgyeniOsszpontszam(Versenyzo versenyzo)
        {
            int sum = 0;
            List<int> rendezett = versenyzo.fordulok;
            rendezett.Sort();

            for (int i = 2; i < rendezett.Count; i++)
            {
                sum += rendezett[i];
            }

            if (rendezett[0] != 0) sum += 10;
            if (rendezett[1] != 0) sum += 10;
            return sum;
        }


        /// <summary>
        /// EZ A BELÉPÉSI PONT
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            versenyzok = new List<Versenyzo>();
            FileBeolvasas();

            //3. feladat
            Console.WriteLine("3. feladat: Versenyzok száma: " + versenyzok.Count);

            //4. feladat
            int db = 0;
            foreach (Versenyzo v in versenyzok)
            {
                if (v.Kategoria == "Noi")
                {
                    db++;
                }
            }

            double arany = ((double)db / versenyzok.Count) * 100;

            Console.WriteLine("4. feladat: A női versenyzők aránya: " + arany.ToString("0.00") + "%");

            //5.feladat
            //Nem kell kiiratni az 5. feladatot

            //6. feladat (Maximum keresés tétele!
            Console.WriteLine("6. feladat: A bajnok női versenyző \n ");

            Versenyzo legjobbNoi = null;
            int max = 0;
            foreach (Versenyzo v in versenyzok)
            {
                if (v.Kategoria == "Noi")
                {
                    if (max < EgyeniOsszpontszam(v))
                    {
                        max = EgyeniOsszpontszam(v);
                        legjobbNoi = v;
                    }
                }
            }

            Console.WriteLine("\nNév: " + legjobbNoi.Nev + "\nEgyesület: " + legjobbNoi.Egyesulet + "\nÖsszpontszám: " + max);

            //7.feladat

            string fajlba = null;

            foreach (Versenyzo v in versenyzok)
            {
                if (v.Kategoria == "Felnott ferfi")
                {
                    fajlba += v.Nev +";" + EgyeniOsszpontszam(v) + "\n";
                }
            }

            File.WriteAllText("../../osszpontFF.txt", fajlba, Encoding.UTF8);

            //8. feladat

            SortedDictionary<string, int> statisztika = new SortedDictionary<string, int>();

            int i = 0;
            foreach (Versenyzo v in versenyzok)
            {
                statisztika.Add(v.Egyesulet, i++);
            }

            statisztika.Remove("n.a.");

            foreach (KeyValuePair<string, int> v in statisztika)
            {
                if (v.Value >= 3)
                {
                    Console.WriteLine("\t" + v.Key + " - " + v.Value);
                }
            }


            Console.WriteLine("8. feladat: Egyesület statisztika");


            Console.ReadKey();
        }
    }
}
