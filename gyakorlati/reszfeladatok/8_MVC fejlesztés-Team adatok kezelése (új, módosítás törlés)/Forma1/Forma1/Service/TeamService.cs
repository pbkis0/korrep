﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forma1.Model;
using Forma1.Repository;

namespace Forma1.Service
{
    class TeamService
    {
        F1 forma1Repository;

        public TeamService()
        {
            forma1Repository = new F1();
        }
        public void provideTestData()
        {
            TestData td = new TestData();
            forma1Repository = td.getTestData();
        }
        public List<Team> getTeams()
        {
            return forma1Repository.getTeam();
        }

        public List<Racer> getRacers(string teamName)
        {
            return forma1Repository.getRacers(teamName);
        }

        internal Racer searchRacerByName(string teamName, string racerName)
        {
            return forma1Repository.searchRacerByName(teamName, racerName);
        }

        public bool isExistingTeam(string teamName)
        {
            return forma1Repository.isExistingTeam(teamName); // return true;  --> return false;
        }

        internal void addTeam(string teamName)
        {
            if (isExistingTeam(teamName))
            {
                throw new Exception("HÜLYE VAGY!");
            }

            Team team = new Team(teamName);
            forma1Repository.add(team);
        }

        internal void updateTeam(string nameToModify, string teamName)
        {
            if (isExistingTeam(teamName))
            {
                throw new Exception("HÜLYE VAGY!");
            }
            forma1Repository.update(nameToModify, teamName);
        }

        internal void deleteTeam(string teamName)
        {
            if (isExistingTeam(teamName))
            {
                forma1Repository.delete(teamName);
            }
        }
    }
}
