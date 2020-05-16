using IskolaProjekt.myexeption;
using IskolaProjekt.validation;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.repository
{
    class Diak
    {
        private int id;
        private string nev;
        private int eletkor;
        private double atlag;

        /// <summary>Konstruktor</summary>
        public Diak(int id, string nev, int eletkor, double atlag)
        {
            //A modell rétegben található Diak osztály konstruktorába kösse be a NevEllenorzo osztályt. Egy diák,
            //csak akkor jöjjön létre, ha a neve megfelel, amit a NevEllenorzo osztállyal tud ellenőrizni!Kapja el a
            //NevEllenorzo osztály összes kivételét és a hibákat loggolja az Otuputra(a programozási nyelnek van
            //erre beépített osztálya és metódusa).
            this.id = id;

            try
            {
                NevEllenorzo nv = new NevEllenorzo(nev);
                nv.ellenorzes();
            }
            catch (NevNemMegfeleloNevUresException e)
            {
                Debug.WriteLine(e.Message);
                throw e;
            }
            catch (NevNemMegfeleloElsoBetuNemNagyException e)
            {
                Debug.WriteLine(e.Message);
                throw e;
            }

            this.nev = nev;
            this.eletkor = eletkor;
            this.atlag = atlag;
        }
        /// <summary>Setterek</summary>
        public void setNev(string nev)
        {
            this.nev = nev;
        }

        public void setEketkor(int eletkor)
        {
            this.eletkor = eletkor;
        }

        public void setAtlag(double atlag)
        {
            this.atlag = atlag;
        }
        /// <summary>Getterek</summary>
        public string getNev()
        {
            return nev;
        }

        public int getEletkor()
        {
            return eletkor;
        }

        public double getAtlag()
        {
            return atlag;
        }

        public int getId()
        {
            return id;
        }

        //1. feladat
        //A munkát a modell rétegben található osztállyal kezdjük.Az első feladat az osztály mezőit frissítő
        //metódus megírása (a metódus fejléce már megtalálható a forráskódban). A második feladat a ToString
        //osztály felülírása(a teljes metódust el kell készíteni), hogy az minden mező megjelenítését biztosítsa.
        //A metódust a hibaüzenetek megjelenítésére használjuk majd.
        /// <summary>
        /// A diák objektum frissítése a paraméterben kapott objektum adataira
        /// </summary>
        /// <param name="diak">Ennek az objektumnak az adataira kell frissíteni az osztály mezőit</param>
        public void frissit(Diak diak)
        {
            // egy füst alatt settelés
            this.id = diak.id;
            this.nev = diak.nev;
            this.eletkor = diak.eletkor;
            this.atlag = diak.atlag;
        }
        public override string ToString()
        {
            return id+ " " + nev +" " + eletkor +" " + atlag; // 1 Balázs 38 5.0
        }
    }
}
