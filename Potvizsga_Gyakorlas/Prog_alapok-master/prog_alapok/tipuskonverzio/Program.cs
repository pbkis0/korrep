using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipuskonverzio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Össze kell adjam a két számot
            //Console.WriteLine(fajlbolSzam + fajlbolMasikSzam); + jel az string összefuzo operátor is !

            //// Aritmetikai
            //int szamInt = 12;
            //double tizedes = szamInt; // dobule tipusba belefér a 12, de az int is mint tipus!

            ////double masikDouble = 12.45;
            ////int masikInt = (int)masikDouble; // Castolás. integere hiába fér bele a 12, de a tipousa mint double az már NEM!

            //double masikDouble = 12.45;
            //int masikInt = Convert.ToInt32(masikDouble);
            //Console.WriteLine(masikInt);

            //// KONVERTÁLÁS


            //string fajlbolSzam = "1112";
            //string fajlbolMasikSzam = "4445";

            //Console.WriteLine(fajlbolSzam + fajlbolMasikSzam); // stringnél a + jel az összefüzés


            //int szam1 = Convert.ToInt32(fajlbolSzam); // "12" stringet átkonvertálja integerré
            //int szam2 = Convert.ToInt32(fajlbolMasikSzam); // 45-öt átkonvertálja intté stringből

            //int osszeg = szam1 + szam2; // Integernél a + jel aritemtikai (összesadás) operátornak veszi

            //Console.WriteLine("Eredmény" + (szam1 + szam2)); precedencia sorrend
            //Console.WriteLine(osszeg);

            // Osztás:

            int sz1 = 10;
            int sz2 = 3;

            double vegeredmeny = (double)sz1 / sz2;//Tipus konverzió/kasztolás/ kényszerítés
            /*2 db inter szám, osztásuk integert ad vissza, viszont a "(double) megadásával, double típusú legyen 
             * végeredményűk.*/
            Console.WriteLine(vegeredmeny);

            Console.ReadKey();
        }
    }
}
