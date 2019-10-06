using Forma1.Model;
using Forma1.Repository;
using Forma1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Controller
{
    class F1Controller
    {
        TeamService service;

        public F1Controller()
        {
            service = new TeamService();
        }

        public void provideTestData()
        {
            service.provideTestData();
        }

        public List<string> getTeamNames()
        {
            List<Team> teams = service.getTeams();
            List<string> teamNames = new List<string>();
            foreach (Team t in teams)
            {
                teamNames.Add(t.getName());
            }
            return teamNames;
        }

        public List<string> getRacerNames(string teamName)
        {
            List<Racer> racers = service.getRacers(teamName);
            List<string> racerNames = new List<string>();
            foreach (Racer r in racers)
            {
                racerNames.Add(r.getName());
            }
            return racerNames;

        }

        public Racer searchRacerByName(string teamName, string racerName)
        {
            return service.searchRacerByName(teamName, racerName);
        }

        public void addRacer(string racerName, string racerAge, string racerSalary, string teamName)
        {
            //if (!int.TryParse(racerAge, out int age))
            //{
            //    throw new Exception("");
            //}

            //if (!int.TryParse(racerSalary, out int salary))
            //{
            //    throw new Exception("");
            //}

            int.TryParse(racerAge, out int age); // int age = Convert.ToInt32(racerAge);
            int.TryParse(racerSalary, out int salary); // int salary = Convert.ToInt32(racerSalary);

            service.addRacer(racerName, age, salary, teamName);
        }

        public void updateRacer(string racernameToModify, string racerName, string racerAge, string racerSalary, string teamName)
        {
            //if (!int.TryParse(racerAge, out int age))
            //{
            //    throw new Exception("");
            //}

            //if (!int.TryParse(racerSalary, out int salary))
            //{
            //    throw new Exception("");
            //}

            int.TryParse(racerAge, out int age); // int age = Convert.ToInt32(racerAge);
            int.TryParse(racerSalary, out int salary); // int salary = Convert.ToInt32(racerSalary);

            service.updateRacer(racernameToModify, racerName, age, salary, teamName);
        }

        public void deleteRacer(string racerName, string teamName)
        {
            service.deleteRacer(racerName, teamName);
        }
    }
}
