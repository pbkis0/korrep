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

        // TODO: PARTIAL OSZTÁLYBA TEGYÜK KI!!!
        public void addRacerToTeam(string teamName, Racer racer)
        {
            foreach (Team team in teams)
            {
                if (team.getName() == teamName)
                {
                    team.addRacer(racer);
                }
            }
        }

        public void deleteRacerFromTeam(string teamName, string racerName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.deleteRacer(racerName);
                }
            }
        }

        public void updateRacer(string teamName, string oldRacerName, Racer racer)
        {
            foreach (Team team in teams)
            {
                if (team.getName() == teamName)
                {
                    team.updateRacer(oldRacerName, racer);
                }
            }
        }
    }
}
