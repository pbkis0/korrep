using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MINDEN
{
    public class Controller
    {
        private Service service;

        public Controller()
        {
            service = new Service();
        }

        public string getTeamSalary(string teamName)
        {
            int teamSalary = service.getTeamSalary(teamName);
            return teamSalary.ToString();
        }

        public string getF1Salary()
        {
            int f1Salary = service.getF1Salary();
            return f1Salary.ToString();
        }

        public List<Team> getTeams()
        {
            return service.getTeams();
        }

        public void addTeam(Team team)
        {
            service.addTeam(team);
        }

        public void updateTeam(string teamName, string newTeamName)
        {
            service.updateTeam(teamName, newTeamName);
        }

        public void deleteTeam(string teamName)
        {
            service.deleteTeam(teamName);
        }

        public void addRacerToTeam(string teamName, Racer r)
        {
            service.addRacerToTeam(teamName, r);
        }

        public void deleteRacerFromTeam(string teamName, string racerName)
        {
            service.deleteRacerFromTeam(teamName, racerName);
        }

        public void updateRacer(string teamName, string oldRacerName, Racer r)
        {
            service.updateRacer(teamName, oldRacerName, r);
        }

        public string getNumberOfRacers(string teamName)
        {
            int numberOfRacers = service.getNumberOfRacers(teamName);
            return numberOfRacers.ToString();
        }

        public bool isExistingRacer(string racerName, int racerAge)
        {
            return service.isExistingRacer(racerName, racerAge);
        }
    }
}
