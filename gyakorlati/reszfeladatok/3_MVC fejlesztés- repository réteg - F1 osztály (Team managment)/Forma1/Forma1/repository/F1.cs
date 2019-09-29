using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forma1.myexeption;

namespace Forma1.repository
{
    partial class F1 : IF1
    {
        List<Team> teams;

        /// <summary>
        /// Forma 1 konstruktor
        /// </summary>
        public F1()
        {
            teams = new List<Team>();
        }

        /// <summary>
        /// A csapatok listája
        /// </summary>
        /// <returns>A csapat nevek listája</returns>
        public List<Team> getTeams()
        {
            //Listának a get-tere
            return teams;
        }

        /// <summary>
        /// Új csapat hozzáadása a Forma1-hez
        /// </summary>
        /// <param name="t">A csapat</param>
        public void add(Team t)
        {
            teams.Add(t);
        }

        /// <summary>
        /// Adott nevű csapat törlése
        /// Törlés előtt törölje a csapat összes versenyzőjét 
        /// </summary>
        /// <param name="teamName">A törlendő csapat neve</param>
        /// <exception cref="F1Exception">A csapat nem lézetik</exception>
        public void delete(string teamName)
        {
            foreach (var t in teams )
            {
                if (t.getName() == teamName)
                {
                    t.deleteAllRacersInTeam();
                    teams.Remove(t);
                }
                else
                {
                    throw new F1Exception("A csapat nem létezik");
                }

            }

        }

        /// <summary>
        /// Adott nevű csapat nevének módosítása
        /// Módosításhoz használja fel a Team osztály megfelelő metódusát
        /// </summary>
        /// <param name="teamName">A csapat régi neve</param>
        /// <param name="newTeamName">A csapat új neve</param>
        /// <exception cref="F1Exception">A csapat nem lézetik</exception>
        public void update(string teamName, string newTeamName)
        {
            foreach (var t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.update(newTeamName);
                    return;
                }

            }

            throw new F1Exception("A csapat nem lézetik");
        }
     
        /// <summary>
        /// Van-e adott nevű csapat
        /// </summary>
        /// <param name="teamName">A keresett csapat neve</param>
        /// <returns>true ha van és false ha nincs</returns>
        public bool existTeamName(string teamName)
        {
            foreach ( var t in teams)
            {
                if (t.getName() == teamName)
                {
                    return true;
                }

            }
            return false;
        }

        /// <summary>
        /// Van-e adott versenyző nevű és életkorú versenyző
        /// </summary>
        /// <param name="racerName">A keresett versenyző neve</param>
        /// <param name="racerAge">A keresett versenyző életkora</param>
        /// <returns>true ha van és false ha nincs</returns>
        public bool existRacer(string racerName, int racerAge)
        {
            // Versenyzőre kérdezünk rá, hogy van-e bármely csapatban?

            // F1 osztályban vagyunk, itt nincsen Racer lista. De van heklyette Team lista. Teamen keresztül elérem a Racerek!

            foreach (var t in teams) // 1. lépés: végigmegyünk a csapatokon
            {
             /* A csapat osztályban már van üzleti logika arra hogy van-e önmagában (csapatban) ez a versenyző,
              * amit az F1-ben lévő existRacer függvény paraméterei szerint kereshető*/

                if (t.isRacerExist(racerName, racerAge)) // 2. lépésben ezt akkor emghívjuk és átpasszoljuk neki a paraméterek és ő majd elvégzi a piszkos melót
                {
                    // t.isRacerExist(racerName, racerAge) ez bool függvény, vagy true vagy false amit visszaad
                    // if ág igaz ág: itt csak akkor megy bele a program végrehajtás (blokkba) ha a t.isRacerExist(racerName, racerAge) true-t ad vissza
                    // Ekkor belép ide a blokkba tehát létezik ilyen versenyző, így az F1 existRacer függvénye is igaz, adjunk vissza igaza: return true;
                    // Ha false-szal tér vissza a t.isRacerExist(racerName, racerAge), akkor az if ágba nem fut bele, és tovább pörög a foreach ciklus
                    return true;
                }
            }

            return false; // Ha totál nem talál ilyen versenyzőt, akkor végső elkeseredésében már csak hamissal tud visszatérni (mert nem talált semmit)
        }

        /// <summary>
        /// Adott csapat adott nevű versenyzőjének megkeresése
        /// A megoldáshoz használja fel a Team osztály megfelelő metódusát.
        /// </summary>
        /// <param name="teamName">A csapat neve, amelynek tagja a versenyző</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>A versenyző</returns>
        /// <exception cref="F1Exception">A csapat nem lézetik adott nevű versenyzője</exception>
        public Racer searchRacerByName(string teamName, string racerName)
        {
            foreach (var t in teams)
            {
                if (t.getName() == teamName)
                {
                    return t.serchRacerByName(racerName); // ez olyan mintha return null -> ha nincs meg név alapján
                }

            }
            throw new F1Exception("A csapat nem lézetik adott nevű versenyzője");
        }

        /// <summary>
        /// Adott nevű csapat bérköltsége
        /// </summary>
        /// <returns>A bérköltség</returns>
        public int getF1Salary()
        {
            int sum = 0;
            foreach (Team t in teams)
            {
                sum = sum + t.getTeamSalary();
            }
            return sum;
        }
    }
}
