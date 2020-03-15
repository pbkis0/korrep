using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapozo
{
    public class Program : Object
    {
        public static void Main(string[] args)
        {
            // változó: típus (Animal) + azonosító  (a1, a2...) = (értékadó operátor) new Animal(); (new a HEAP-en memóriát foglal) Animal() -> konstruktor hívása
            Animal a1 = new Animal();
            Animal a2 = new Animal();

            Animal a3 = new Animal("Bence", 30,120);

            // . operátorral hívható adattag vagy metódus
            a1.SetName("Foxi Maxi");
            a2.SetName("Pál");

            //Console.WriteLine(a1.SayHello());
            //Console.WriteLine(a2.SayHello());

            Console.WriteLine(a1.GetAge());
            Console.WriteLine(a1.GetAge());


            a1.SetAge(10);
            a2.SetAge(12);

            Console.WriteLine(a1.GetAge());
            Console.WriteLine(a2.GetAge());

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2); // konzol vagy GUI eleve csak stringet tud megjeleníteni, így a .ToString() hívás
            // "Manuálisan" nem kötelező mert automatikusan ráfut


            Console.ReadKey();
        }
    }

    // ----- KONVENCIÓ: EGY OSZTÁLY EGY FÁJL
    public class Animal : Object
    {
        // Való világ modellezéséhez nagyon jó paradigma programozásban
        // adattagok és a rajta végezhető metódusok egységbe vannak zárva: ide ebbe az osztályban van az állat tulajdonságai (adattagjai)
        // és azokkal végezhető dolgok (metódusok: eljárás és függvény)

        // METÓDUSBAN TUDUNK CSAK ALGORITMUST ÍRNI (CIKLUS, ELÁGAZÁS, SWITCH, KIVÉTELDOBÁS, STB...)

        // ADTTAGOK: le kell, ki kell listázzam milyen tulajdonságokkal ruházom fel az osztályomat:
        // ami belőle példányosítás utján objektum (példány) létrejön, mindenki rendelkezni fog vele

        private string name;
        private int age;
        private int weight; // bővítettük egy testsúly adattal

        // HA NEM ÍROK KONSTRUKTOR, AKKOR A FORDÍTÓ CSINÁL EGY ILYEN ÜRES (BLOKKBA {} nincs írva semmi utasítás sorozat), 
        // És paraméterek sincsenek:
        // KONSTRUKTOR CSAK SETTELNI TUD, DE! EGY FÜST ALATT: egy utasítás blokkban besettel mindent
        // PÉLDÁNYOSÍTÁSHOZ KELL A KONSTRUKTOR (MÉG HA NINCS IS) EZÉRT -> minden esetben a konstruktor fut le először
        // KONSTRUKTORBÓL BÁERMENNYI LEHET, 1 feltétele van: PARAMÉTERLISTA NEM LEHET UGYANOLYAN
        public Animal(string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public Animal()
        {

        }

        //public Animal(string name)
        //{
        //    this.name = name;
        //}

        //public Animal(int age)
        //{
        //    this.age = age;
        //}

        // Ha írok egy paraméterezz konstruktort, akkor már nem létezik az üres, amit a fordító létrehozott

        // SETTEREK ÉS GETTEREKET ADATTAGOKRA KÜLÖN ÍROD MEG
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            if (age >= 0)
            {
                this.age = age;
            }
            else
            {
                throw new Exception("Életkor nem lehet negatív szám!");
            }
        }

        public int GetWeight()
        {
            return weight;
        }

        public void SetWeight(int weight)
        {
            this.weight = weight;
        }

        // METÓDUSOK
        public string SayHello()
        {
            return name + " mondja: Hello!";
        }

        public override string ToString()
        {
            return "Állat neve: " + name + ", életkora: " + age;
        }
    }
}
