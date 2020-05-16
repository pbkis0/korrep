using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IskolaProjekt.myexeption;
using IskolaProjekt.repository;

namespace IskolaProjekt.service
{
    partial class IskolaSzolgaltatas
    {
        TestAdatok testAdatok;
        Iskola iskolaAdattar;
        Osztaly osztaly;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public IskolaSzolgaltatas()
        {
            testAdatok = new TestAdatok();
            iskolaAdattar = new Iskola();
        }

        /// <summary>
        /// Tesztadatok lekérése
        /// </summary>
        public void lekerTesztAdatokat()
        {
            iskolaAdattar = testAdatok.getTestAdatok();
        }

        /// <summary>
        /// Adott nevű osztály létrehozása és hozzáadása a repository-hoz
        /// </summary>
        /// <param name="osztalyNev">A létrehozandó osztály neve</param>
        public void hozzadOsztaly(string osztalyNev)
        {
            Osztaly o = new Osztaly(osztalyNev);
            iskolaAdattar.hozzad(o);
        }

        internal double getIskolaAtlag()
        {
            return iskolaAdattar.getIskolaAtlag();
        }

        /// <summary>
        /// Adott nevű osztály átnevezése új osztály névre
        /// Repository segítségével az osztály régi nevének lecserélése az új névre
        /// </summary>
        /// <param name="osztalyRegiNev"></param>
        /// <param name="osztalyUjNev"></param>
        public void modositOsztalyNevet(string osztalyRegiNev, string osztalyUjNev)
        {
            try
            {
                iskolaAdattar.modosit(osztalyRegiNev, osztalyUjNev);
            }
            catch (IskolaException ie)
            {
                throw new OsztalySzolgaltatasExeption(ie.Message);
            }
        }

        /// <summary>
        /// Ha az osztálynak nincs tagja akkor annak törlése
        /// Ellenörizze, hogy az osztálynak nincs-e tagja.
        /// Ha nincs törölje. Ha van, akkor dobjon kivételt.
        /// </summary>
        /// <param name="torlendoOsztalyNeve"></param>
        public void torlesOsztaly(string torlendoOsztalyNeve)
        {
            int diakokSzamaAzOsztalyban = iskolaAdattar.getDiakokSzama(torlendoOsztalyNeve);
            if (diakokSzamaAzOsztalyban > 0)
                throw new OsztalySzolgaltatasExeption(torlendoOsztalyNeve + " osztálynak van még diákja, nem lehet törölni!");
            else
                try
                {
                    iskolaAdattar.torol(torlendoOsztalyNeve);
                }
                catch (IskolaException f1e)
                {
                    throw new OsztalySzolgaltatasExeption(f1e.Message);
                }
        }

        /// <summary>
        /// Összes osztály adatainak lekérése
        /// </summary>
        /// <returns></returns>
        public List<Osztaly> getOsztalyok()
        {
            return iskolaAdattar.getOsztalyok();
        }

        /// <summary>
        /// Adott nevű osztály létezik-e
        /// </summary>
        /// <param name="osztalyNev">A keresett osztály neve</param>
        /// <returns>true ha igen, és false ha nem</returns>
        public bool vanEAdottAzonositojuOsztaly(string osztalyNev)
        {
            if (iskolaAdattar.vanEOsztaly(osztalyNev))
                return true;
            else
                return false;
        }

    }
}
