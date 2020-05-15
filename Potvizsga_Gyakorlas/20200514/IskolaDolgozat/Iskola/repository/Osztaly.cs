using System.Collections.Generic;
using System.Linq;

namespace IskolaProjekt.repository
{
    partial class Osztaly : IOsztaly, IOsztalyMuveletek // public class Osztaly extends Ősozstály implements IOsztaly (Java)
    {
        private string azonosito;
        private List<Diak> diakok;

        //2,feladat
        //Először a konstruktort készítse el. Ebben az osztály tulajdonságait (mezőit) kell megadni a
        //paraméter lapján, majd a diákok listáját példányosítani.
        /// <summary>
        /// Konstruktor
        /// Az osztály tulajdonság (mező) megadása a paraméter alapján
        /// Diákok listájának példányosítása
        /// </summary>
        /// <param name="nev">Az új osztály azonositó</param>
        public Osztaly(string azonosito)
        {
            // konstruktor feladata az adattagok inicializálása: azonosito, diakok kezdőértékbe helyezése...
            this.azonosito = azonosito;
            this.diakok = new List<Diak>();
        }

        //Ezután az IOsztaly interfaceben lévő metódusok megírása a feladat. Módosítsa vagy írja meg
        //a hiányzó metódusok kódját!
        //Ezután kódolja le, hogy az osztály, az IOsztalyMuveletek interfacetől is öröklődik, és írja meg
        //az interface által meghatározott metódusokat.A metódusok megírásában segít a kódban lévő
        //dokumentáció!
        /// <summary>
        /// getter
        /// </summary>
        /// <returns>Az osztály azonositoja</returns>
        public string getAzonosito()
        {
            return this.azonosito;
        }
        /// <summary>
        /// Módosítja az osztály azonosítóját (set)
        /// </summary>
        /// <param name="ujAzonosito">Osztály új azonositoja</param>
        public void modositOsztalyAzonositot(string ujAzonosito) // 10.B
        {
            this.azonosito = ujAzonosito;
        }
        /// <summary>
        /// Az osztály diákjainak listáját adja vissza
        /// </summary>
        /// <returns>A diákok osztályainak listája</returns>
        public List<Diak> getDiakok()
        {
            return this.diakok;
        }

        public void torolMindenDikotAzOsztalybol()
        {
            // lista tartalmát teljesen kiüríteni -> Clear()
            this.diakok.Clear();
        }

        public double getOsztalyAtlag()
        {
            // összegzés tétel + osztás darabszámmal

            double sumAtlagok = 0;

            foreach (Diak diak in diakok)
            {
                sumAtlagok += diak.getAtlag();
            }

            double atlag = (double)sumAtlagok / diakok.Count;

            return atlag;

            //return diakok.Average(diak => diak.getAtlag());

        }
    }
}
