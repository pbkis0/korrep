using System;
using System.Collections.Generic;
using System.Collections;
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
            //Racer r1 = new Racer(1, "Sumáher", 30, 1300);
            //Racer r2 = new Racer(2, "Bottas", 20, 1500);
            //Racer r3 = new Racer(3, "Verstappen", 18, 2000);

            //Console.WriteLine(r1.ToString());
            //Console.WriteLine(r2.ToString()); // explicit -> ráerőszakolás
            //Console.WriteLine(r3); // ToString ráhívódik implicit ->kérés nélkül

            //Racer cselesRacer = new Racer(-5, "", -1, -3000);

            //Console.WriteLine(cselesRacer.ToString());


            //Console.WriteLine("r1 objektum neve: " + r1.getName());
            //Console.WriteLine("r2 objektum neve: " + r2.getName());
            //Console.WriteLine("r3 objektum neve: " + r3.getName());

            //Console.WriteLine("r1 objektum életkora: " + r1.getAge());
            //Console.WriteLine("r2 objektum életkora: " + r2.getAge());
            //Console.WriteLine("r3 objektum életkora: " + r3.getAge());

            //Console.WriteLine("r1 objektum azonosítója: " + r1.getId());
            //Console.WriteLine("r2 objektum azonosítója: " + r2.getId());
            //Console.WriteLine("r3 objektum azonosítója: " + r3.getId());

            //Console.WriteLine("r1 objektum fizetése: " + r1.getSalary());
            //Console.WriteLine("r2 objektum fizetése: " + r2.getSalary());
            //Console.WriteLine("r3 objektum fizetése: " + r3.getSalary());

            //r1.setName("Gábor");
            //Console.WriteLine("r1 neve: " + r1.getName());

            Racer r1 = new Racer(1, "Sumáher", 30, 1300);
            Racer r2 = new Racer(2, "Bottas", 20, 1500);
            Racer r3 = new Racer(3, "Verstappen", 18, 2000);

            Team team1 = new Team("Ferrari");
            Team team2 = new Team("McLaren");

            team1.addRacer(r1);
            team2.addRacer(r2);
            team2.addRacer(r3);

            //foreach (Racer r in team2.getRacers())
            //{
            //    Console.WriteLine(r.ToString());
            //}

            Racer r4 = new Racer(3, "Verstappen", 19, 3000);

            team2.updateRacer(r4);

            //Console.WriteLine("Kérek egy id-t:");

            //int bekerID = Convert.ToInt32(Console.ReadLine());

            //try
            //{
            //    team2.deleteRacer(bekerID);
            //    Console.WriteLine("Kitörölted a " + bekerID + ". id-jű versenyzőt");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("Add meg a " + team1.getName() + " új nevét!");

            //string ujNev = Console.ReadLine();
            //team1.update(ujNev);

            //Console.WriteLine("A csapat új neve: " + team1.getName());


            //string nev = Console.ReadLine();

            //try
            //{
            //    Racer racer = team2.getRacerByName(nev);
            //    Console.WriteLine(racer);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            // <> -> generikus paraméter lista
            //List<string> versenyzoNevek = new List<string>();

            //foreach (Racer r in team2.getRacers())
            //{
            //    versenyzoNevek.Add(r.getName());
            //}

            //foreach (string nev in versenyzoNevek)
            //{
            //    Console.WriteLine(nev);
            //}

            Console.ReadKey();
        }
    }
}
