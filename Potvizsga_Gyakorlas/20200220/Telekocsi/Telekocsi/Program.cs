using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Telekocsi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Auto> Autok = new List<Auto>();

            var sorok = File.ReadAllLines("../../autok.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (var sor in sorok)
            {
                var adatok = sor.Split(';');
                Auto a = new Auto(); //Okjektum
                a.indulas = adatok[0];
                a.cel = adatok[1];
                a.rendszam = adatok[2];
                a.telefonszam = adatok[3];
                a.ferohely = Convert.ToInt32(adatok[4]);

                Autok.Add(a); //Listához házzáadjuk az objektumot.

            }

            List<Igeny> Igenyek = new List<Igeny>();

            var sorokIgenyek = File.ReadAllLines("../../igenyek.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (var sor in sorokIgenyek)
            {
                var adatok = sor.Split(';');
                Igeny i = new Igeny();
                i.azonosito = adatok[0];
                i.indulas = adatok[1];
                i.cel = adatok[2];
                i.szemelyek = Convert.ToInt32(adatok[3]);

                Igenyek.Add(i);


            }

            /*2. feladat */
            Console.WriteLine($"2. feladat: {Autok.Count} autós hirdetett fuvart.");

            /*3.feladat */

            /*Megszámlásás tétele */
            int db = 0;

            foreach (var a in Autok)
            {
                if (a.indulas == "Budapest" && a.cel == "Miskolc")
                {
                    db += 1;  // db++
                }
            }
            Console.WriteLine($"3. Feladat: Összesen {db} férőhelyet hirdettek az autósok Budapestről Miskolcra");

            /*4. feladat */
            /*Maximum keresés tétele */

            int max = 0;
            foreach (var a in Autok)
            {
                if (max < a.ferohely)
                {
                    max = a.ferohely;
                }
            }

            foreach (var a in Autok)
            {
                if (a.ferohely == max)
                {
                    Console.WriteLine($"A legtöbb férőhelyeket ({max}) a {a.indulas} - {a.cel} útvonalon ajánlották fel a hirdetők");
                }
            }

            /*5. feladat */

            foreach (var igeny in Igenyek)
            {
                foreach (var auto in Autok)
                {
                    if (igeny.indulas == auto.indulas && igeny.cel == auto.cel && igeny.szemelyek <= auto.ferohely)
                    {
                        Console.WriteLine($"{igeny.azonosito} => {auto.rendszam}");
                    }
                }
            }

            /*6. feladat */

            string fajlba = "";

            foreach (var igeny in Igenyek)
            {
                foreach (var auto in Autok)
                {
                    if (igeny.indulas == auto.indulas && igeny.cel == auto.cel && igeny.szemelyek <= auto.ferohely)
                    {
                        fajlba += $"{igeny.azonosito}: Rendszám: {auto.rendszam}, Telefonszam: {auto.telefonszam}\n";
                    }
                    else
                    {
                        fajlba += $"{igeny.azonosito}: Sajnos nem sikerült autót találni.\n";
                    }
                }
            }
            File.WriteAllText("../../utasuzenetek.txt", fajlba, Encoding.UTF8);

            Console.ReadKey();
        }
    }
}
