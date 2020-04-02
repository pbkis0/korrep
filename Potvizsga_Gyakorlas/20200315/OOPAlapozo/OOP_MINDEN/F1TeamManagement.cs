using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MINDEN
{
    public partial class F1
    {
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
    }
}
