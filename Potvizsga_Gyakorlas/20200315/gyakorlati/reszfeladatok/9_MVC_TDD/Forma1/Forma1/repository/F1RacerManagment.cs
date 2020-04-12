﻿    using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class F1 : IF1
    {
        public int getNumberOfRacers(string teamName)
        {
            //- Az F1 osztályban a getNumberOfRacers metódus befejezése.
            //Ha a csapat létezik, akkor Team osztály segítségével adja meg hány tagja van.
            //Ha nincs dobja a következő hibaüzenetet: teamName + " nevű csapat nem létezik, nem lehet megállapítani,
            //hány versenyzője van."

            foreach (Team t in teams)
                if (t.getName() == teamName)
                {
                    return t.getNumberOfRacers();
                }
            throw new F1Exception("nevű csapat nem létezik, nem lehet megállapítani,hány versenyzője van!");
            //return 0;
        }

        public List<Racer> getRacersFromTheTeam(string teamName)
        {
            foreach (Team t in teams)
                if (t.getName() == teamName)
                    return t.getRacers();
            return null;
        }

        public int getNextRacerId()
        {
            int maxId = -1;
            foreach (Team t in teams)
            {
                int teamMaxRacerId = t.getMaxId();
                if (teamMaxRacerId > maxId)
                    maxId = teamMaxRacerId;
            }
            if (maxId > 0)
                return maxId + 1;
            else
                return 1;
        }

        public void addRacerToTeam(string teamName, Racer newRacer)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.addRacer(newRacer);
                    return;
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet új versenyzőt hozzáadni.");
        }

        public int getRacerId(string teamName, string racerName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    return t.getRacerId(racerName);
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet új versenyzőt hozzáadni.");
        }

        public void updateReacerInTeam(string teamName, string oldRacerName, Racer newRacer)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.updateRacer(oldRacerName, newRacer);
                    return;
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet módosítani a versenyzőjének adatait.");
        }

        public void deleteRacerInTeam(string teamName, string racerName, int racerAge)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.deleteRacer(racerName, racerAge);
                    return;
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet törölni a versenyzőjét.");
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
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet bérköltséget számolni.");
        }
    }
}
