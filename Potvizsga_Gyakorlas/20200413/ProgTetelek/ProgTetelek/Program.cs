using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsszegzesTetel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1) ÖSSZEGZÉS TÉTEL: számok értékeinek az összeadása

            //Tömb
            int[] szamokTombje = { 45, 258, 23, 45, 98, 76, 456, 712 };
            int szamokTombjeSUM = 0;

            foreach (int szam in szamokTombje)
            {
                // tartalmazni fogja a ciklusfutástól függően a szamok ciklusváltozó a tömb egy adott számának az értékét
                szamokTombjeSUM += szam;
            }

            Console.WriteLine(szamokTombjeSUM);

            //Lista
            List<int> szamokListaja = new List<int> { 45, 258, 23, 45, 98, 76, 456, 712 };
            int szamokListajaSUM = 0;

            foreach (int szam in szamokListaja)
            {
                // tartalmazni fogja a ciklusfutástól függően a szamok ciklusváltozó a tömb egy adott számának az értékét
                szamokListajaSUM += szam;
            }

            Console.WriteLine(szamokListajaSUM);

            //Fájl
            List<string> szamokFajl = File.ReadAllLines("../../szamok.txt").ToList();
            int szamokFajlSUM = 0;

            foreach (string szam in szamokFajl)
            {
                // tartalmazni fogja a ciklusfutástól függően a szamok ciklusváltozó a tömb egy adott számának az értékét
                szamokFajlSUM += Convert.ToInt32(szam);
            }

            Console.WriteLine(szamokFajlSUM);


            Console.WriteLine("LINQ: " + szamokListaja.Sum()); // LISTÁNÁL (AZAZ GENERIKUS, BEÉPÍTETT KOLLEKCIÓ) MŰKÖDIK


            Console.ReadKey();
        }
    }
}
