﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using Forma1.myexeption;
using Forma1.repository;
using Forma1.service;
using Forma1.validation;

namespace Forma1.controller
{
    /// <summary>
    /// Controller réteg kapcsolatot teremt a GUI és a Service réteg között
    /// Feladata a bemenő adatok vizsgálata
    /// Feladata a megjelenítendő adatok átalakítása a GUI számára
    /// Feladata a programozónak szánt hibaüzenetek megjelenítése
    /// </summary>
    partial class F1Controller
    {
        TeamService teamService;

        public F1Controller()
        {
            teamService = new TeamService();
        }

        /// <summary>
        /// Test adatok inicializálása
        /// </summary>
        public void initializeTestData()
        {
            try
            {
                teamService.provideTestData();
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        //A getTeamNames metódusban a hibás sorban az osztály egy saját metódusát kell meghívni, hogy megjelenjenek a csapatnevek a listában. Írja be a metódus nevét és paraméterét!
        /// <summary>
        /// Csapatnevek lekérése
        /// TeamListToTeamNameList beső függvény segítségével visszatérési érték megjelenítése
        /// TeamServiceException elkapása, és megjelenítése a Debug osztály segítségével. 
        /// Kivétel elkapás esetén üres lista a visszatérési érték.
        /// </summary>
        /// <returns>Csapatnevek listája</returns>
        public List<string> getTeamNames()
        {
            try
            {
                List<Team> teams = teamService.getTeams();
                return TeamListToTeamNameList(teams);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
                List<string> teams = new List<string>();
                return teams;
            }
        }

        //A getTeamListToTeamNameList metódusban a létrehozott listába a csapat neveket kell hozzáadni.Írja meg a hiányzó kódot!
        /// <summary>
        /// Belső függvény
        /// A team listából team név listát készít
        /// </summary>
        /// <param name="teams">A lista amelyből készül a team név lista</param>
        /// <returns>Csapatnevek listája</returns>
        private List<string> TeamListToTeamNameList(List<Team> teams)
        {
            List<string> teamNames = new List<string>();
            foreach (Team t in teams)
            {
                teamNames.Add(t.getName());
            }
            return teamNames;
        }

        //A getTeamNamesListExclude metódusban hiányzik a metódushívás. A réteg melyik metódusát kell meghívni, hogy helyesen működjön a kód? Írja le a kódot!
        /// <summary>
        /// Csapatnevek lekérése egy adott csapat nevének kihagyásával
        /// TeamListToTeamNameList beső függvény segítségével visszatérési érték megjelenítése
        /// TeamServiceException elkapása, és megjelenítése a Debug osztály segítségével. 
        /// Kivétel elkapás esetén üres lista a visszatérési érték.
        /// </summary>
        /// <param name="teamName">Ennek a csapatnak a neve nem szerepelhet a listába</param>
        /// <returns>Csapatnevek listája kihagyva egy adott nevű csapatot</returns>
        public List<string> getTeamNamesListExclude(string teamName)
        {
            try
            {
                List<Team> teams = teamService.getTeamsExclude(teamName);
                return TeamListToTeamNameList(teams);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
                List<string> teams = new List<string>();
                return teams;
            }
        }

        //Az addTeamToF1 metódusban a validation metódus két saját kivételt dob. Nézze meg melyek ezek és egészítsék ki a catch utasításokat a szükséges kóddal! A hibakezelő a dobott kivételek üzenetét írja ki! Egészítse ki a kódot!
        /// <summary>
        /// Csapat hozzáadása a Forma1-hez
        /// NameValidator segítségével teamName ellenőrzés
        /// NameNotValidNameIsEmptyException kivétel elkapás
        /// NameNotValidFirstLetterProblemException kivétel elkapása
        /// Elkapott kivételek eseté hiba megjelenítése a Debug osztály segítségével. 
        /// Ha a név megfelelő, akkor service réteg metódushívás
        /// Service réteg TeamServiceToGUIException és TeamServiceException elkapása.
        /// Elkapott kivételek eseté hiba megjelenítése a Debug osztály segítségével. 
        /// </summary>
        /// <param name="teamName">A csapat</param>
        /// <exception cref="ControllerException">TeamServiceToGUIException.Message</exception>
        public void addTeamToF1(string teamName)
        {            
            try
            {
                NameValidator nv = new NameValidator(teamName);
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException e) // Elkapom a kivételt "e"-vel deklarárom a kivételt, és a hiba üzenetet továbbítom a "Debug.WriteLine(e.Message);" felé.
            {
                Debug.WriteLine(e.Message);
                throw new ControllerException("Az üres név nem megfelelő csapatnév!");
            }
            catch (NameNotValidFirstLetterProblemException e)
            {
                Debug.WriteLine(e.Message);
                throw new ControllerException(teamName + " nem megfelelő csapatnév, mivel az első betű nem nagybetű.");
            }
            try
            {
                teamService.addTeam(teamName);
            }
            catch (TeamServiceToGUIException tstge)
            {
                Debug.WriteLine(tstge.Message);
                throw new ControllerException(tstge.Message);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        //A modifyTeamName metódusban a jelzett helyen hiányzik a metódushívás. Egészítse ki a kódot!
        /// <summary>
        /// Csapat nevének módosítása
        /// NameValidator segítségével newTeamName ellenőrzés
        /// NameNotValidNameIsEmptyException kivétel elkapás
        /// NameNotValidFirstLetterProblemException kivétel elkapása
        /// Elkapott kivételek eseté hiba megjelenítése a Debug osztály segítségével. 
        /// Ha a név megfelelő, akkor service réteg metódushívás
        /// Service réteg TeamServiceToGUIException és TeamServiceException elkapása.
        /// Elkapott kivételek eseté hiba megjelenítése a Debug osztály segítségével. 
        /// </summary>
        /// <param name="oldTeamName">A módosítandó csapat neve</param>
        /// <param name="newTeamName">A csoport új neve</param>
        /// <exception cref="ControllerException">TeamServiceToGUIException.Message</exception>
        public void modifyTeamName(string oldTeamName, string newTeamName)
        {
            try
            {
                NameValidator nv = new NameValidator(newTeamName);
                nv.validation();
                
            }
            catch (NameNotValidNameIsEmptyException nnve)
            {
                Debug.WriteLine(nnve.Message);
                throw new ControllerException(newTeamName + " nem megfelelő csapatnév, mivel üres.");
            }
            catch (NameNotValidFirstLetterProblemException nnve)
            {
                Debug.WriteLine(nnve.Message);
                throw new ControllerException(newTeamName + " nem megfelelő csapatnév, mivel az első betű nem nagybetű.");
            }
            try
            {
                teamService.modifyTeamName(oldTeamName, newTeamName);
            }
            catch (TeamServiceToGUIException tstge)
            {
                Debug.WriteLine(tstge.Message);
                throw new ControllerException(tstge.Message);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        /// <summary>
        /// Adott nevű csapat törlése
        /// Service réteg metódushívás
        /// Service réteg TeamServiceToGUIException és TeamServiceException elkapása.
        /// Elkapott kivételek eseté hiba megjelenítése a Debug osztály segítségével. 
        /// </summary>
        /// <param name="teamNameToDelete">A törlendő csapat neve</param>
        /// <exception cref="ControllerException">TeamServiceToGUIException.Message</exception>
        public void deleteTeam(string teamNameToDelete)
        {
            try
            {
                teamService.deleteTeam(teamNameToDelete);
            }
            catch (TeamServiceToGUIException tsge)
            {
                throw new ControllerException(tsge.Message);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        //A getF1Salary metódusban nincs meghatározva a metódus visszatérési értéke. Írja meg úgy a kódot, hogy a kiszámolt összeg mellet a "millió dollár" string is megjelenjen a visszatérési értékben!
        /// <summary>
        /// Forma1 összbérköltségének meghatározása
        /// Service réteg metódushívás
        /// Az összeg mellett a " millió dolár" szöveg jelenjen meg!
        /// Service réteg TeamServiceException elkapása. Ilyen esetben a visszatérési érték egy üres string
        /// Elkapott kivételek eseté hiba megjelenítése a Debug osztály segítségével. 
        /// </summary>
        /// <returns>A bérköltség szöveges formátumban</returns>
        /// <exception cref="ControllerException">TeamServiceToGUIException.Message</exception>
        public string getF1Salary()
        {
            try
            {
                int f1Salary = teamService.getF1Salary();
                string f1SalaryToView = f1Salary + " millió dollár";//string f1SalaryToView   int -hez hozzáfüzök egy stringet, akkor 
                
                // string = int+string (integer kaszolódik tudtod nélkül stringre) -> int+string -> string
                
                return f1SalaryToView; // 13 millió dollár
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
                return string.Empty;
            }
        }

        //Hasonló képen a coputeTeamSalary metódusban is hiányos a kód! Adja meg a hiányzó kódot, hogy a megfelelő értéket és mögötte a megfelelő szöveget adja vissza!
        /// <summary>
        /// Adott nevű csapat bérköltségének meghatározása
        /// </summary>
        /// <param name="teamName"></param>
        /// <returns></returns>
        public string computeTeamSalary(string teamName)
        {
            try
            {
                int teamSalary = teamService.getTeamSalary(teamName);

                string teamSalaryToView = teamSalary + " millió dollár";//string f1SalaryToView   int -hez hozzáfüzök egy stringet, akkor 

                // string = int+string (integer kaszolódik tudtod nélkül stringre) -> int+string -> string

                return teamSalaryToView; // 13 millió dollár
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// Versenyző áthelyezése egyik csapatból a másikba
        /// </summary>
        /// <param name="fromTeamName">Ebből a csapatból</param>
        /// <param name="toTeamName">Ebbe a csapatba</param>
        /// <param name="movedRacerName">Az áthelyezendő versenyző neve</param>
        public void moveToTeam(string fromTeamName, string toTeamName, string movedRacerName)
        {
            try
            {
                if (!teamService.isExistTeam(fromTeamName))
                    throw new ControllerException(fromTeamName + " csapat nem létezik, nem lehet áthelyezni.");
                if (!teamService.isExistTeam(toTeamName))
                    throw new ControllerException(toTeamName + " csapat nem létezik, nem lehet áthelyezni.");
                teamService.moveToTeam(fromTeamName, toTeamName, movedRacerName);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }
    }
}
