using Forma1.myexeption;
using Forma1.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.controller
{
    partial class F1Controller
    {
        /// <summary>
        /// Versenyző hozzáadása a csapathoz
        /// Ellenörizze, hogy az argumentumbeli számadadok megfelelő formátumuak-e, ha nem dobjon kivételt
        /// NameValidator, AgeValidator és SalaryValidatorral ellenörizze az adatokat. Ha valamelyik nem jó, dobjon kivételt
        /// Alsóbb rétegek segítségével, ellenörizze, hogy az adott nevű és életkorú versenyző tagja-e a csapatnak, ha igen dobjon kivételt
        /// Alsóbb rétegek segítségével kérje, le a következő versenyző ID-jét
        /// Hozza létre az új Racert-t. Az alsóbb rétegek kivételeit kapja el, és adja tovább
        /// Adja hozzá az új versenyzőt a csapathoz. Kapja el az elsó rétegek kivételeit és adja tovább
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        /// <param name="racerSalary">A versenyző bérköltsége</param>
        public void addRacerToTeam(string teamName, string racerName, string racerAge, string racerSalary)
        {
            //int racerAgeInt = 0;
            //int racerSalaryInt = 0;

            //try
            //{
            //    racerAgeInt = Convert.ToInt32(racerAge);
            //    racerSalaryInt = Convert.ToInt32(racerSalary);
            //}
            //catch (Exception e)
            //{
            //    throw new ControllerException(e.Message);
            //}

            bool sikerultKonvertalniAge = int.TryParse(racerAge, out int racerAgeInt);

            if (!sikerultKonvertalniAge)
            {
                throw new ControllerException("Nem számot tartalmaz a karakterlánc, nem sikerül konvertálni");
            }

            bool sikerultKonvertalniSalary = int.TryParse(racerSalary, out int racerSalaryInt);

            if (!sikerultKonvertalniSalary)
            {
                throw new ControllerException("Nem számot tartalmaz a karakterlánc, nem sikerül konvertálni");
            }

            // TODO: Age és Salary -> negatív szám VALDIÁCIÓ impl.

            bool letezik = teamService.existRacer(racerName, racerAgeInt);

            if (letezik)
            {
                throw new ControllerException("Létező versenyzőt nem lehet hozzáadni!");
            }

            /// Alsóbb rétegek segítségével kérje, le a következő versenyző ID-jét
            /// Hozza létre az új Racert-t. Az alsóbb rétegek kivételeit kapja el, és adja tovább
            /// Adja hozzá az új versenyzőt a csapathoz. Kapja el az elsó rétegek kivételeit és adja tovább

            int nextID = teamService.getNextRacerId();
            Racer racer;
            try
            {
                racer = new Racer(nextID, racerName, racerAgeInt, racerSalaryInt);
            }
            catch (Exception e)
            {
                throw new ControllerException(e.Message);
            }

            try
            {
                teamService.addReacerToTeam(teamName, racer);
            }
            catch (TeamServiceExeption e)
            {
                throw new ControllerException(e.Message);
            }
        }

        /// <summary>
        /// Versenyző adatainak módosítása
        /// Kösse be a Validatorokkat a metódusba!
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="oldRacerName">A versenyző régi neve</param>
        /// <param name="racerName">A versenyző új neve</param>
        /// <param name="racerAge">A versenyző új neve</param>
        /// <param name="racerSalary">A versenyző költsége</param>
        public void updateRacerInTeam(string teamName, string oldRacerName, string racerName, string racerAge, string racerSalary)
        {
            int racerAgeNumber = 0;
            if (!int.TryParse(racerAge, out racerAgeNumber))
                throw new ControllerException("A megadott életkor nem megfelelő alakú szám!");
            int racerSalaryNumber = 0;
            if (!int.TryParse(racerSalary, out racerSalaryNumber))
                throw new ControllerException("A megadott fizetés nem megfelelő alakú szám!");
            if (teamService.existRacer(racerName, racerAgeNumber))
                throw new ControllerException("Már létezik " + racerName + " nevű versenyző, aki " + racerAge + " éves.");
            try
            {
                int racerId = teamService.getRacerId(teamName, oldRacerName);
                if (racerId > 0)
                {
                    Racer newRacer = new Racer(racerId, racerName, racerAgeNumber, racerSalaryNumber);
                    teamService.updateReacerInTeam(teamName, oldRacerName, newRacer);
                }
                else
                    throw new ControllerException("A megadott versenyőjnek nem találom az azonosítáját");
            }
            catch (TeamServiceExeption tse)
            {
                throw new ControllerException(tse.Message);
            }
            catch (RacerException re)
            {
                throw new ControllerException(re.Message);
            }
        }

        /// <summary>
        /// Adott csapatban lévő versenyző törlése
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        public void deleteRacerInTeam(string teamName, string racerName, string racerAge)
        {
            int racerAgeNumber = 0;
            if (!int.TryParse(racerAge, out racerAgeNumber))
                throw new ControllerException("A megadott életkor nem megfelelő alakú szám!");
            try
            {
                teamService.deleteRacerInTeam(teamName, racerName, racerAgeNumber);
            }
            catch (TeamServiceExeption tse)
            {
                throw new ControllerException(tse.Message);
            }
        }

        /// <summary>
        /// Ha a csapat létezik, akkor a csapar versenyzőinek listája
        /// Ha a csapat tézeik, kérje le a versenyzőit
        /// A metódus visszatérési értékének megfelelő adatstruktúrába adja vissza a versenyzők neveit
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <returns></returns>
        public List<string> getTeamRacersName(string teamName)
        {
            return null;
        }

        /// <summary>
        /// Ha a csapat létezik, akkor adott nevű versenyzőjének megkeresése
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns></returns>
        public Racer searchRacerByName(string teamName, string racerName)
        {
            if (teamService.existTeamName(teamName))
                return teamService.searchRacerByName(teamName, racerName);
            return null;
        }
    }
}
