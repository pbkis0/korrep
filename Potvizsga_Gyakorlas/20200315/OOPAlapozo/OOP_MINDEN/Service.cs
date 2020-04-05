using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MINDEN
{
    public class Service
    {
        F1 f1;
        TestData test;

        public Service()
        {
            test = new TestData();
            f1 = test.provideTestData(); // idáig van nekünk egy tesztadatokkal feltöltöt kész repository (adattár)
        }

        public List<Team> getTeams()
        {
            return f1.getTeams();
        }

        public void addTeam(Team team)
        {
            f1.addTeam(team);
        }

        public void updateTeam(string teamName, string newTeamName)
        {
            f1.updateTeam(teamName, newTeamName);
        }

        public void deleteTeam(string teamName)
        {
            f1.deleteTeam(teamName);
        }

        public void addRacerToTeam(string teamName, Racer r)
        {
            f1.addRacerToTeam(teamName, r);
        }

        public void deleteRacerFromTeam(string teamName, string racerName)
        {
            f1.deleteRacerFromTeam(teamName, racerName);
        }

        public void updateRacer(string teamName, string oldRacerName, Racer r)
        {
            f1.updateRacer(teamName, oldRacerName, r);
        }

        public int getNumberOfRacers(string teamName)
        {
            return f1.getNumberOfRacers(teamName);
        }

        public bool isExistingRacer(string racerName, int racerAge)
        {
            return f1.isExistingRacer(racerName, racerAge);
        }

        public int getF1Salary()
        {
            return f1.getF1Salary();
        }

        public int getTeamSalary(string teamName)
        {
            return f1.getTeamSalary(teamName);
        }
    }
}
