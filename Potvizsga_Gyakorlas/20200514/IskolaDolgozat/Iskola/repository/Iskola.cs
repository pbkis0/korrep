using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IskolaProjekt.myexeption;

namespace IskolaProjekt.repository
{
    partial class Iskola : IIskola
    {
        List<Osztaly> osztalyok;

        /// <summary>
        /// Iskola konstruktor
        /// </summary>
        public Iskola()
        {
            osztalyok = new List<Osztaly>();
        }

        /// <summary>
        /// Az osztályok listája
        /// </summary>
        /// <returns>Az osztályok listája</returns>
        public List<Osztaly> getOsztalyok()
        {
            return osztalyok;
        }

        /// <summary>
        /// Új osztaly hozzáadása az iskolához
        /// </summary>
        /// <param name="osztaly">Az osztály</param>
        public void hozzad(Osztaly osztaly)
        {
            osztalyok.Add(osztaly);
        }

        //Keresse meg a „torol” metódust. Ez a metódus törli az osztályt. Az osztályba még járhatnak
        //diákok.Őket az iskola törlése előtt törölje.Erre már írt metódust a diákok kezelése során.
        //Ennek a metódusnak a megfelelő helyen történő hívásával egészítse ki a „torol” metódust.
        /// <summary>
        /// Adott nevű osztály törlése
        /// 
        /// A kód jó működése érdekében ki kell egészíteni
        /// 
        /// </summary>
        /// <param name="osztalyAzonosito">Az osztály azonositoja</param>
        /// <exception cref="IskolaException">Az adott osztály nem létezik.</exception>
        public void torol(string osztalyAzonosito)
        {
            int index = 0;
            foreach (Osztaly osztaly in osztalyok)
            {
                if (osztaly.getAzonosito() == osztalyAzonosito)
                {
                    osztaly.torolMindenDikotAzOsztalybol();
                    osztalyok.RemoveAt(index);
                    // osztalyok.Remove(osztaly);
                    return;
                }
                index = index + 1;
            }
            throw new IskolaException($"{osztalyAzonosito} nevű osztály nem létezik, nem lehet törölni!");
        }

        /// <summary>
        /// Adott nevű osztály nevének módosítása
        /// Kivétel dobás, ha a osztály nem létezik
        /// 
        /// A kód "bug"-ot tartalmaz. Javítsa azt!
        /// 
        /// </summary>
        /// <param name="osztalyAzonosito">A csapat régi azonositoja</param>
        /// <param name="ujOsztalyAzonosito">A csapat új azonositoja</param>
        /// <exception cref="IskolaException">Az adott nevű osztály nem létezik.</exception>
        public void modosit(string osztalyAzonosito, string ujOsztalyAzonosito)
        {
            foreach (Osztaly o in osztalyok)
            {
                if (o.getAzonosito() == osztalyAzonosito)
                {
                    o.modositOsztalyAzonositot(ujOsztalyAzonosito);
                }
            }
            throw new IskolaException($"{osztalyAzonosito} nevű osztály nem létezik, nem lehet módosítani");
        }

        /// <summary>
        /// Van-e adott azonosítójú osztály
        /// </summary>
        /// <param name="osztalyAzonosito">A keresett osztaly azonositoja</param>
        /// <returns>true ha van és false ha nincs</returns>
        public bool vanEOsztaly(string osztalyAzonosito)
        {
            return false;
        }
    }
}
