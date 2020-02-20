using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Kemia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<KemiaElem> elemek = new List<KemiaElem>();

            var sorok = File.ReadAllLines("../../felfedezesek.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (var sor in sorok)
            {
                var adatok = sor.Split(';');
                KemiaElem e = new KemiaElem();
                e.ev = adatok[0];
                e.elem = adatok[1];
                e.vegyjel = adatok[2];
                e.rendszam = Convert.ToInt32(adatok[3]);
                e.felfedezo = adatok[4];

                elemek.Add(e);
    
            }

            /*3.Feladat */
            /*Lista elemeinek összeg */
            Console.WriteLine($"3.feladat: Elemek száma: {elemek.Count} ");

            /*4.feladat */
            /*Összegzés tétele */

            int okordb = 0;

            foreach (var e in elemek)
            {
                if (e.ev == "Ókor")
                {
                    okordb++;
                }

            }
            Console.WriteLine($"4. Feladat: Felfedezések száma az Ókorban: {okordb}");

            ///*5. feladat */
            //var minta = @"[a-zA-Z]";
            //string vegyjel = "";
            //do
            //{
            //    Console.WriteLine("Kérek egy vegyjelet: ");
            //    vegyjel = Console.ReadLine();
            //} while (vegyjel.Length > 2 || vegyjel.Length <= 0 || !Regex.IsMatch(vegyjel, minta));

            /*6. feladat */
            string vegyjel = "Sg";

            foreach (var e in elemek)
            {
                if (e.vegyjel == vegyjel)
                {
                    Console.WriteLine(e.elem);
                }
            }

            /* 7. feladat*/
            int minEv = int.MaxValue;
            int maxEv = int.MinValue;

            /*Minimum, maximum szűrés */
            for (int i = 9; i < elemek.Count; i++)
            {
                if (minEv > Convert.ToInt32(elemek[i].ev))
                {
                    minEv = Convert.ToInt32(elemek[i].ev);
                }
            }

            for (int i = 9; i < elemek.Count; i++)
            {
                if (maxEv < Convert.ToInt32(elemek[i].ev))
                {
                    maxEv = Convert.ToInt32(elemek[i].ev);
                }
            }

            Console.WriteLine(maxEv-minEv);

            Console.ReadKey();
        }
    }
}
