using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MINDEN
{
    public class TestData
    {
        public F1 provideTestData()
        {
            Racer r1 = new Racer(1, "Sumáher", 30, 1300);
            Racer r2 = new Racer(2, "Bottas", 20, 1500);
            Racer r3 = new Racer(3, "Verstappen", 18, 2000);

            Team team1 = new Team("Ferrari");
            Team team2 = new Team("McLaren");

            team1.addRacer(r1);
            team2.addRacer(r2);
            team2.addRacer(r3);

            F1 f1 = new F1();
            f1.addTeam(team1);
            f1.addTeam(team2);

            return f1;
        }
    }
}
