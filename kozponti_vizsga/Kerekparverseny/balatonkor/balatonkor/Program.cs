using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatonkor
{
    class Program

        static List<Versenyzo> versenyzok;

    static void FileBeolvasas()
    {
        var sorok = File.ReadAllLines("../../kerekpar.csv", Encoding.UTF8).Skip(1);

        foreach (var sor in sorok)
        {
            var adat = sor.Split(';');

            string nev = adat[0];
            double elszoSzakasz = adat[1];
            double masodikSzakasz = adat[2];
            double harmadikSzakasz = adat[3];
        }
    }

        static void Main(string[] args)
        {
        }
    }
}
