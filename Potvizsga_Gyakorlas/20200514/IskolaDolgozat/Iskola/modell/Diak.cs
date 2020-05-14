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
            this.id = id;
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
        /// <summary>
        /// A diák objektum frissítése a paraméterben kapott objektum adataira
        /// </summary>
        /// <param name="diak">Ennek az objektumnak az adataira kell frissíteni az osztály mezőit</param>
        public void frissit(Diak diak)
        {
        }
    }
}
