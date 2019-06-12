using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC.Model
{
    public class Beer
    {
        #region Adattagok

        private int azonosito;
        private string marka;
        private double alkoholTartalom;
        private int ar;
        private string gyarto;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="azonosito"></param>
        /// <param name="marka"></param>
        /// <param name="alkoholTartalom"></param>
        /// <param name="ar"></param>
        /// <param name="gyarto"></param>
        public Beer(int azonosito, string marka, double alkoholTartalom, int ar, string gyarto)
        {
            this.azonosito = azonosito;
            this.marka = marka;
            this.alkoholTartalom = alkoholTartalom;
            this.ar = ar;
            this.gyarto = gyarto;
        }

        /// <summary>
        /// Üres konstruktor
        /// </summary>
        public Beer()
        {

        }

        #endregion

        #region Getter és setter

        public int GetAzonosito()
        {
            return azonosito;
        }

        public void setAzonosito(int azonosito)
        {
            this.azonosito = azonosito;
        }

        public string GetMarka()
        {
            return marka;
        }

        public void setMarka(string marka)
        {
            this.marka = marka;
        }

        /// <summary>
        /// alkoholtartalom
        /// </summary>
        /// <returns></returns>
        public double getAlkoholTartalom()
        {
            return alkoholTartalom;
        }

        public void setAlkolTartalom(double alkoholTartalom)
        {
            this.alkoholTartalom = alkoholTartalom;
        }

        //Ár
        public int getAr()
        {
            return ar;
        }

        public void setAr(int ar)
        {
            this.ar = ar;
        }

        //Gyártó
        public string getGyarto()
        {
            return gyarto;
        }

        public void setGyarto(string gyarto)
        {
            this.gyarto = gyarto;
        }

        #endregion

        #region toString

        public override string ToString()
        {
            return azonosito + " " + marka + " " + alkoholTartalom + " " + ar + " " + gyarto;
            //return $"{azonosito} {marka} {alkoholTartalom} {ar} {gyarto}";
        }

        #endregion
    }
}
