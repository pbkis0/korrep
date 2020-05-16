using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.repository
{
    class TestAdatok
    {
        public Iskola getTestAdatok()
        {
            Iskola iskola = new Iskola();

            Diak d1 = new Diak(1,"Bukfenc Bence", 17, 3.45);
            Diak d2 = new Diak(2, "Stréber Szandra", 16, 4.89);
            Diak d3 = new Diak(3, "Számol Szonja", 17, 4.11);
            Diak d4 = new Diak(4, "Tornász Tibor", 18, 4.11);
            Diak d5 = new Diak(5, "Programozó Péter", 16, 3.78);

            Osztaly o2 = new Osztaly("11.A");
            Osztaly o1 = new Osztaly("10.A");

            o1.hozzadDiak(d5);
            o1.hozzadDiak(d2);
            o2.hozzadDiak(d1);
            o2.hozzadDiak(d4);
            o1.hozzadDiak(d3);

            iskola.hozzad(o1);
            iskola.hozzad(o2);

            return iskola;
        }
    }
}
