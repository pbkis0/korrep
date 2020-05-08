using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatszerkezetek
{
    class Woman
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string HairColor { get; set; }

        public override string ToString()
        {
            return $"A nő neve: {Name}, {Age} éves, {Weight} kg és {HairColor} színű a haja.";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Woman> women = new List<Woman>(); // tömb van belóül, Java: 6 elemű tömböt
            women.Add(new Woman { Name = "Ági", Age = 18, Weight = 60.1, HairColor = "szőke" });
            women.Add(new Woman { Name = "Borbála", Age = 38, Weight = 100, HairColor = "vörös" });
            women.Add(new Woman { Name = "Hajni", Age = 30, Weight = 55, HairColor = "vörös" });
            women.Add(new Woman { Name = "Csenge", Age = 44, Weight = 75.3, HairColor = "barna" });
            women.Add(new Woman { Name = "Klaudia", Age = 22, Weight = 64.4, HairColor = "ősz" });
            women.Add(new Woman { Name = "Rozi", Age = 67, Weight = 94, HairColor = "ősz" });

            women.ForEach(Console.WriteLine); // gyors kiíratás

            // Lista metódusok

            // 1) Add -> mindig a végére szúr be új elemet
            //women.Add(new Woman { Name = "Gizi", Age = 67, Weight = 45, HairColor = "barna" });

            //foreach (Woman woman in women)
            //{
            //    Console.WriteLine(woman);
            //}

            // 2) Count prop. -> lista hossza
            //Console.WriteLine(women.Count);

            // 3) Remove -> kitöröl tartalom alapján, a legelső előfordulást törli ki
            //foreach (Woman woman in women)
            //{
            //    if (woman.Name == "Csenge")
            //    {
            //        women.Remove(woman);
            //        break;
            //    }
            //}

            //Console.WriteLine(women.Count);
            //foreach (Woman woman in women)
            //{
            //    Console.WriteLine(woman);
            //}

            //4) RemoveAt -> index alapján töröl
            //women.RemoveAt(5); //2. elem

            //foreach (Woman woman in women)
            //{
            //    Console.WriteLine(woman);
            //}

            // itt már lambda kifejezést vár a metódus:

            // 5) RemoveAll -> kitöröl minden előfordulású objektumot a listából feletétel alapján
            //women.RemoveAll(x => x.HairColor == "vörös");
            //women.RemoveAll(x => x.Age > 30);
            //women.RemoveAll(x => x.Age > 50);
            //women.RemoveAll(x => x.Name == "Csenge");
            // forEach
            // women.ForEach(Console.WriteLine); // foreach - if nem váltja ki, cdak gyors kiíratásra
            // women.forEach(System.out::println);

            // 6) Exists -> létezik-e adott objektum feltétel alapján: TRUE, FALSE
            Console.WriteLine(women.Exists(x => x.Weight > 50)); // true
            Console.WriteLine(women.Exists(x => x.Name == "Zoltán")); // false
            Console.WriteLine(women.Exists(x=>x.HairColor=="fekete")); // false
            Console.WriteLine(women.Exists(x=>x.Age<18)); // false
            Console.WriteLine(women.Exists(x => x.Age > 100)); // false

            // 7) Find -> objektumot keres feltétel alapján
            Woman legidosebb = women.Find(x => x.Age == 67);
            Woman csenge = women.Find(x => x.Name == "Csenge");
            Console.WriteLine(legidosebb);
            Console.WriteLine(csenge);

            // 8) FindAdll -> adott feltételre listáz objektumokat
            List<Woman> vorosNok = women.FindAll(x => x.HairColor == "vörös");
            vorosNok.ForEach(Console.WriteLine);

            List<Woman> nok30nalIdosebbek = women.FindAll(x => x.Age > 30);
            nok30nalIdosebbek.ForEach(Console.WriteLine);

            // 9) Where -> FindAll -> IEnumerable<> Lista ősinterfészében ad vissza több eredményt

            Console.WriteLine(women.Where(x => x.Age > 20));

            // LINQ -> hátránya ha csak egy ember teljesül a feltéátelre, akkoris IEnumerable<>-ba adja vissza (lista ősinterfésze)
           //var eredmeny = from Woman w in women
           //                               where w.Age > 20
           //                               orderby w.Name
           //                               select w;
           // Language Interated Query -> nyelvbe épített lekérdező nyelv
           // Entity Framework -> adatbázis kapcsolódó API -> legenerálja táblákat modell meg a repo réteget
           // DbSet<> adatbzáshalmaz (rekord) -> LINQ -> EF a LINQ-t fordítja SQL-re


            // Prog. tételek röviden:

            // 1) Összegzés tétel : Sum() függvény : számokra működik (double, int)

            // a) összegezzük a nők életkorát
            // b) összegezzük a nők testsúlyait

            //int sumEletkor = women.Sum(x => x.Age);

            ////int sumEletkor2 = 0;
            ////foreach (Woman x in women)
            ////{
            ////    sumEletkor += x.Age;
            ////}

            //double sumTestsuly = women.Sum(x => x.Weight);

            //double sumTestsuly2 = 0;
            //foreach (Woman x in women)
            //{
            //    sumTestsuly2 += x.Weight;
            //}

            //Console.WriteLine(sumEletkor);
            //Console.WriteLine(sumTestsuly);

            //List<int> szamok = new List<int> { 1, 2, 3, 4, 5 };
            //szamok.Sum();

            // Átlag tétel: Average() : számokra működik (int, double) -> mindig DOUBLE a végeredmény
            // a) átlagéletkor
            // b) összegezzük a nők testsúlyait

            //double atlagEletkor = women.Average(x => x.Age);
            //double atlagTestsuly = women.Average(x => x.Weight);

            //Console.WriteLine(atlagEletkor);
            //Console.WriteLine(atlagTestsuly);

            // Maximum tétel: Max() : számokra működik -> ha intet maxolunk INT a végeredmény, stb...

            //int maxEletkor = women.Max(x => x.Age);
            //double maxTestsuly = women.Max(x => x.Weight);

            //Console.WriteLine(maxEletkor);
            //Console.WriteLine(maxTestsuly);

            // Minimum tétel: Min() : számokra működik -> ha intet maxolunk INT a végeredmény, stb...

            //int minEletkor = women.Min(x => x.Age);
            //double minTestsuly = women.Min(x => x.Weight);

            //Console.WriteLine(minEletkor);
            //Console.WriteLine(minTestsuly);

            // Megszámlálás tétel -> adott feltételre darabszámot ad vissza
            // Count()

            // a) hány szőke nő van?

            //int szokeDb = women.Count(x => x.HairColor == "szőke");
            //Console.WriteLine($"Szőke nők darabszáma: {szokeDb}");

            //// b) hányan "nehezebbek" 70 kg-nál?

            //int nehezebb70nel = women.Count(x => x.Weight > 70);
            //Console.WriteLine($"70 kg-nál nehezebb nők száma: {nehezebb70nel}");

            //// c) hány vörös hajú nő van, aki "nehezebb" 50 kg-nál?

            //int vorosHajuEs50NelNehezebb = women.Count(x => x.HairColor == "vörös" && x.Weight > 50);
            //Console.WriteLine($"Vörös hajú és 50-nél nehezebb {vorosHajuEs50NelNehezebb}");

            //// d) Hányan vannak 30 évnél fiatalabbak?

            //int nok30alatt = women.Count(x => x.Age < 30);
            //Console.WriteLine($"Nők 30 év alatt: {nok30alatt}");


            //// e) Hányan vannak 30 évnél fiatalabbak és szőkék?
            //int nok30nelFiatalabbEsSzoke = women.Count(x =>x.Age < 30 && x.HairColor == "szőke");
            //Console.WriteLine($"Nők 30 nél fiatalabb és szőke: {nok30nelFiatalabbEsSzoke}");



            Console.ReadKey();
        }
    }
}
