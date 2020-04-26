using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class Team : ITeam
    {
        private string name;
        private List<Racer> racers;

        //Írja meg a Team(string name) konstruktor kódját!
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Az új csapat neve</param>
        public Team(string name)
        {
            this.name = name;
            racers = new List<Racer>(); //List osztály konstrukóra
        }

        /// <summary>
        /// Csapat nevének lekérése
        /// </summary>
        /// <returns>A csapat neve</returns>
        public string getName()
        {
            return name;
        }

        //A deleteAllRacersInTeam metódus nem jól végzi feladatát! Adja hozzá a szükséges egy sort a kódhoz!
        /// <summary>
        /// Csapat törlésének előkészítése
        /// A listából minden versenyzőt törlünk
        /// </summary>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public void deleteAllRacersInTeam()
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");
            racers.Clear();
        }

        // Írja meg az update metódust a megfelelő komment után!
        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Csapat új neve</param>
        public void update(string newName)
        {
            this.name = newName;
        }

        //Írja meg a getRacers metódus kódját!
        /// <summary>
        /// A csapat versenyzőinek listáját adja vissza
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public List<Racer> getRacers()
        {
            if (racers == null)
            throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");
            return racers;
        }

        /// <summary>
        /// A csapat versenyzőinak összbére
        /// </summary>
        /// <returns>Csapat bérkifezése</returns>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public int getTeamSalary()
        {
        }
    }
}