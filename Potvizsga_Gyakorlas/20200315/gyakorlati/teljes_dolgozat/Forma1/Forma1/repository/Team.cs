using Forma1.myexeption;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class Team : ITeam, ITeamSalary
    {
        private string name;
        private List<Racer> racers;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Az új csapat neve</param>
        public Team(string name)
        {

            //2,  - konstruktorban NameValidator (kivételdobás+outputra loggolás)
            try
            {
                NameValidator nv = new NameValidator(name);
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException ex)
            {
                Debug.WriteLine(ex.Message); // outputra loggolás
                throw new RacerException(ex.Message);
            }
            catch (NameNotValidFirstLetterProblemException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new RacerException(ex.Message);
            }

            //2, - konstruktor
            this.name = name;
            this.racers = new List<Racer>();
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
        /// A listából minden versenyzőt törlünk
        /// </summary>
        public void deleteAllRacersInTeam()
        {
            //2, deleteAllRacersInTeam
            racers.Clear();
        }
        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Csapat új neve</param>
        public void update(string newName)
        {
            //2, update és getRacers metódusok megírása
            this.name = newName;
        }
        /// <summary>
        /// A csapat versenyzőinek listáját adja vissza
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        public List<Racer> getRacers()
        {
            // //2, update és getRacers metódusok megírása
            return racers;
        }

        public int getTeamSalary() // összegzés tétel
        {
            //2,ITeamSalary interface hozzárendelése és a szükséges metódus megírása
            int sum = 0;

            foreach (Racer r in racers)
            {
                sum += r.getSalary();
            }

            return sum;
        }
    }
}
