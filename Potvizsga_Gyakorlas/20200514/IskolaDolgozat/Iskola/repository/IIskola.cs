using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.repository
{
    interface IIskola
    {
        void hozzad(Osztaly o);
        void modosit(string osztalyNev, string ujOsztalyNev);
        void torol(string osztalyNev);

    }
}
