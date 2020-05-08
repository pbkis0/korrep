using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeningWeekend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //2,feladat
            List<NyitoHetvege> nyitohetvege = new List<NyitoHetvege>();

            var sorok = File.ReadAllLines("../../nyitohetvege.txt", Encoding.UTF8).Skip(1).ToList();

            foreach (var sor in sorok)
            {
                var adatok = sor.Split(';');
                NyitoHetvege ny = new NyitoHetvege();
                ny.eredetiCim = adatok[0];
                ny.magyarCim = adatok[1];
                ny.date = adatok[2];
                ny.forgalmazo = adatok[3];
                ny.bevel = Convert.ToInt32(adatok[4]);
                ny.latogato = Convert.ToInt32(adatok[5]);

                nyitohetvege.Add(ny);                 
            }

            //3. Feladat
            Console.WriteLine("3. feladat: Filmek száma az állományban " +nyitohetvege.Count + "db" );

            //4. Feladat

            double bevetelEgyHeti = 0;
            foreach (var ny in nyitohetvege)
            {
                if (ny.forgalmazo == "UIP")
                {
                    bevetelEgyHeti += ny.bevel;
                }
            }

            Console.WriteLine("UIP Duna Film forgalmazó 1, hetes betételének összege:  " + String.Format("{0:n0}", bevetelEgyHeti));

            //5. Feladat

            int MaxLatogato = 0;
            NyitoHetvege nyitoHetvegeObj = null;
            foreach (var ny in nyitohetvege)
            {
                if (MaxLatogato < ny.latogato)
                {
                    MaxLatogato = ny.latogato;
                    nyitoHetvegeObj = ny;
                }
            }

            Console.WriteLine("5. Feladat: Legtöbb látogató az első héten: ");
            Console.WriteLine("\tEredeti cím: "+nyitoHetvegeObj.eredetiCim);
            Console.WriteLine("\tMagyar cím: "+nyitoHetvegeObj.magyarCim);
            Console.WriteLine("\tForgalmazó: "+nyitoHetvegeObj.forgalmazo);
            Console.WriteLine("\tBevétel az első héten:"+nyitoHetvegeObj.bevel);
            Console.WriteLine("\tLátógatok száma: "+nyitoHetvegeObj.latogato + " fő");

            //6 Feladat

            //7. Fealdat
            // key - value
            Dictionary<string, int> filmekCsoportositva = new Dictionary<string, int>();

            foreach (NyitoHetvege ny in nyitohetvege)
            {
                if (filmekCsoportositva.ContainsKey(ny.forgalmazo))
                {
                    filmekCsoportositva[ny.forgalmazo]++;
                }
                else
                {
                    filmekCsoportositva.Add(ny.forgalmazo, 1);
                }
            }

            string tartalom = "forgalmazo;filmekSzama\n";

            foreach (KeyValuePair<string, int> item in filmekCsoportositva)
            {
                if (item.Value > 1)
                    tartalom += item.Key + ";" + item.Value + "\n";
            }

            File.WriteAllText("../../stat.csv", tartalom, Encoding.UTF8);


            Console.ReadKey();


        }
    }
}
