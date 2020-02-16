using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eloltesztelo_ciklus_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // Azért előltesztelős ciklus,
            // mert nem biztos, hogy lefut
            // elől megnézi a feltétel teljesül-e...

            // Ezzel a legkönyebb végtelen ciklust létrehozni
 //while (true) VÉGTELEN CIKLUS
            //{

            //}


            string nev = "Maxi";
            //int szam = 0;

            while (nev == "Maxi") // logikai kiertékelés
            {
                // Ciklusmag
                // Addig ismétlődik, amíg a feltétel igaz
                //nev = "Maxi";
                Console.WriteLine("Ciklusban vagyunk!");
                nev = "Foxi";
                //break;
            }

            //Console.WriteLine("Kiléptünk a ciklusból");
            //Console.ReadKey();

            //string nev = Console.ReadLine();


            //while (nev == "Foxi") // logikai kiertékelés
            //{
            //    // Ciklusmag
            //    // Addig ismétlődik, amíg a feltétel igaz
            //    Console.WriteLine("Foxit írtál bele");
            //    nev = "Maxi";
            //}

            Console.WriteLine("Ciklusion kívül vagyunk!");
            Console.ReadKey();
        }
    }
}
