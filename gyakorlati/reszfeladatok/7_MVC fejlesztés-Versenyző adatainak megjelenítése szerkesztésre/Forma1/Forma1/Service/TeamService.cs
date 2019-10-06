using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forma1.Model;
using Forma1.Repository;

namespace Forma1.Service
{
    class TeamService
    {
        F1 forma1Repository;

        public TeamService()
        {
            forma1Repository = new F1();
        }
        public void provideTestData()
        {
            TestData td = new TestData();
            forma1Repository = td.getTestData();
        }
        public List<Team> getTeams()
        {
            return forma1Repository.getTeam();
        }

        public List<Racer> getRacers(string teamName)
        {
            return forma1Repository.getRacers(teamName);
        }

        public Racer searchRacerByName(string teamName, string racerName)
        {
            //  List<Team> teams = forma1Repository.getTeam(); // List<Team> teams = teams (ez a repoban - mésik osztályban - él);

            //foreach (var t in forma1Repository.getTeam())
            //{
            //    if (t.getName() == teamName)
            //    {
            //        foreach (var r in t.getRacers())
            //        {
            //            if (r.getName() == racerName)
            //            {
            //                return r;
            //            }
            //        }
            //    }
            //}

            foreach (var t in forma1Repository.getTeam())
            {
                if (t.getName() == teamName)
                {
                    return t.serchRacerByName(racerName);
                }
            }

            return null;
        }

        public void addRacer(string racerName, int racerAge, int racerSalary, string teamName)
        {
            foreach (var t in forma1Repository.getTeam()) // Végigmegyünk a repó listáján
            {
                if (t.getName() == teamName) // Beazonosítjuk a csapatot név alapján (paraméterben jött függvényhíváskor alsóbb rétegben)
                {
                    Racer racer = new Racer(3, racerName, racerAge, racerSalary); // 3 helyett kell lenni-e a Team-ben getNextRacerID(); Példányosítás
                    t.add(racer); // adott t-hez amire teljesül az if, annak a List<Racer>-ébe belerakja a képzett objektumot
                }
            }
        }

        public void updateRacer(string racerNameToModify, string racerName, int age, int salary, string teamName)
        {
            foreach (var t in forma1Repository.getTeam())
            {
                if (t.getName() == teamName)
                {
                    Racer racer = new Racer(1, racerName, age, salary);
                    t.update(racerNameToModify, racer);
                }
            }
        }

        public void deleteRacer(string racerName, string teamName)
        {
            foreach (var t in forma1Repository.getTeam())
            {
                if (t.getName() == teamName)
                {
                    t.delete(racerName);
                }
            }
        }
    }
}
