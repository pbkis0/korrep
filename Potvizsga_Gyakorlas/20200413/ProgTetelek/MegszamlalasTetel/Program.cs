using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegszamlalasTetel
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) MEGSZÁMLÁLÁS TÉTEL: valamely kritériumra (feltétel) szűrve darabot számolunk

            //Tömb
            int[] szamokTombje = { 45, 258, 23, 45, 98, 76, 456, 712, 45, 45, 66664, 457578, 2335, 45, 56, 34, 545, 45, 45, 45 };
            int hanyDarabNegyvenOtVanATombben = 0;

            foreach (int szam in szamokTombje)
            {
                if (szam == 45)
                {
                    hanyDarabNegyvenOtVanATombben++;
                }
            }

            Console.WriteLine(hanyDarabNegyvenOtVanATombben);
            
            //Lista
            List<int> szamokListaja = new List<int> { 45, 258, 23, 45, 98, 76, 456, 712, 45, 45, 66664, 457578, 2335, 45, 56, 34, 545, 45, 45, 45 };
            int hanyDarabNegyvenOtVanAListaban = 0;

            foreach (int szam in szamokListaja)
            {
                if (szam == 45)
                {
                    hanyDarabNegyvenOtVanAListaban++;
                }
            }


            Console.WriteLine(hanyDarabNegyvenOtVanAListaban);

            //LINQ
            int db = szamokListaja.Count(szam => szam == 45); // EZ NEM CSAK INTEGERRE MŰKÖDIK
            Console.WriteLine("LINQ + lambda: " + db);

            //LISTA
            List<string> cipok = new List<string> { "piros", "fekete", "fehér", "piros", "kék", "sárga", "kék", "piros" };

            int pirosCipokDarabSzama = 0;

            foreach (string cipo in cipok)
            {
                if (cipo == "piros")
                {
                    pirosCipokDarabSzama++;
                }
            }

            Console.WriteLine("A piros cipők száma: " + pirosCipokDarabSzama);

            //LINQ:
            int pirosDb = cipok.Count(cipo => cipo == "piros");

            Console.ReadKey();
        }
    }
}
