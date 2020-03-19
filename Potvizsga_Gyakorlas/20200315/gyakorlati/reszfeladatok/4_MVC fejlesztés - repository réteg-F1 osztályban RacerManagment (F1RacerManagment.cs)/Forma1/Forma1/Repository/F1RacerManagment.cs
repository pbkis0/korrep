using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class F1 : IF1
    {
        /// <summary>
        /// A teamName által meghatározott csapatban hány versenyző van
        /// Ha a csapat nem létezik dobjon kivételt 
        /// </summary>
        /// <param name="teamName">A keresett csapat neve</param>
        /// <returns>A csapat versenyzőinek száma</returns>
        /// <exception cref="F1Exception">Ha nem találja az adott nevű csapatot</exception>
        public int getNumberOfRacers(string teamName)
        {
            //1, feladat ->public int getNumberOfRacers(string teamName)
            foreach(Team t in teams)
            {
                if(t.getName()==teamName)
                {
                    return t.getNumberOfRacers();
                }
            }
            throw new F1Exception("Ha nem találja az adott nevű csapatot");
        }

        /// <summary>
        /// A csapat versenyzőinek neve
        /// </summary>
        /// <param name="teamName">A keresett csapat neve</param>
        /// <returns>Lista, amely tartalmazza a csapat versenyzőinek nevét</returns>
        public List<string> getRacerNameFromTheTeam(string teamName)
        {
            //2. feladat  ->public List<string> getRacerNameFromTheTeam(string teamName)
            foreach (Team t in teams)
            {
                if (t.getName() == teamName) // beazonosítttaom, azt a t objektumot, akire hívhatom a versenyző stringlista gettert
                {
                    return t.getRacerNames(); // return stringlista
                }
            }
            return null;
        }

        /// <summary>
        /// Megahtározza, hogy melyik a következő lehetséges versenyző ID
        /// Végignézi az összes csapatot
        /// Meghatározza a legnagyobb ID-t
        /// Ha az nulla, akkor egyet ad vissza, egyébként egyel többet mint a megtalált max
        /// </summary>
        /// <returns>Következő lehetséges ID</returns>
        public int getNextRacerId()
        {
            //3. feladat ->public int getNextRacerId()
            int max = 0;
            foreach (Team t in teams)
            {
                if (max < t.getMaxId())
                {
                    max = t.getMaxId();
                }
            }

            if (max == 0)
            {
                return 1;
            }
            else
            {
                return max + 1;
            }
        }

        /// <summary>
        /// Adott nevű csapathoz hozzáadja a versenyzőt
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="newRacer">Az új versenyző</param>
        /// <exception cref="F1Exception">Ha nem találja az adott nevű csapatot</exception>
        public void addRacerToTeam(string teamName, Racer newRacer) 
        {
            //4.feladat ->public void addRacerToTeam(string teamName, Racer newRacer)
            foreach(Team t in teams)
                if(t.getName()==teamName)
                {
                    t.addRacer(newRacer);
                    return;     //Ha "void" szerepel a függvényben, mindig az elvégzendő művelet alatt kell legyen a  "return".
                }
            throw new F1Exception("Ha nem találja az adott nevű csapatot");
        }

        /// <summary>
        /// Adott nevű csapatban, adott versenyzőnek az ID-je
        /// Megkersi a versenyzőt, és a Team osztály segítségével megadja az adott nevű versenyző ID-jét
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>Adott versenyző ID-je</returns>
        /// <exception cref="F1Exception">Ha az adott nevű csapat nem létezik</exception>
        public int getRacerId(string teamName, string racerName)
        {
            //5. feladat->public int getRacerId(string teamName, string racerName)
            foreach (Team t in teams)
                if (t.getName() == teamName)
                {
                    return t.getRacerId(racerName);
                }
            throw new F1Exception("Ha az adott nevű csapat nem létezik");
        }

        /// <summary>
        /// Adott csapatban egy versrenyző adatainak módosítása
        /// A módosításhoz hoasználja fel a Team osztály metódusát
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="oldRacerName">A versenyző régi neve</param>
        /// <param name="newRacer">Az új versenyző</param>
        /// <exception cref="F1Exception">Ha az adott nevű csapat nem létezik</exception>
        public void updateReacerInTeam(string teamName, string oldRacerName, Racer newRacer)
        {        
        }

        /// <summary>
        /// Adott versenyző adatainak törlése
        /// A törléshez használja fel a Team osztály metódusát
        /// </summary>
        /// <param name="teamName">A csapat neve, ahonnan töröljük a versenyzőt</param>
        /// <param name="racerName">A törlendő versenyző neve</param>
        /// <param name="racerAge">A törlendő versenyző életkora</param>
        /// <exception cref="F1Exception">Ha az adott nevű csapat nem létezik</exception>
        public void deleteRacerInTeam(string teamName, string racerName, int racerAge)
        {            
        }

        public int getTeamSalary(string teamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    return t.getTeamSalary();
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet bérköltséget számolni.");
        }
    }
}
