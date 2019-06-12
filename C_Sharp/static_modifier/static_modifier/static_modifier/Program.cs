using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;
using System.IO;

namespace static_modifier
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Shop shop1 = new Shop("Vegyesbolt", 10);
            Shop shop2 = new Shop("Gyógyszertár", 11);

            Shop.novelPeldanyokSzamat();

            Shop shop3 = new Shop("Hentes", 100);


            Console.WriteLine(Shop.GetPeldanyokSzama());

            Console.ReadKey();
        }
    }
}
