using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.repository
{
    interface IOsztaly
    {
        string getAzonosito();
        List<Diak> getDiakok();
        void modositOsztalyAzonositot(string ujAzonosito);       
    }
}
