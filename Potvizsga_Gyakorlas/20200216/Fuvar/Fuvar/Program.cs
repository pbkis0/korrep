using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fuvar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<FuvarModell> fuvarok = new List<FuvarModell>();

            var sorok = File.ReadAllLines("../../fuvar.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (var sor in sorok)
            {
                var adatok = sor.Split(';'); //Soroakt darabolja fel ';' mentén.
                FuvarModell f = new FuvarModell();
                f.taxi_id = Convert.ToInt32(adatok[0]);
                f.indulas = adatok[1];      //Fileból stringként jön be az adat, -> Ami nem string azokat át kell konvertálni a megfelelő típusbara kell hozni a modell szerint.
                f.idotartam = Convert.ToInt32(adatok[2]);
                f.megtettTavolsag = Convert.ToDouble(adatok[3]);
                f.viteldij = Convert.ToDouble(adatok[4]);
                f.borravalo = Convert.ToDouble(adatok[5]);
                f.fizetesModja = adatok[6];

                fuvarok.Add(f); //A fileból jövő adatokat mentem le a listába.
                                //File beolvasás vége

            }

            /*3.feladat */

            /*Lista elmeinek darabszámát adja vissza */
            Console.WriteLine("3. feladat: " + fuvarok.Count + " fuvar");

            /*4 feladat */
            double bevetel = 0;
            int fuvarokdb = 0;

            foreach (var f in fuvarok)
            {
                if (f.taxi_id == 6185)
                {
                    bevetel += (f.viteldij + f.borravalo);
                    fuvarokdb++;
                }               

            }
            Console.WriteLine($"4. feladat: {fuvarokdb} fuvar alatt: {bevetel}dollárjel");

            /*5.feladat*/
            int bankkartya = 0;
            int keszpenz = 0;
            int vitatott = 0;
            int ingyenes = 0;
            int ismeretlen = 0;

            foreach (var f in fuvarok)
            {
                if (f.fizetesModja == "bankkártya")
                {
                    bankkartya++;
                }
                else if (f.fizetesModja == "készpénz")
                {
                    keszpenz++;
                }
                else if (f.fizetesModja == "vitatott")
                {
                    vitatott++;
                }
                else if (f.fizetesModja == "ingyenes")
                {
                    ingyenes++;
                }
                else
                    ismeretlen++;
            }

            Console.WriteLine($"5.feladat:");
            Console.WriteLine($"Bankkártya: {bankkartya}");
            Console.WriteLine($"Készpént: {keszpenz}");
            Console.WriteLine($"Vitatott: {vitatott}");
            Console.WriteLine($"Ingyenes: {ingyenes}");
            Console.WriteLine($"Ismeretlen: {ismeretlen}");

            /*6. feladat
             * Összegzés tétele*/
            double osszesMerfold = 0;
            
            foreach (var f in fuvarok)
            {
                osszesMerfold += f.megtettTavolsag;
            }

            // fuvarok.Sum(x => x.megtettTavolsag); LAMBDA

            double ossesKm = osszesMerfold * 1.6;

            Console.WriteLine($"6. feladat: {ossesKm.ToString("0.00")}");
            /*ToString("0.00) -> A ToString metódus a számot a megadott minta szerinti tizedesjegyre kerekítve jeleníti meg */

            /*7. feladat */
            /*Maximum keresés tétele */
            int maxidotartam = 0;
            //int maxidotartam = int.MinValue;
            //int minidotartam = int.MaxValue;
            foreach (var f in fuvarok)
            {
                if (maxidotartam < f.idotartam)
                {
                    maxidotartam = f.idotartam;
                }
            }

            //int MAXIDO = fuvarok.Max(x => x.idotartam); /*LAMBDA kifejezés */
             

            foreach (var f in fuvarok)
            {
                if (f.idotartam == maxidotartam)
                {
                    Console.WriteLine($"7.feladat: Leghosszabb fuvar:");
                    Console.WriteLine($"Fuvar hossza: {maxidotartam} másodperc");
                    Console.WriteLine($"Taxi azonosito: {f.taxi_id}");
                    Console.WriteLine($"Megtett távolság: {f.megtettTavolsag} km");
                    Console.WriteLine($"Viteldíj: {f.viteldij} dollárjel");
                    break;
                }


            }

            /*8.feladat*/

            string fajlba = "taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja\n";
            foreach (var f in fuvarok)
            {
                if (f.idotartam > 0 && f.viteldij > 0 && f.megtettTavolsag == 0)
                {
                    fajlba += $"{f.taxi_id};{f.indulas};{f.idotartam};{f.megtettTavolsag};{f.viteldij};{f.borravalo};{f.fizetesModja}\n";
                }
            }

            File.WriteAllText("../../hibak.txt", fajlba, Encoding.UTF8);

            Console.ReadKey();
        }
    }
}
