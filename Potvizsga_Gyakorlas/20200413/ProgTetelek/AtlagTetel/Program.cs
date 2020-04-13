using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlagTetel
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3) ÁTLAG TÉTEL: számokat átlagolunk

            //Tömb
            int[] jegyekTombje = { 5, 3, 4, 5, 2, 3, 1, 1, 2, 3, 4, 5, 5 };

            //1. összegzem a jegyeket (ÖSSZEGZÉS TÉTEL)
            int jegyekOsszege = 0;
            //2. majd osztom az összeget a darabszámmal (ARITMETIKAI OSZTÁS MŰVELET)
            int jegyekDarabszama = jegyekTombje.Length;

            foreach (int jegy in jegyekTombje)
            {
                jegyekOsszege += jegy;
            }

            double jegyekAtlaga = (double)jegyekOsszege / jegyekDarabszama;

            Console.WriteLine(jegyekAtlaga.ToString("0.0"));


            //Lista
            List<int> jegyekListaja = new List<int> { 5, 3, 4, 5, 2, 3, 1, 1, 2, 3, 4, 5, 5 };
            //1. összegzem a jegyeket (ÖSSZEGZÉS TÉTEL)
            int jegyekOsszegeListaban = 0;
            //2. majd osztom az összeget a darabszámmal (ARITMETIKAI OSZTÁS MŰVELET)
            int jegyekDarabszamaListaban = jegyekListaja.Count;

            foreach (int jegy in jegyekListaja)
            {
                jegyekOsszegeListaban += jegy;
            }

            double jegyekAtlagaLista = (double)jegyekOsszegeListaban / jegyekDarabszamaListaban;
            Console.WriteLine(jegyekAtlagaLista.ToString("0.0"));

            //LINQ + LISTA
            Console.WriteLine("LINQ + lambda: " + jegyekListaja.Average().ToString("0.0"));
            

            Console.ReadKey();
        }
    }
}
