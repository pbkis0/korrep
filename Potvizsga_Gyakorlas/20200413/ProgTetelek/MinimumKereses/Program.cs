using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumKereses
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4) MINIMUM TÉTEL: egy adatszerkezet legkisebb elemét keressük

            //Tömb
            int[] jegyekTombje = { 5, 3, 4, 5, 2, 3, 1, 1, 2, 3, 4, 5, 5 };

            //int min = jegyekTombje[0]; ÁLTALÁBAN AZ IS JÓ, HOGY EGY SZÁMSOROZAT ELSŐ ELEMÉT KIJELÖLJÜK MINIMUMNAK
            int min = int.MaxValue; // nagy szám

            foreach (int jegy in jegyekTombje)
            {
                if (jegy < min)
                {
                    min = jegy;
                }
            }

            Console.WriteLine("Legkisebb elem: " + min);

            //Lista
            List<int> jegyekListaja = new List<int> { 5, 3, 4, 5, 2, 3, 1, 1, 2, 3, 4, 5, 5 };
            //int min = jegyekListaja[0]; ÁLTALÁBAN AZ IS JÓ, HOGY EGY SZÁMSOROZAT ELSŐ ELEMÉT KIJELÖLJÜK MINIMUMNAK
            int minimumSzamListaban = int.MaxValue; // nagy szám

            foreach (int jegy in jegyekTombje)
            {
                if (jegy < minimumSzamListaban)
                {
                    minimumSzamListaban = jegy;
                }
            }

            Console.WriteLine(minimumSzamListaban);

            //LINQ + LISTA
            Console.WriteLine("LINQ + lambda: " + jegyekListaja.Min());


            Console.ReadKey();
        }
    }
}
