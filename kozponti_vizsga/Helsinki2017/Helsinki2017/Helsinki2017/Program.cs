using System;
using System.Collections.Generic;
using System.IO;

namespace Helsinki2017
{
    class Program
    {
        static List<Versenyzo> versenyzok;

        static void FileBeolvasas()
        {
            var sorok = File.ReadAllLines("../../", Encoding.UTF8).ToList();

            foreach (var sor in sorok)
            {
                var adat = sor.Split(';');

                string nev = adat[0];
                string orszag = adat[1];
                string technikai = adat[2];
                string komponens = adat[3];

                Versenyzo v = new Versenyzo()
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");x
        }
    }
}
