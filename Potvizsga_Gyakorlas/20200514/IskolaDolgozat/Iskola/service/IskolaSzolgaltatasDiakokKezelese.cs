using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IskolaProjekt.repository;

namespace IskolaProjekt.service
{
    partial class IskolaSzolgaltatas
    {
        /// <summary>
        /// A következő diák ID-jének meghatározása a repository segítségével
        /// </summary>
        /// <returns>a következő diák ID-je</returns>
        public int getKovetkezoDiakId()
        {
            return iskolaAdattar.getKovetekzoDiakID();
        }

        /// <summary>
        /// Diák hozzáadása adott nevű osztályhoz
        /// </summary>
        /// <param name="osztalyNeve">Az osztály neve</param>
        /// <param name="ujDiak">Az új diák</param>
        public void hozzadDiakotOsztalyhoz(string osztalyNeve, Diak ujDiak)
        {
            iskolaAdattar.hozzadDiakotOsztalyhoz(osztalyNeve, ujDiak);
        }

        /// <summary>
        /// Adott nevű osztályba adott nevű diák keresése a repository segítségével
        /// </summary>
        /// <param name="osztalyNeve">Az osztály neve</param>
        /// <param name="diakNeve">A diák neve</param>
        /// <returns>A megtalált diak</returns>
        public Diak keresDiakotOsztalybanNevAlapjan(string osztalyNeve, string diakNeve)
        {
            return iskolaAdattar.keresDiakotNevAlapjan(osztalyNeve, diakNeve);
        }

        /// <summary>
        /// Adott nevű osztályba adott nevű versenyzőnek az ID-je
        /// </summary>
        /// <param name="osztalyNeve">Az osztály neve</param>
        /// <param name="diakNeve">A diák neve</param>
        /// <returns>Az ID</returns>
        public int getDiakID(string osztalyNeve, string diakNeve)
        {
            return iskolaAdattar.getDiakId(osztalyNeve, diakNeve);
        }

        /// <summary>
        /// Adott nevű osztályba adott nevű diák adatainak lecserélése új adatokkal
        /// A feladat a repository megfelelő függvénye valósítja meg
        /// </summary>
        /// <param name="osztalyNev">Az osztály neve</param>
        /// <param name="diakRegiNeve">A módosítandó diák neve</param>
        /// <param name="ujDiak">Az új diak adatai</param>
        public void modositDiakotOsztalyba(string osztalyNev, string diakRegiNeve, Diak ujDiak)
        {
            iskolaAdattar.modositDiakotOsztalyban(osztalyNev, diakRegiNeve, ujDiak);
        }

        /// <summary>
        /// Adott osztalyba adott nevű és életkorú diák törlése
        /// A feladat a repository megfelelő függvénye valósítja meg
        /// </summary>
        /// <param name="osztalyNev">Az osztaly neve</param>
        /// <param name="diakNev">A diák neve</param>
        /// <param name="diakEletkora">A diák életkora</param>
        public void torolDiakotOsztalybol(string osztalyNev, string diakNev, int diakEletkora)
        {
            iskolaAdattar.torolDiakotOsztalybol(osztalyNev, diakNev, diakEletkora);
        }
        // 9feladat:
        // A szolgáltatás rétegben a feladata az „athelyezOsztalyba” metódus megírása! A metódust az
        //„IskolaSzolgaltatasDiakokKezelese.cs” állományban találja.A feladat megoldása három egyszerű
        //feladatból áll, amelyet az alsóbb rétegek segítségével tud megvalósítani:
        // keresse meg az metódus paraméterei alapján az áthelyezendő diákot
        // törölje abból az osztályból ahová járt
        // helyezze át abba az osztályba, ahova járni fog
        /// <summary>
        /// Diák átírása egyik osztályból a másikba
        /// Az alsóbb rétegek segítségével:
        ///  - keresse meg az metódus paraméterei alapján az áthelyezendő diákot
        ///  - törölje abból az osztályból ahová járt
        ///  - helyezze át abba az osztályba, ahova járni fog
        /// </summary>
        /// <param name="innenOsztalyNeve">Ebből az osztályból rakjuk át</param>
        /// <param name="ideOsztalyNeve">Ebbe az osztályba rakjuk át</param>
        /// <param name="atirandoDiakNeve">A versenyző neve</param>
        public void athelyezOsztalyba(string innenOsztalyNeve, string ideOsztalyNeve, string atirandoDiakNeve)
        {
            try
            {
                Diak diak = iskolaAdattar.keresDiakotNevAlapjan(innenOsztalyNeve, atirandoDiakNeve);
                iskolaAdattar.torolDiakotOsztalybol(innenOsztalyNeve, diak.getNev(), diak.getEletkor());
                iskolaAdattar.hozzadDiakotOsztalyhoz(ideOsztalyNeve, diak);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Adott nevé és életkorú diák lézetik-e
        /// A feladat a repository megfelelő függvénye valósítja meg
        /// </summary>
        /// <param name="diakNeve">A diák neve</param>
        /// <param name="diakEletkora">A diák életkora</param>
        /// <returns>true ha van és false ha nincs</returns>
        public bool vanEDiak(string diakNeve, int diakEletkora)
        {
            if (iskolaAdattar.vanEDiak(diakNeve, diakEletkora))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Adott osztályba lévő diákok
        /// </summary>
        /// <param name="osztalyNeve">Osztály neve</param>
        /// <returns>Az osztály diákjai</returns>
        public List<Diak> getDiakokOsztalybol(string osztalyNeve)
        {
            return iskolaAdattar.getOsztalyDiakjai(osztalyNeve);
        }

    }
}
