using System;
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

        public List<Racer> GetRacers(string teamName)
        {
            // 7) Service a repoból hívja a GetRacers(PARAMÉTERT DOBOM TOVÁBB) függvényt és vissza adja majd a Controllernek (return)
            // 8) F12, szekvencia beleugrik az F1.cs-be (formaRepository -> F1 class egy példánya)
            return forma1Repository.GetRacers(teamName);

            // 11) Menj vissza a controllerbe mert a szekvencia is, lefutott a return és visszaadja a Racer listát
        }
    }
}
