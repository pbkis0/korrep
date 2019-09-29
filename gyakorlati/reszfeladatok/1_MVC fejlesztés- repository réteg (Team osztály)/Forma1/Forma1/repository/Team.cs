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
            racers = new List<Racer>();
            this.name = name;

        }
        /// <summary>
        /// getter
        /// </summary>
        /// <returns>A csapat neve</returns>
        public string getName()
        {
            return name;
        }
        /// <summary>
        /// Csapat törlésének előkészítése
        /// A listáből minden versenyzőt törlünk
        /// </summary>
        public void deleteAllRacersInTeam()
        {
            racers.Clear();
        }
        /// <summary>
        /// A csapat versenyzőinak összbére
        /// </summary>
        /// <returns>Csapat bérkifezése</returns>
        public int getTeamSalary()
        {
            int osszber = 0; //Összegzés tétel
            foreach (var r in racers) // var =az objektuk tipusa, amin végig megyek; r= azonosító amibe belemásolja az értékeket; racers - a listán amin végig megyek, in- a listának a neve amin végig megyek
            {
                osszber += r.getSalary();
            }
            return osszber;
        }
        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Csapat új neve</param>
        public void update(string newName)
        {
            this.name = newName; //set name ; a csapat nevét a jelenlegiről pl:_Mercedes, átírja a paratéterben megadottal pl: Ferreari
        }
        /// <summary>
        /// A csapat versenyzőinek nevének listája
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        public List<string> getRacerNames()
        {
            //String lista ami a neveket fogja tárolni.
            List<string> racerNamesList = new List<string>();

            foreach (var r in racers)
            {
                racerNamesList.Add(r.getName());
            }

            return racerNamesList;
        }
    }
}
