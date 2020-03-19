using Forma1.Model;
using Forma1.Repository;
using Forma1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Controller
{
    class F1Controller
    {
        TeamService service;

        public F1Controller()
        {
            service = new TeamService();
        }

        public void provideTestData()
        {
            service.provideTestData();
        }

        public List<string> getTeamNames()
        {
            List<Team> teams = service.getTeams();
            List<string> teamNames = new List<string>();
            foreach (Team t in teams)
            {
                teamNames.Add(t.getName());
            }
            return teamNames;

        }

        //5) controller getTeamNames(CSAPATNÉV PARAMÉTERÜL, AMIT KISZEDTEM) függvény egy string listát ad vissza a versenyzők neveivel.
        public List<string> getRacerNames(string teamName)
        {
            //6) Controller az hívja a Service GetRacers(PARAMÉTER AMIT KISZEDTEM, CONTROLLER TOVÁBBADJA) függvényt,
            //ez a Controllerben kinyerem egy List<Racer>-be
            // F12-vel továbbmegyek, mert a service elugrik a szekvenciális végrehajtás
            List<Racer> racers = service.GetRacers(teamName);
            //12) Vissza jött a racers-be a leszűrt csapatlista

            //13) Létrehozok egy string listát ami az objektumok neveit fogja tárolni

            List<string> versenyzoknevei = new List<string>();

            
            // 14) Elindulok az objektumlistán és getterekkel minden objektum nevét addolom a string listába
            foreach (Racer r in racers)
            {
                versenyzoknevei.Add(r.getName());
            }
            //15) kész a leszűrt stringlista, vissza returnüljók a GUI felé - szekvencia megy vissza a GUI-ra
            return versenyzoknevei;

            
        }
    }
}
