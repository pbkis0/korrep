using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MINDEN
{

    public class Program // EGY OSZTÁLY MINDIG PUBLIC (access modifier)
    {
        public static void Main(string[] args)
        {
            // Main metódus, az a belépési pontja a program futásának.
            // Innen indul a szekvenciális program végrehajtás
            // TESZT JELLEG:

            // OOP: osztályok kommunikációja

            // kell egy Racer objektum

            // Egy osztályból végtelen számú példányt/objektumot hozhatunk létre
            // (típus) Racer,
            //(azonosító) r1,
            // (értékadó operátor) =,
            // "new" kulcsszó -> Heap-en helyet foglal az objektumnak
            // konsturktorhívás
            Racer r1 = new Racer(1, "Sumáher", 30, 1300);
            Racer r2 = new Racer(2, "Bottas", 20, 1500);
            Racer r3 = new Racer(3, "Verstappen", 18, 2000);

            Console.WriteLine(r1.ToString());
            Console.WriteLine(r2.ToString()); // explicit -> ráerőszakolás
            Console.WriteLine(r3); // ToString ráhívódik implicit ->kérés nélkül

            Racer cselesRacer = new Racer(-5, "", -1, -3000);

            Console.WriteLine(cselesRacer.ToString());


            Console.WriteLine("r1 objektum neve: " + r1.getName());
            Console.WriteLine("r2 objektum neve: " + r2.getName());
            Console.WriteLine("r3 objektum neve: " + r3.getName());

            Console.WriteLine("r1 objektum életkora: " + r1.getAge());
            Console.WriteLine("r2 objektum életkora: " + r2.getAge());
            Console.WriteLine("r3 objektum életkora: " + r3.getAge());

            Console.WriteLine("r1 objektum azonosítója: " + r1.getId());
            Console.WriteLine("r2 objektum azonosítója: " + r2.getId());
            Console.WriteLine("r3 objektum azonosítója: " + r3.getId());

            Console.WriteLine("r1 objektum fizetése: " + r1.getSalary());
            Console.WriteLine("r2 objektum fizetése: " + r2.getSalary());
            Console.WriteLine("r3 objektum fizetése: " + r3.getSalary());

            r1.setName("Gábor");
            Console.WriteLine("r1 neve: " + r1.getName());


            Console.ReadKey();
        }
    }
}
