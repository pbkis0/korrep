using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.repository
{
    interface IOsztalyDiakokKezelese
    {
        void hozzadDiak(Diak d);
        void torolDiak(string nev,int eletkor);
        void frissitDiak(string nev, Diak ujDiak);

        int getDiakokSzama();
        Diak keresDiakotNevAlapjan(string diakNev);
        bool vanEDiak(string diakNeve, int diakEletkora);
        int getDaikId(string diakNeve);
    }
}
