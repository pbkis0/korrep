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
        List<Racer> racers;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Az új csapat neve</param>
        public Team(string name)
        {
            this.name = name; //1.feladat-> 1. public Team(string name)
            racers = new List<Racer>();
        }
        /// <summary>
        /// getter
        /// </summary>
        /// <returns>A csapat neve</returns>
        public string getName()
        {
            return name; //2.feladat ->2. public string getName()
        }
        /// <summary>
        /// Csapat törlésének előkészítése
        /// A listáből minden versenyzőt törlünk
        /// </summary>
        public void deleteAllRacersInTeam()
        {
            racers.Clear(); //3.feladat ->3. public void deleteAllRacersInTeam()
        }
        /// <summary>
        /// A csapat versenyzőinak összbére
        /// </summary>
        /// <returns>Csapat bérkifezése</returns>
        public int getTeamSalary()
        {
            //4.feladat ->4. public int getTeamSalary()
            // Összegzés tétel

            int osszeg = 0;

            foreach (Racer r in racers)
            {
                osszeg += r.getSalary();
            }

            return osszeg;
        }
        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Csapat új neve</param>
        public void update(string newName)
        {
            //5. feladat ->5. public void update(string newName)
            this.name = newName;
        }
        /// <summary>
        /// A csapat versenyzőinek nevének listája
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        public List<string> getRacerNames()
        {
            List<string> racerNamesList = new List<string>();
            return racerNamesList;
        }
    }
}
