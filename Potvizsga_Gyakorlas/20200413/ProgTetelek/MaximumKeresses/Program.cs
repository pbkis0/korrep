using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumKeresses
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5) MAXIMUM TÉTEL: egy adatszerkezet legnagyobb elemét keressük

            //Tömb
            int[] jegyekTombje = { 1, 2, 3, 4, 5 };

            // int max = 0;
            //int max = jegyekTombje[0]; ÁLTALÁBAN AZ IS JÓ, HOGY EGY SZÁMSOROZAT ELSŐ ELEMÉT KIJELÖLJÜK MINIMUMNAK
            int max = int.MinValue; // kis szám
            // O(n) -> lineáris időbonyolultságú  algoritmus
            foreach (int jegy in jegyekTombje)
            {
                if (jegy > max)
                {
                    max = jegy;
                }
            }

            Console.WriteLine("Legkisebb elem: " + max);

            //Lista
            List<int> jegyekListaja = new List<int> { 1, 2, 3, 4, 5 };
            //int min = jegyekListaja[0]; ÁLTALÁBAN AZ IS JÓ, HOGY EGY SZÁMSOROZAT ELSŐ ELEMÉT KIJELÖLJÜK MINIMUMNAK
            int maximumSzamListaban = int.MinValue; // nagy szám

            foreach (int jegy in jegyekTombje)
            {
                if (jegy > maximumSzamListaban)
                {
                    maximumSzamListaban = jegy;
                }
            }

            Console.WriteLine(maximumSzamListaban);

            //LINQ + LISTA
            Console.WriteLine("LINQ + lambda: " + jegyekListaja.Max());
            Console.ReadKey();
        }
    }
}
