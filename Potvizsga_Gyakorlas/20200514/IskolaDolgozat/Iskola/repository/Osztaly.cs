using System.Collections.Generic;

namespace IskolaProjekt.repository
{
    partial class Osztaly : IOsztaly, IOsztalyMuveletek
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
        /// <summary>
        /// getter
        /// </summary>
        /// <returns>Az osztály azonositoja</returns>
        public string getAzonosito()
        {
            return null;
        }
        /// <summary>
        /// Módosítja az osztály azonosítóját
        /// </summary>
        /// <param name="ujAzonosito">Osztály új azonositoja</param>
        public void modositOsztalyAzonositot(string ujAzonosito)
        {
        }
        /// <summary>
        /// Az osztály diákjainak listáját adja vissza
        /// </summary>
        /// <returns>A diákok osztályainak listája</returns>
        public List<Diak> getDiakok()
        {
            return null;
        }

        public void torolMindenDikotAzOsztalybol()
        {
        }

        public double getOsztalyAtlag()
        {
            return 0;
        }
    }
}
