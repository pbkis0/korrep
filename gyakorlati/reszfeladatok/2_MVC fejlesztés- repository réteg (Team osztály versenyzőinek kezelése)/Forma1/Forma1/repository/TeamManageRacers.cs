using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class Team : ITeamManageRacers
    {

        /// <summary>
        /// A csapat versenyzőinek listáját adja vissza
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        public List<Racer> getRacers()
        {

            return racers;
        }
        /// <summary>
        /// Megadja a csapatban lévő versenyzők számát
        /// </summary>
        /// <returns>Csapatban lévő versenyzők száma</returns>
        public int getNumberOfRacers()
        {
            return racers.Count; //A versenyzők számát adja össze.
        }

        /// <summary>
        /// Új versenyző hozzáadása
        /// </summary>
        /// <param name="r">új versenyző</param>
        /// <exception cref="TeamException">Két úgyan olyan versenyző nem lehet a csapatban</exception>
        public void addRacer(Racer r)
        {
            foreach (var racer in racers)
            {
                if (r.getId()==racer.getId() && r.getName()== racer.getName() &&  r.getSalary() == racer.getSalary() && r.getAge() == racer.getAge())
                {
                    throw new TeamException("Két úgyanolyan versenyző nem lehet a listában!!");
                }
                else
                {
                    racers.Add(r);
                }

            }           
        }

        /// <summary>
        /// Törli a versenyzőt a csapatból
        /// Akkor törölje a versenyzőt, ha a neve és a születési éve megegyezik a keresettel
        /// </summary>
        /// <param name="name">Törlendő versenyző neve</param>
        /// <exception cref="TeamException">Ha a versenyző a csapatnak nem tagja, nem lehet törlni</exception>
        public void deleteRacer(string name, int age)
        {
            foreach (var r in racers)
            {
                if (r.getName() == name && r.getAge() == age)
                {
                    racers.Remove(r);
                }
                else
                {
                    throw new TeamException("Nincs ilyen versenyző, nem lehet törölni!");
                }
            }
        }

        /// <summary>
        /// Módosítja a versenyző adatait
        /// </summary>
        /// <param name="name">Módosítanidó versenyző</param>
        /// <param name="newRacer">A versenyző új adatai</param>
        /// <exception cref="TeamException">Ha a módosítandó versenyzőt nem találjuk, nem lehet módosítani</exception>
        public void updateRacer(string name, Racer newRacer)
        {
            foreach (var r in racers)
            {
                if (r.getName() == name)
                {
                    r.update(newRacer);
                }
                else
                {
                    throw new TeamException("Nincs meg a versenyző!");
                }
            }
        }

       

        /// <summary>
        /// Megkeresi az adott nevű versenyzőt
        /// </summary>
        /// <param name="racerName"></param>
        /// <returns>Ha van, akkor a versenyző, ha nincs akkor null</returns>
        public Racer serchRacerByName(string racerName)
        {
            foreach (var r in racers)
            {
                if (r.getName() == racerName)
                {
                    return r;
                }
            }

            return null;
        }

        /// <summary>
        /// Megadja, hogy a versenyző lézetik-e
        /// </summary>
        /// <param name="racerName">Versenyző neve</param>
        /// <param name="racerAge">Versenyző életkora</param>
        /// <returns>Ha létezik, akkor true, ha nem akkor false</returns>
        public bool isRacerExist(string racerName, int racerAge)
        {
            foreach (var r in racers)
            {
                if (r.getName() == racerName && r.getAge() == racerAge)
                {
                    return true;
                }
            }


            return false;

            //Racer r = serchRacerByName(racerName);
            //if (r != null)
            //    if (r.getAge() == racerAge)
            //        return true;
            //return false;


        }
        
        /// <summary>
        /// Megadja az adott nevű versenyző azonosítóját
        /// </summary>
        /// <param name="racerName">Versenyző neve</param>
        /// <returns>A versenyző azonosítója</returns>
        public int getRacerId(string racerName)
        {
            foreach (var r in racers)
            {
                if (r.getName() == racerName)
                {
                    return r.getId();

                }

            }
            return -1;
        }

        /// <summary>
        /// Megahtározza a legnagyobb azonosítójú versenyző azonosítóját
        /// </summary>
        /// <returns>A legnagyobb azonosító</returns>
        public int getMaxId()
        {
            int max = 0;

            foreach (var r in racers) //Max keresés tétele
            {
                if (r.getId() > max)
                    max = r.getId();
            }

            return max;
        }
    }
}
