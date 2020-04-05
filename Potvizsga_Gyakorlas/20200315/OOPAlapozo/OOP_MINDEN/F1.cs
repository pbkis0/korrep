using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MINDEN
{
    public partial class F1 // Repository
    {
        /// <summary>
        /// A Forma1 letárolja a csapatait
        /// </summary>
        private List<Team> teams;

        public F1()
        {
            teams = new List<Team>();
        }

        public List<Team> getTeams()
        {
            return teams;
        }

        public void addTeam(Team team)
        {
            teams.Add(team);
        }

        public void updateTeam(string teamName, string newTeamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.update(newTeamName);
                }
            }
        }

        public void deleteTeam(string teamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    teams.Remove(t);
                    return;
                }
            }
        }

        public int getF1Salary()
        {
            int f1Salary = 0;

            foreach (Team t in teams)
            {
                f1Salary += t.getTeamSalary();
            }

            return f1Salary;
        }

        public int getTeamSalary(string teamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    return t.getTeamSalary();
                }
            }

            return 0;
        }
    }
}
