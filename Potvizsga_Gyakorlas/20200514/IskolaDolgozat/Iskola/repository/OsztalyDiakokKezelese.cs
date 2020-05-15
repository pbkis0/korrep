using IskolaProjekt.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.repository
{
    partial class Osztaly:IOsztalyDiakokKezelese
    {
        /// <summary>
        /// Megadja az osztlyban lévő diákok számát
        /// </summary>
        /// <returns>Osztályba lévő diákok száma</returns>
        public int getDiakokSzama()
        {
            return 0;
        }

        /// <summary>
        /// Új diak felvétele az osztályba
        /// Ha a diák már létezik dobjon kivételt
        /// A diák akkor létezik már, ha minden adata megegyezi egy meglévő diákkal
        /// </summary>
        /// <param name="diak">új diak</param>
        /// <exception cref="OsztalyException">Két úgyan olyan adatú diák nem lehet</exception>
        public void hozzadDiak(Diak diak)
        {
            foreach (Diak d in diakok)
            {
                if (d.getId() == diak.getId() && d.getNev() == diak.getNev() && d.getEletkor() == diak.getEletkor() && d.getAtlag() == diak.getAtlag())
                {
                    throw new OsztalyException("Két úgyan olyan adatú diák nem lehet");
                }
            }

            diakok.Add(diak);
        }

        //A torolDiak és frissitDiak metódusokban kivételdobást készítsen, ha az adott adatokkal jelölt
        //diák nem található!
        /// <summary>
        /// Törli a diákot az osztályból
        /// </summary>
        /// <param name="nev">Törlendő diák neve</param>
        /// <param name="eletkor">Törlendő diák életkora</param>
        /// <exception cref="OsztalyException">A diák az osztálynak nem tagja, nem lehet törlni</exception>
        public void torolDiak(string nev, int eletkor)
        {
            foreach (Diak diak in diakok)
            {
                if (diak.getNev() == nev && diak.getEletkor() == eletkor)
                {
                    diakok.Remove(diak);
                    return; // adott műveletet elvégeztük, kilépünk a függvény végrehajtásából
                }
            }
            throw new OsztalyException("A diák az osztálynak nem tagja, nem lehet törlni");
        }

        /// <summary>
        /// Módosítja a diák adatait
        /// </summary>
        /// <param name="nev">Módosítanidó diák neve</param>
        /// <param name="ujDiak">A módosított versenyző adatai</param>
        /// <exception cref="OsztalyException">A megadott nevű diák nincs az osztályban, nem lehet módosítani</exception>
        public void frissitDiak(string nev, Diak ujDiak)
        {
            foreach (Diak diak in diakok)
            {
                if (diak.getNev() == nev)
                {
                    diak.frissit(ujDiak);
                    return;
                }
            }
            throw new OsztalyException("A megadott nevű diák nincs az osztályban, nem lehet módosítani");
        }

        /// <summary>
        /// Megkeresi az adott nevű diákot
        /// </summary>
        /// <param name="diakNeve">A keresendő diák neve</param>
        /// <returns>Ha van, akkor a diák, ha nincs akkor null</returns>
        public Diak keresDiakotNevAlapjan(string diakNeve)
        {
            foreach (Diak d in diakok)
            {
                if (d.getNev() == diakNeve)
                {
                    return d;
                }
            }
            return null;
        }

        /// <summary>
        /// Megadja, hogy a diák lézetik-e
        /// </summary>
        /// <param name="diakNeve">Diák neve</param>
        /// <param name="diakEletkora">Diák életkora</param>
        /// <returns>Ha létezik, akkor true, ha nem akkor false</returns>
        public bool vanEDiak(string diakNeve, int diakEletkora)
        {
            foreach (Diak d in diakok)
            {
                if (d.getNev() == diakNeve && d.getEletkor() == diakEletkora)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Megadja az adott nevű diák id-jét
        /// </summary>
        /// <param name="diakNeve">Diák neve</param>
        /// <returns>A diák id-he ha a diák tagja az osztálynak, ha nem -1</returns>
        public int getDaikId(string diakNeve)
        {
            foreach (Diak d in diakok)
            {
                if (d.getNev() == diakNeve)
                {
                    return d.getId();
                }
            }
            return -1;
        }

        /// <summary>
        /// Megahtározza a legnagyobb diák id-t az osztályban
        /// </summary>
        /// <returns>A legnagyobb azonosító</returns>
        public int getMaxId()
        {
            int maxDiakId = -1;
            foreach (Diak r in diakok)
                if (r.getId() > maxDiakId)
                    maxDiakId = r.getId();
            return maxDiakId;
        }
    }
}
