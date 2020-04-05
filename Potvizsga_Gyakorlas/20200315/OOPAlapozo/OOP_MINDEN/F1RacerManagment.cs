using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MINDEN
{
    public partial class F1
    {
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

        public int getNumberOfRacers(string teamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName) // itt beazonosítottam a 't' objektumot, megvqan a csapat név alapján
                {
                    return t.getNumberOfRacers();
                }
            }

            return 0;
            //throw new Exception("Nincs meg a csapat");
        }

        public bool isExistingRacer(string racerName, int racerAge)
        {
            foreach (Team t in teams)
            {
                if (t.isExistingRacer(racerName, racerAge))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
