using IskolaProjekt.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.validation
{
    public class NevEllenorzo
    {
        private string nev;
        public NevEllenorzo(string nev)
        {
            this.nev = nev;
        }
        public void ellenorzes()
        {
            if (ellenorizUresNev())
                throw new NevNemMegfeleloNevUresException("A név nem lehet üres!");
            if (ellenorizElsoBetuNemNagybetu())
                throw new NevNemMegfeleloElsoBetuNemNagyException("A név nagy kezdőbetűvel kell kezdőjön!");
        }

        private bool ellenorizElsoBetuNemNagybetu()
        {
            if (nev.Length == 0)
                return true;
            if (char.IsLower(nev[0]))
                return true;
            else
                return false;
        }

        private bool ellenorizUresNev()
        {
            if (nev == string.Empty)
                return true;
            else
                return false;
        }
    }
}
