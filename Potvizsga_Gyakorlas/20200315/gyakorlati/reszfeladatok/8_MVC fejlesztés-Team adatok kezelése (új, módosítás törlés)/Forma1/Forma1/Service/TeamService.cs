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

        public void hozzadcsapat(string csapathozzaad) // amelyik függvény kivételt dobhat, annak aki meghívja try-catch
        {
            //ellenőrzés
            if (forma1Repository.isExistingTeam(csapathozzaad)) // if (LOGIKA KIÉRTÉKELÉS) // if-> igaz ág, az else hamis ág
            {
                throw new Exception("VAN MÁR ILYEN NEVŰ CSAPAT! NEM ADHATOM HOZZÁ!");
            }

            Team team = new Team(csapathozzaad);
            forma1Repository.add(team);
        }

        internal void CsapatTorles(string torlendoCsapatNeve)
        {
            forma1Repository.delete(torlendoCsapatNeve);
        }
    }
}
