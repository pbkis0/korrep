using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace helsinki
{
    class Program
    {
        static List<Versenyzo> rovidProgram;
        static List<Versenyzo> donto;

        static void FileBeolvasasRovidProgram()
        {
            var sorok = File.ReadAllLines("../../rovidprogram.csv", Encoding.UTF8).ToList();

            foreach (var sor in sorok)
            {
                var adat = sor.Split(';');

                string nev = adat[0];
                string orszag = adat[1];
                double technikai =Convert.ToDouble(adat[2]);
                double komponens = Convert.ToDouble(adat[3]);
                int levonas = Convert.ToInt32(adat[4]);

                Versenyzo v = new Versenyzo(nev, orszag, technikai, komponens, levonas);
                rovidProgram.Add(v);
            }
        }

        static void FileBeolvasasDonto()
        {
            var sorok = File.ReadAllLines("../../donto.csv", Encoding.UTF8).ToList();

            foreach (var sor in sorok)
            {
                var adat = sor.Split(';');

                string nev = adat[0];
                string orszag = adat[1];
                double technikai = Convert.ToDouble(adat[2]);
                double komponens = Convert.ToDouble(adat[3]);
                int levonas = Convert.ToInt32(adat[4]);

                Versenyzo v = new Versenyzo(nev, orszag, technikai, komponens, levonas);
                donto.Add(v);
            }
        }
        static void Main(string[] args)
        {
            rovidProgram = new List<Versenyzo>();
            donto = new List<Versenyzo>();

            FileBeolvasasDonto();
            FileBeolvasasRovidProgram();


            //2. feladat
            Console.WriteLine("2. feladat\tA rövid programban " + rovidProgram.Count + "induló volt.");


            Console.ReadKey();
        }
    }
}
