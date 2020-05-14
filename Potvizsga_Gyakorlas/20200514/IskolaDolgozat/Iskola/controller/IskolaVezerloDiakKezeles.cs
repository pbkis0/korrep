using IskolaProjekt.myexeption;
using IskolaProjekt.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.controller
{
    partial class IskolaVezerlo
    {
        /// <summary>
        /// Diá hozzáadása az osztályhoz
        /// </summary>
        /// <param name="osztalyAzonosito">Az osztaly azonositó</param>
        /// <param name="diakNeve">A diák neve</param>
        /// <param name="diakEletkora">A diák életkora</param>
        /// <param name="diakAtlaga">A diák átlaga</param>
        public void hozzaadDiakotOsztalyhoz(string osztalyAzonosito, string diakNeve, string diakEletkora, string diakAtlaga)
        {
            int diakEletkoraSzam = 0;
            if (!int.TryParse(diakEletkora, out diakEletkoraSzam))
                throw new ControllerException("A megadott életkor nem megfelelő alakú szám!");
            double diakAtlagaSzam = 0.0;
            if (!double.TryParse(diakAtlaga, out diakAtlagaSzam))
                throw new ControllerException("A megadott átlag nem megfelelő alakú szám!");
            if (iskolaSzolgaltatas.vanEDiak(diakNeve,diakEletkoraSzam))
                throw new ControllerException("Már létezik "+diakNeve+" nevű diák, aki "+diakEletkora+" éves.");
            try
            {
                int diakId=iskolaSzolgaltatas.getKovetkezoDiakId();
                Diak ujDiak = new Diak(diakId, diakNeve, diakEletkoraSzam, diakAtlagaSzam);
                iskolaSzolgaltatas.hozzadDiakotOsztalyhoz(osztalyAzonosito, ujDiak);
            }
            catch(OsztalySzolgaltatasExeption e)
            {
                throw new ControllerException(e.Message);
            }
            catch(DiakException e)
            {
                throw new ControllerException(e.Message);
            }
        }

        /// <summary>
        /// Diák adatainak módosítása
        /// </summary>
        /// <param name="osztalyAzonosito">Az osztály neve</param>
        /// <param name="diakRegiNeve">A diák régi neve</param>
        /// <param name="diakUjNeve">A diák új neve</param>
        /// <param name="diakUjEletkora">A diák új életkora</param>
        /// <param name="diakUjAtlaga">A diák új átlaga</param>
        public void modositDiakotOsztalyba(string osztalyAzonosito, string diakRegiNeve, string diakUjNeve, string diakUjEletkora, string diakUjAtlaga)
        {
        }

        /// <summary>
        /// Adott osztályban lévő diák törlése
        /// </summary>
        /// <param name="osztalyAzonosito">Az osztály azonosítója</param>
        /// <param name="diakNeve">A diák neve</param>
        /// <param name="diakEletkora">A diák életkora</param>
        public void torolAdottOsztalybolAdottDiakot(string osztalyAzonosito, string diakNeve, string diakEletkora)
        {
            int diakEletkoraSzam = 0;
            if (!int.TryParse(diakEletkora, out diakEletkoraSzam))
                throw new ControllerException("A megadott életkor nem megfelelő alakú szám!");
            try
            {
                iskolaSzolgaltatas.torolDiakotOsztalybol(osztalyAzonosito, diakNeve, diakEletkoraSzam);
            }
            catch (OsztalySzolgaltatasExeption e)
            {
                throw new ControllerException(e.Message);
            }
        }

        /// <summary>
        /// Ha az osztály létezik, akkor az osztályba járó diákok neveinek listája
        /// </summary>
        /// <param name="osztalyAzonosito">Az osztály azonositoja</param>
        /// <returns>Az osztályba járó diákok neveinek listája</returns>
        public List<string> megahtarozOsztalyDiakjainakNevet(string osztalyAzonosito)
        {
            if (iskolaSzolgaltatas.vanEAdottAzonositojuOsztaly(osztalyAzonosito))
            {
                List<string> diakNevek = new List<string>();
                List<Diak> diakok= iskolaSzolgaltatas.getDiakokOsztalybol(osztalyAzonosito);
                foreach (Diak d in diakok)
                    diakNevek.Add(d.getNev());
                return diakNevek;
            }
            return null;
        }

        /// <summary>
        /// Ha az osztály létezik, akkor adott nevű diákjának megkeresése
        /// </summary>
        /// <param name="osztalyAzonosito">Az osztály neve</param>
        /// <param name="diakNeve">A diák neve</param>
        /// <returns>Adott nevű diák</returns>
        public Diak keresDiakotOsztalyban(string osztalyAzonosito, string diakNeve)
        {
            if (iskolaSzolgaltatas.vanEAdottAzonositojuOsztaly(osztalyAzonosito))
                return iskolaSzolgaltatas.keresDiakotOsztalybanNevAlapjan(osztalyAzonosito, diakNeve);
            return null;
        }
    }
}
