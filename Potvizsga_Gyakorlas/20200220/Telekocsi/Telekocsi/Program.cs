using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Telekocsi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Auto> Autok = new List<Auto>();

            var sorok = File.ReadAllLines("../../autok.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (var sor in sorok)
            {
                var adatok = sor.Split(';');
                Auto a = new Auto(); //Okjektum
                a.indulas = adatok[0];
                a.cel = adatok[1];
                a.rendszam = adatok[2];
                a.telefonszam = adatok[3];
                a.ferohely = Convert.ToInt32(adatok[4]);

                Autok.Add(a); //Listához házzáadjuk az objektumot.

            }

            List<Igeny> Igenyek = new List<Igeny>();

            var sorokIgenyek = File.ReadAllLines("../../igenyek.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (var sor in sorokIgenyek)
            {
                var adatok = sor.Split(';');
                Igeny i = new Igeny();
                i.azonosito = adatok[0];
                i.indulas = adatok[1];
                i.cel = adatok[2];
                i.szemelyek = Convert.ToInt32(adatok[3]);

                Igenyek.Add(i);


            }



            Console.ReadKey();






        }
    }
}
