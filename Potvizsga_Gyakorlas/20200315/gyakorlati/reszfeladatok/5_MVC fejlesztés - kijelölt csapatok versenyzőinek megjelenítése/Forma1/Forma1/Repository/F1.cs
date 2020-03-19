using Forma1.Model;
using Forma1.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    class F1 : IF1
    {
        List<Team> teams;

        public F1()
        {
            teams = new List<Team>();
        }

        public List<Team> getTeam()
        {
            return teams;
        }



        public void add(Team t)
        {
            teams.Add(t);
        }

        public void delete(string teamName)
        {
            int index = 0;
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.delete(); //törli a team versenyzőket
                    teams.RemoveAt(index);
                    return;
                }
                index = index + 1;
            }
            throw new RepositoryException(teamName + " csapat nem létezik, nem lehet törölni");

        }

        public int getF1Salary()
        {
            int f1Salary = 0;
            foreach (Team t in teams)
            {
                f1Salary = f1Salary + t.getTeamSalary();
            }
            return f1Salary;
        }

        public void update(string teamName, string newTeamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.update(newTeamName);
                }
            }
        }

        public List<Racer> GetRacers(string teamName)
        {
            //9) Repo leszűri a paraméter alapján melyik csapat (t objektum) Racer listáját kell visszaadja (return)
            //10) Menj vissza a Service-be, ahol erz a függvény hívva lett, mert a szekvencia is visszamegy
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    return t.GetRacers();
                }
            }

            throw new RepositoryException("Nincs meg a csapat!");
        }
    }
}
