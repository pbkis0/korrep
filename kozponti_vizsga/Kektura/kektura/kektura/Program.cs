using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace kektura
{
    class Program
    {
        static List<Versenyzo> versenyzok;

        static void FileBeolvasas()
        {
            var sorok = File.ReadAllLines("../../kektura.csv", Encoding.UTF8).Skip(1);

            foreach (var sor in sorok)
            {
                var adat = sor.Split(';');

                string turaKiinduloPont = adat[0];
                string turaVegPont = adat[1];
                double turaszakaszHossz =double.Parse(adat[2], CultureInfo.InvariantCulture); // tizedesvessző miatt !!!
                double emelkedesOsszege = double.Parse(adat[3], CultureInfo.InvariantCulture);
                double lejtesekOsszege = double.Parse(adat[4], CultureInfo.InvariantCulture);
                string pecsetelohely = adat[5];
                
                Versenyzo v = new Versenyzo(turaKiinduloPont, turaVegPont, turaszakaszHossz, emelkedesOsszege, lejtesekOsszege, pecsetelohely);
                versenyzok.Add(v);
            }
        }
        /// <summary>
        /// 6. feladat
        /// </summary>
        /// <param name="vegpont"></param>
        /// <param name="pecsetelohely"></param>
        /// <returns></returns>
        static bool HianyosNev(string vegpont, string pecsetelohely)
        {
            if (pecsetelohely == "i" && !vegpont.Contains("pecsetelohely"))
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            versenyzok = new List<Versenyzo>();
            FileBeolvasas();
            // 3. feladat
            Console.WriteLine("3. feladat: Szakaszok száma: " +versenyzok.Count + " db");


            //4. feladat
            double teljeshossz = 0;
            foreach (var v in versenyzok)
            {
                teljeshossz += v.TuraszakaszHossza;
            }
            

            Console.WriteLine("4. feladat: A túra teljes hossza: " + teljeshossz + " km");



            // 5. feladat
            //Minimum keresés tételet kell használni
            double min = int.MaxValue;
            Versenyzo versenyzo = null;

            foreach (var v in versenyzok)
            {
                if (v.TuraszakaszHossza < min)
                {
                    min = v.TuraszakaszHossza;
                    versenyzo = v;
                }

            } 

            Console.WriteLine("5. feladat: A legrövidebb szakasz adatai:");
            Console.WriteLine("\tKezdete: "+versenyzo.TuraKiinduloPont);
            Console.WriteLine("\tVége: "+versenyzo.TuraVegPont);
            Console.WriteLine("\tTávolság: "+versenyzo.TuraszakaszHossza);

            //6. feladat -> fentebb megoldva

            //7. feladat
            string hianyosAllomasok = "";
            foreach (var v in versenyzok)
            {
                if (HianyosNev(v.TuraVegPont, v.Pecsetelohely))
                {
                    hianyosAllomasok += v.TuraVegPont + "\n";
                }
            }

            Console.WriteLine("7. feladat: Hiányos állomásnevek: ");

            if (hianyosAllomasok.Length == 0)
            {
                Console.WriteLine("Nincs ilyen állomás!");
            }
            else
            {
                Console.WriteLine(hianyosAllomasok);
            }

            //8.feladat
            int tengerszint =Convert.ToInt32( File.ReadAllLines("../../kektura.csv", Encoding.UTF8)[0]);
            double max = int.MinValue;
            Versenyzo versenyzoMin = null;
            int vegpont = 0;
            foreach (var v in versenyzok)
            {

                if (v.TuraVegPont > max)
                {
                    max
                }
            }

            {

            }

            Console.ReadKey();
        }
    }
}
