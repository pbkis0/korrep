using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IskolaProjekt.myexeption;
using IskolaProjekt.repository;
using IskolaProjekt.service;
using IskolaProjekt.validation;

namespace IskolaProjekt.controller
{
    partial class IskolaVezerlo
    {
        IskolaSzolgaltatas iskolaSzolgaltatas;

        public IskolaVezerlo()
        {
            iskolaSzolgaltatas = new IskolaSzolgaltatas();
        }

        /// <summary>
        /// Test adatok inicializálása
        /// </summary>
        public void betoltTesztAdatokat()
        {
            iskolaSzolgaltatas.lekerTesztAdatokat();
        }

        /// <summary>
        /// Osztály azonositók lekérése
        /// </summary>
        /// <returns>Osztály azonositók listája</returns>
        public List<string> getOsztalyAzonosito()
        {
            List<string> osztalyAzonositok = new List<string>();
            List<Osztaly> teams = iskolaSzolgaltatas.getOsztalyok();
            foreach(Osztaly t in teams)
            {
                osztalyAzonositok.Add(t.getAzonosito());
            }
            return osztalyAzonositok;
        }

        internal string getIskolaAtlag()
        {
            double iskolaAtlag = iskolaSzolgaltatas.getIskolaAtlag();
           return iskolaAtlag.ToString();
        }

        /// <summary>
        /// Osztály azonosítók lekérése egy adott osztály nevének kihagyásával
        /// </summary>
        /// <param name="kihagyottOsztalyAzonosito">Ennek az osztálynak a neve nem szerepelhet a listába</param>
        /// <returns></returns>
        public List<string> getOsztalyAzonositokKihagyva(string kihagyottOsztalyAzonosito)
        {
            List<string> osztalyAzonositok = new List<string>();
            List<Osztaly> osztalyok = iskolaSzolgaltatas.getOsztalyok();
            foreach(Osztaly t in osztalyok)
            {
                if (t.getAzonosito()!=kihagyottOsztalyAzonosito)
                    osztalyAzonositok.Add(t.getAzonosito());
            }
            return osztalyAzonositok;
        }

        /// <summary>
        /// Osztály hozzáadása a Forma1-hez
        /// </summary>
        /// <param name="osztalyAzonosito">Az osztály azonosítója</param>
        public void hozzadOsztalytIskolahoz(string osztalyAzonosito)
        {
            if (iskolaSzolgaltatas.vanEAdottAzonositojuOsztaly(osztalyAzonosito))
                throw new ControllerException(osztalyAzonosito + " csapat már létezik.");
            try
            {
                AzonositoEllenorzo ae = new AzonositoEllenorzo(osztalyAzonosito);
                ae.ellenorzes();
            }
            catch (ElsoKetBetuNemSzamException)
            {
                throw new ControllerException(osztalyAzonosito + " első két betűje szám kell legyen.");
            }
            catch (HarmadikKarakterNemPontException)
            {
                throw new ControllerException(osztalyAzonosito + " nem megfelelő osztályazonosító, mivel az harmadik karakter nem pont.");
            }
            catch (NegyedikKarakerNemKisBetuException)
            {
                throw new ControllerException(osztalyAzonosito + " nem megfelelő osztályazonosító, mivel a negyedik karakter nem kisbetű.");
            }
            iskolaSzolgaltatas.hozzadOsztaly(osztalyAzonosito);
        }


        /// <summary>
        /// Oszály azonosítójának módosítása
        /// </summary>
        /// <param name="regiOsztlyAzonosito">A módosítandó osztály eddigi azonosítója</param>
        /// <param name="osztalyUjAzonositoja">Az osztály új azonosítója</param>
        public void modositOsztalyAzonositot(string regiOsztlyAzonosito, string osztalyUjAzonositoja)
        {
            if (iskolaSzolgaltatas.vanEAdottAzonositojuOsztaly(osztalyUjAzonositoja))
                throw new ControllerException(osztalyUjAzonositoja + " osztály már létezik. Erre a névre nem lehet módosítani!");
            try
            {
                AzonositoEllenorzo ae = new AzonositoEllenorzo(osztalyUjAzonositoja);
                ae.ellenorzes();
            }
            catch (ElsoKetBetuNemSzamException)
            {
                throw new ControllerException(osztalyUjAzonositoja + " első két betűje szám kell legyen.");
            }
            catch (HarmadikKarakterNemPontException)
            {
                throw new ControllerException(osztalyUjAzonositoja + " nem megfelelő osztályazonosító, mivel az harmadik karakter nem pont.");
            }
            catch (NegyedikKarakerNemKisBetuException)
            {
                throw new ControllerException(osztalyUjAzonositoja + " nem megfelelő osztályazonosító, mivel a negyedik karakter nem kisbetű.");
            }
            iskolaSzolgaltatas.modositOsztalyNevet(regiOsztlyAzonosito, osztalyUjAzonositoja);
        }

        internal string getOsztalyAtlag(string osztalyAzonosito)
        {
            double osztalyAtlag = iskolaSzolgaltatas.getOsztalyAtlag(osztalyAzonosito);
            return osztalyAtlag.ToString();
        }

        /// <summary>
        /// Adott azonosítójú osztály törlése
        /// </summary>
        /// <param name="torlendoOsztalyAzonosito">A törlendő osztály azonosítója</param>
        public void torolOsztalyt(string torlendoOsztalyAzonosito)
        {
            if (!iskolaSzolgaltatas.vanEAdottAzonositojuOsztaly(torlendoOsztalyAzonosito))
                throw new ControllerException(torlendoOsztalyAzonosito + " osztály nem létezik. Nem lehet törölni!");
            try
            {
                iskolaSzolgaltatas.torlesOsztaly(torlendoOsztalyAzonosito);
            }
            catch (OsztalySzolgaltatasExeption e)
            {
                throw new ControllerException(e.Message);
            }
        }        

        /// <summary>
        /// Diák áthelyezése egyik osztályból a másikba
        /// </summary>
        /// <param name="azonositoOsztalybol">Ebből az osztályból</param>
        /// <param name="azonositoOsztalyba">Ebbe az osztályba</param>
        /// <param name="athelyezendoDiakNeve">Az áthelyezendő diák neve</param>
        public void athelyezDiakotOsztalyba(string azonositoOsztalybol, string azonositoOsztalyba, string athelyezendoDiakNeve)
        {
            if (!iskolaSzolgaltatas.vanEAdottAzonositojuOsztaly(azonositoOsztalybol))
                throw new ControllerException(azonositoOsztalybol + " osztály nem létezik, nem lehet áthelyezni.");
            if (!iskolaSzolgaltatas.vanEAdottAzonositojuOsztaly(azonositoOsztalyba))
                throw new ControllerException(azonositoOsztalyba + " osztály nem létezik, nem lehet áthelyezni.");
            iskolaSzolgaltatas.athelyezOsztalyba(azonositoOsztalybol, azonositoOsztalyba, athelyezendoDiakNeve);
        }
    }
}
