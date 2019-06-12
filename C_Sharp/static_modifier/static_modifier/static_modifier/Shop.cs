using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace static_modifier
{
    public class Shop
    {
        #region Adattag/mező/attribútum/példányváltozó

        private string name;
        private int vasarlokSzama;

        #endregion

        //Statikus adattag/mező/attribútum
        private static int peldanyokSzama;

        public Shop(string name, int vasarlokSzama)
        {
            this.name = name;
            this.vasarlokSzama = vasarlokSzama;
            peldanyokSzama++;
        }

        public static void novelPeldanyokSzamat()
        {
            peldanyokSzama++;
        }

        public static int GetPeldanyokSzama()
        {
            return peldanyokSzama;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
