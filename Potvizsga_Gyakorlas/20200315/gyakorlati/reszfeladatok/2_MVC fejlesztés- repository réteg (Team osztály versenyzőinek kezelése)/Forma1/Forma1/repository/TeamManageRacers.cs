﻿using System;
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
            //1. feladat ->public List<Racer> getRacers()               
            return racers;
        }
        /// <summary>
        /// Megadja a csapatban lévő versenyzők számát
        /// </summary>
        /// <returns>Csapatban lévő versenyzők száma</returns>
        public int getNumberOfRacers()
        {
            return racers.Count;
        }

        /// <summary>
        /// Új versenyző hozzáadása
        /// </summary>
        /// <param name="r">új versenyző</param>
        /// <exception cref="TeamException">Két úgyan olyan versenyző nem lehet a csapatban</exception>
        public void addRacer(Racer r)
        {
            //3. feladat ->        public void addRacer(Racer r)
            this.racers.Add(r);
        }

        /// <summary>
        /// Törli a versenyzőt a csapatból
        /// Akkor törölje a versenyzőt, ha a neve és a születési éve megegyezik a keresettel
        /// </summary>
        /// <param name="name">Törlendő versenyző neve</param>
        /// <exception cref="TeamException">Ha a versenyző a csapatnak nem tagja, nem lehet törlni</exception>
        public void deleteRacer(string name, int age)
        {
            //4. feladat ->        public void deleteRacer(string name, int age)
            foreach (var v in racers)
            {
                if (v.getName() == name && v.getAge() == age)
                {
                    racers.Remove(v);
                    return;
                }
            }

            throw new TeamException("Ha a versenyző a csapatnak nem tagja, nem lehet törlni");
        }

        /// <summary>
        /// Módosítja a versenyző adatait
        /// </summary>
        /// <param name="name">Módosítanidó versenyző</param>
        /// <param name="newRacer">A versenyző új adatai</param>
        /// <exception cref="TeamException">Ha a módosítandó versenyzőt nem találjuk, nem lehet módosítani</exception>
        public void updateRacer(string name, Racer newRacer)
        {
            //5. feladat ->        public void updateRacer(string name,
            foreach (var v in racers)
            {
                if (v.getName() == name) //név alapján azonosítás
                {
                    v.update(newRacer);
                }
            }

            //foreach (var v in racers)
            //{
            //    if (v.getName()==name)
            //    {
            //        v.setAge(newRacer.getAge());
            //    }
            //}
        }



        /// <summary>
        /// Megkeresi az adott nevű versenyzőt
        /// </summary>
        /// <param name="racerName"></param>
        /// <returns>Ha van, akkor a versenyző, ha nincs akkor null</returns>
        public Racer serchRacerByName(string racerName)
        {
            // 7.feladat->       public Racer serchRacerByName(string racerName)
            foreach (Racer v in racers)
            {
                if (v.getName() == racerName)
                {
                    return v;
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
            //8.feladat ->public Racer serchRacerByName(string racerName)
            foreach (Racer v in racers)
                if (v.getName() == racerName && v.getAge() == racerAge)
                {
                    return true;
                }
            return false;
        }

        /// <summary>
        /// Megadja az adott nevű versenyző azonosítóját
        /// </summary>
        /// <param name="racerName">Versenyző neve</param>
        /// <returns>A versenyző azonosítója</returns>
        public int getRacerId(string racerName)
        {
            //9.feladat ->public int getRacerId(string racerName)
            foreach (Racer v in racers)
            {
                if (v.getName() == racerName)
                {
                    return v.getId();
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
            //10.feladat ->public int getMaxId()
            //Maximum keresés tétel
            int max = 0;

            foreach (Racer v in racers)
            {
                if (max < v.getId())
                {
                    max = v.getId(); //max értéke mindig az aktuális legnagyobb id értékének felel meg.
                }
            }

            return max;
        }
    }
}
