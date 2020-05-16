using IskolaProjekt.myexeption;
using System.Collections.Generic;

namespace IskolaProjekt.repository
{
    partial class Iskola : IIskola
    {
        //hozzadDiakotOsztalyhoz
        /// <summary>
        /// Az adott azonosítójú osztályhoz hozzáadja az adott diákot
        /// </summary>
        /// <param name="osztalyAzonosito">Ehhez az osztályhoz kell hozzáadni a diákot</param>
        /// <param name="ujDiak">Az osztályhoz ezt a diákot kell hozzáadni</param>
        /// <exception cref="IskolaException">Az adott azonosítójú osztály nem létezik, nem lehet új diákoz hozzáadni.</exception>
        public void hozzadDiakotOsztalyhoz(string osztalyAzonosito, Diak ujDiak)
        {
            foreach (Osztaly o in osztalyok)
            {
                if (o.getAzonosito() == osztalyAzonosito)
                {
                    try
                    {
                        o.hozzadDiak(ujDiak);
                        return;
                    }
                    catch (OsztalyException e)
                    {
                        throw new IskolaException(e.Message);
                    }
                }
            }
            throw new IskolaException("Az adott azonosítójú osztály nem létezik, nem lehet új diákoz hozzáadni.");
        }


        //modositDiakotOsztalyban
        /// <summary>
        /// Adott azonosítójú osztályban egy diák adatainak frissítése
        /// </summary>
        /// <param name="osztalyAzonosito">Ebben az osztályban kell frissíteni a diák adatait</param>
        /// <param name="diakRegiNeve">A módosítandó diák régi neve</param>
        /// <param name="ujDiak">Az objektum tartalmazza a diák új adatait</param>
        /// <exception cref="IskolaException">Az adott azonosítójú osztály nem létezik, nem lehet módosítani a diákjának adatait.</exception>
        public void modositDiakotOsztalyban(string osztalyAzonosito, string diakRegiNeve, Diak ujDiak)
        {
            foreach (Osztaly o in osztalyok)
            {
                if (o.getAzonosito() == osztalyAzonosito)
                {
                    try
                    {
                        o.frissitDiak(diakRegiNeve, ujDiak);
                        return;
                    }
                    catch (OsztalyException e)
                    {
                        throw new IskolaException(e.Message);
                    }
                }
            }
            throw new IskolaException("Az adott azonosítójú osztály nem létezik, nem lehet módosítani a diákjának adatait.");
        }

        /// <summary>
        /// Az adott azonosítújú osztályból törli a diákot
        /// </summary>
        /// <param name="osztalyAzonosito">Ebből az osztályból kell törölni a diákot</param>
        /// <param name="diakNev">A törlendő diák neve</param>
        /// <param name="diakEletkor">A törlendő diák életkora</param>
        /// <exception cref="IskolaException">Az adott azonosítójú osztály nem létezik, nem lehet törölni a diákot.</exception>
        public void torolDiakotOsztalybol(string osztalyAzonosito, string diakNev, int diakEletkor)
        {
        }

        //DOKSI
        public int getDiakokSzama(string osztalyAzonosito)
        {
            foreach (Osztaly t in osztalyok)
            {
                if (t.getAzonosito() == osztalyAzonosito)
                {
                    return t.getDiakokSzama();
                }
            }
            throw new IskolaException($"{osztalyAzonosito} nevű osztály nem létezik, nem lehet megállapítani, hány diák jár az osztályba.");
        }



        // DOKSI
        public List<Diak> getOsztalyDiakjai(string osztalyAzonosito)
        {
            foreach (Osztaly osztaly in osztalyok)
                if (osztaly.getAzonosito() == osztalyAzonosito)
                    return osztaly.getDiakok();
            return null;
        }

        //DOKSI
        public int getKovetekzoDiakID()
        {
            int maxId = -1;
            foreach (Osztaly osztaly in osztalyok)
            {
                int osztalyMaxDiakID = osztaly.getMaxId();
                if (osztalyMaxDiakID > maxId)
                    maxId = osztalyMaxDiakID;
            }
            if (maxId > 0)
                return maxId + 1;
            else
                return 1;
        }

        //DOKSI
        public int getDiakId(string osztalyAzonosito, string diakNev)
        {
            foreach (Osztaly osztaly in osztalyok)
            {
                if (osztaly.getAzonosito() == osztalyAzonosito)
                {
                    return osztaly.getDaikId(diakNev);
                }
            }
            throw new IskolaException(osztalyAzonosito + " nevű osztály nem létezik, nem lehet azonosítót lekérni.");
        }         

        /// <summary>
        /// Van-e adott diak
        /// </summary>
        /// <param name="diakNev">A keresett diák neve</param>
        /// <param name="diakEletkor">A keresett diák életkora</param>
        /// <returns>true ha van és false ha nincs</returns>
        public bool vanEDiak(string diakNev, int diakEletkor)
        {
            foreach (Osztaly osztaly in osztalyok)
            {
                if (osztaly.vanEDiak(diakNev, diakEletkor))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Adott osztály adott nevű diákjának megkeresése
        /// </summary>
        /// <param name="osztalyAzonosito">Az osztaály neve, amelynek tagja a diák</param>
        /// <param name="diakNev">A versenyző neve</param>
        /// <returns>A diák</returns>
        /// <exception cref="IskolaException">Az adott nevű osztály nem létezik.</exception>
        public Diak keresDiakotNevAlapjan(string osztalyAzonosito, string diakNev)
        {
            foreach (Osztaly osztaly in osztalyok)
            {
                if (osztaly.getAzonosito() == osztalyAzonosito)
                {
                    return osztaly.keresDiakotNevAlapjan(diakNev);
                }
            }
            throw new IskolaException(osztalyAzonosito + " nevű osztály nem létezik, nem lehet " + diakNev + " nevű versenyzője.");
        }
    }
}
