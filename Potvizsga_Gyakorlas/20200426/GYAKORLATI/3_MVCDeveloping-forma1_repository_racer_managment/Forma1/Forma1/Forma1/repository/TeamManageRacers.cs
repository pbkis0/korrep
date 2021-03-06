﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class Team : ITeamManageRacers
    {
        // Az addRacer metódusban egészítse ki a foreach ciklus fejlécét és fejezze be a kivétel dobást kódját!
        /// <summary>
        /// Új versenyző hozzáadása
        /// </summary>
        /// <param name="newRacer">új versenyző</param>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        /// <exception cref="TeamException">newRacer versenyző már létezik!/exception>
        public void addRacer(Racer newRacer)
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");
            foreach(Racer r in racers)
            {
                if (r.getName() == newRacer.getName() && r.getAge() == newRacer.getAge() && r.getSalary() == newRacer.getAge())
                    throw new TeamException("newRacer versenyző már létezik!");
            }
            racers.Add(newRacer);
        }

        //A deleteRacer metódusban írja meg az elágazás törzsét, hogy a kód helyesen működjön!
        /// <summary>
        /// Törli a versenyzőt a csapatból
        /// </summary>
        /// <param name="name">Törlendő versenyző neve</param>
        /// <param name="age">Törlendő versenyző életkora</param>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        /// <exception cref="TeamException">A versenyző a csapatnak nem tagja, nem lehet törlni</exception>
        public void deleteRacer(string name, int age)
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");
            foreach (Racer r in racers)
            {
                if (r.getName() == name && r.getAge()==age)
                {
                    racers.Remove(r);
                    return;
                }
                
            }
            throw new TeamException(name + " versenyző a csapatnak nem tagja, nem lehet törlni");
        }

        //Az updateRacer metódusban írja meg a ciklus törzsét, hogy az helyesen működjön!
        /// <summary>
        /// Módosítja a versenyző adatait
        /// </summary>
        /// <param name="name">Módosítanidó versenyző</param>
        /// <param name="newRacer">A módosított versenyző adatai</param>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        /// <exception cref="TeamException">A módosítandó versenyzőt nem találjuk, nem lehet módosítani</exception>
        public void updateRacer(string name, Racer newRacer)
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva.");
            foreach (Racer r in racers)
            {
                if (r.getName() == name)
                {
                    r.update(newRacer);
                    return;
                }
            }
            throw new TeamException(name + " módosítandó versenyzőt nem találjuk, nem lehet módosítani.");
        }

        //Írja meg a getNumberOfRacer metódust!
        // Megszámlálás tétele
        /// <summary>
        /// Megadja a csapatban lévő versenyzők számát
        /// </summary>
        /// <returns>Csapatban lévő versenyzők száma</returns>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public int getNumberOfRacers()
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");

            return racers.Count;
        }

        //Írja meg a searchRacerByName metódust!
        /// <summary>
        /// Megkeresi az adott nevű versenyzőt
        /// </summary>
        /// <param name="racerName"></param>
        /// <returns>Ha van, akkor a versenyző, ha nincs akkor null</returns>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public Racer serchReacerByName(string racerName)
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");
            foreach (Racer r in racers)
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
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public bool isRacerExist(string racerName, int racerAge)
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");
            Racer r = serchReacerByName(racerName);
            if (r != null)
                if (r.getAge() == racerAge)
                    return true;
            return false;
        }

        /// <summary>
        /// Megadja az adott nevű versenyző azonosítóját
        /// </summary>
        /// <param name="racerName">Versenyző neve</param>
        /// <returns>A versenyző azonosítója, ha nincs meg a versenyző akkor -1</returns>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public int getRacerId(string racerName)
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");
            foreach (Racer r in racers)
                if (r.getName() == racerName)
                    return r.getId();
            return -1;
        }

        //Írja meg a getMaxId metódus hiányzó kódját!
        /// <summary>
        /// Meghatározza a legnagyobb azonosítójú versenyző azonosítóját
        /// </summary>
        /// <returns>A legnagyobb azonosító, ha lista üres akkor -1</returns>
        /// <exception cref="TeamException">Végzetes hiba, racers lista nincs példányosítva</exception>
        public int getMaxId()
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba, racers lista nincs példányosítva");

            //return racers.Max(x => x.getId());

            int maxID = 0;
            foreach (Racer r in racers)
            {
                if (maxID < r.getId())
                {
                    maxID = r.getId();
                }
            }
            return maxID;
        }
    }
}
