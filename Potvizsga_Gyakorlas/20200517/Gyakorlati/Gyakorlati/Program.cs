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
            CegService cegService = new CegService();

            //Munkavezeto munkavezeto = new Munkavezeto(3, "Miklós Árpád");
            //Telephely t = new Telephely("Olajos ház");

            //cegService.hozzaadMunkavezeto(munkavezeto, "Szilánk");
            //cegService.hozzaadTelephely(t);


            // Juhász Bence dolgozó Újszegedről átkerül Szilánkba

            cegService.athelyezDolgozo("Juhász Bence", "Újszeged", "Szilánkba");



            Console.ReadKey();
        }
    }
}
