using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // A SWITCH EGY NAGYON HOSSZU IF-ELSE IF-ELSE IF-...VÉGTELENSÉGIG TARTÓ ELSE IF-ELSE HELYETT VAN

            //int szam = Convert.ToInt32(Console.ReadLine()); // Szám bekérés

            //switch (szam) // NEM CSAK SZÁMOT LEHET SWITCHELNI
            //{
            //    case 0: Console.WriteLine("A bekért szám nulla"); // case 0 => szám amit switch-elek az egyenlőe-e 0-val??
            //        break;
            //    case 1: Console.WriteLine("A bekért szám egy");
            //        break;
            //    case 2: Console.WriteLine("A bekért szám kettő");
            //        break;
            //    case 100: Console.WriteLine("A bekért szám száz");
            //        break;
            //    case 66: Console.WriteLine("A szám 66-os");
            //        break;
            //    default:
            //        Console.WriteLine("A bekért szám nem nulla, nem egy és nem is kettő!");
            //        break;
            //}

            string bekertNev = Console.ReadLine();

            switch (bekertNev)
            {
                case "Bence": Console.WriteLine("Bencét írtál be a konzolba"); break;

                case "Balázs": Console.WriteLine("Balázst írtál a konzolba"); break;

                default:
                    Console.WriteLine("A név se nem Bence se nem Balázs");
                    break;
            }

            Console.ReadKey();
        }
    }
}
