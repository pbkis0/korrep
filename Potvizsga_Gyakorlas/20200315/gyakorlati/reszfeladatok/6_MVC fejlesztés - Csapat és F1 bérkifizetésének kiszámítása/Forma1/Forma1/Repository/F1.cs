﻿using Forma1.Model;
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
            throw new RepositoryException(teamName+" csapat nem létezik, nem lehet törölni");

        }

        public List<Racer> getRacers(string teamName)
        {
            foreach(Team t in teams)
            {
                if (t.getName()==teamName)
                    return t.getRacers();
            }
            return null;
        }

        public int getF1Salary()
        {
            // összegzés tétel
            // csapat fizetése = végigfutok az összes csapaton egy ciklussal és minden körben az f1Salary (ideiglenes változó (összeg)) hez minden csapat bérkifizetését összegzi
            int f1Salary = 0;
            foreach(Team t in teams)
            {
                f1Salary = f1Salary + t.getTeamSalary();
            }
            return f1Salary;
        }

        public int getTeamSalary(string teamName)
        {
            foreach (Team t in teams) // "Team" vagy "var" is szerepelhet
            {
                if (t.getName()== teamName)
                {
                    return t.getTeamSalary();
                }
            }
            return 0;
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
    }
}
