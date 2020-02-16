using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamlalo_vezerelt_ciklus_for_ciklus
{
    class Program
    {
        static void Main(string[] args)
        {
            //// számláló-vezérelt ciklus: egyszer biztos lefut - HA JÓL DEKLARÁLOD !!!

            //// int szamlalo = 0 -> ciklusváltozó
            //// szamlalo < 10 -> feltétel
            //// szamlalo++ -> léptetés
            //// szamlalo (szamlalo = szamlalo+1, szamlalo+=1, szamlalo++)
            //// szamlalo (szamlalo = szamlalo+2, szamallo+=2) 2 helyett bármely szám kerülhet oda
            //for (int szamlalo = 1; szamlalo <= 10; szamlalo++) // ciklusfej -> legelső ciklusfutás során nincs léptetés
            //{
            //    // Ciklusmag
            //    Console.WriteLine(szamlalo);
            //}

            //// 1. ciklusfutásnál: int szamlalo = 0; szamlalo < 10; ezek futnak le
            //// második ciklusfutásl: szamlalo++; szamlalo < 10;

            //for (int szamlalo = 1; szamlalo <= 20; szamlalo += 4)
            //{
            //    // Ciklusmag
            //    Console.WriteLine(szamlalo);
            //}

            //// for-ciklus tömbökkel

            //int[] szamok = { 1, 4, 734, 13, 5, 57, 789, 78, 4, 34 };//0.-tól indexálódik


            //// szamok.Length = 10
            //for (int index = 0; index < szamok.Length; index++)
            //{
            //    // ciklusmag
            //    Console.WriteLine(szamok[index]); // számok[0], számok[4], stb.
            //}

            //string[] nevek = { "Foxi", "Maxi", "Taxi", "Rex", "Oxi", "Poxy" };

            //for (int indexSzam = 0; indexSzam < nevek.Length; indexSzam += 3)
            //{
            //    Console.WriteLine(nevek[indexSzam]);
            //}

            // FONTOS: FOR-CIKLUS AZ JÓ OLVASÁSA + ÍRÁSRA !!!

            // TÖMB FELTÖLTÉSE
            int[] szamok = new int[2]; // 2 elemű tömb, 0. és 1. indexe lesz!!!

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }

            //for (int i = 0; i < szamok.Length; i++)
            //{
            //    Console.WriteLine(szamok[i]);
            //}

            // bejárós ciklusnak, nem lehet léptetni (nem számlálóvezérelt) és
            // elejétől a végéig lefut, egyesével !!!
            foreach (int szam in szamok) // nem kell indexelni
            {
                Console.WriteLine(szam); // nem indexeljek!!
            }

            Console.ReadKey();
        }
    }
}
