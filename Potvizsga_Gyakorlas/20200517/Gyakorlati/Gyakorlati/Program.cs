using Gyakorlati.modell;
using Gyakorlati.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlati
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Munkavezeto m = new Munkavezeto(1, "Kis Balázs");

            //Console.WriteLine(m);

            ////1. lehetőség: setterek használata (2 db függvényhívás)
            ////m.setId(2);
            ////m.setName("Juhász Bence");

            ////2. adattagra lebontva egy füst alatt:
            ////m.frissit(2, "Juhász Bence");

            ////3. objektumba csomagolva frissitek
            //Munkavezeto munkavezeto = new Munkavezeto(2, "Juhász Bence");
            //m.frissit(munkavezeto);

            //Console.WriteLine(m);

            //Munkavezeto m2 = new Munkavezeto(2, "Juhász Bence");
            //Console.WriteLine(m2);

            Munkavezeto m1 = new Munkavezeto(1, "Kis Balázs");
            Munkavezeto m2 = new Munkavezeto(2, "Juhász Bence");

            //Munkavezeto mCopy = new Munkavezeto(m1);

            Telephely szilank = new Telephely("Szilánk");
            szilank.hozzaadMunkavezeto(m1);
            szilank.hozzaadMunkavezeto(m2);

            Telephely ujSzeged = new Telephely("Újszeged");
            //ujSzeged.hozzaadMunkavezeto(m1);
            //ujSzeged.hozzaadMunkavezeto(m2);

            Ceg ikron = new Ceg("Ikron");

            ikron.hozzaadTelephely(szilank);
            ikron.hozzaadTelephely(ujSzeged);

            try
            {
                szilank.modositMunkavezeto("Juhász Bence", "Juhász Bence Zsolt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
