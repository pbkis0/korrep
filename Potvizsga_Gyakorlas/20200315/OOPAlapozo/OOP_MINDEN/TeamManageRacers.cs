using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MINDEN
{
    public partial class Team
    {
        public void addRacer(Racer racer)
        {
            racers.Add(racer);
        }

        public void deleteRacer(string name)
        {
            foreach (Racer r in racers)
            {
                if (r.getName() == name)
                {
                    racers.Remove(r);
                    return;
                }
            }
        }

        public void updateRacer(string oldRacerName, Racer racer)
        {
            foreach (Racer r in racers)
            {
                if (r.getName() == oldRacerName)
                {
                    r.updateRacer(racer);
                }
            }
        }

        public int getNumberOfRacers()
        {
            return racers.Count;
        }

        public bool isExistingRacer(string racerName, int racerAge)
        {
            foreach (Racer r in racers)
            {
                if (r.getName() == racerName && r.getAge() == racerAge)
                {
                    return true;
                }
            }

            return false;
        }

        public int getTeamSalary()
        {
            int teamSalary = 0;

            foreach (Racer r in racers)
            {
                teamSalary += r.getSalary();
            }

            return teamSalary;
        }

    }
}
