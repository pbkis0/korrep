using Gyakorlati.modell;
using Gyakorlati.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlati
{
    public class CegService
    {
        private Ceg ceg;

        public CegService()
        {
            ceg = new Ceg("Ikron");

            Munkavezeto m1 = new Munkavezeto(1, "Kis Balázs");
            Munkavezeto m2 = new Munkavezeto(2, "Juhász Bence");

            Telephely szilank = new Telephely("Szilánk");
            Telephely ujSzeged = new Telephely("Újszeged");

            ceg.hozzaadTelephely(szilank);
            ceg.hozzaadTelephely(ujSzeged);

            ceg.hozzaadMunkavezeto(m1, "Szilánk");
            ceg.hozzaadMunkavezeto(m2, "Újszeged");
        }

        public void athelyezDolgozo(string munkavezetoNeve, string innenTelephely, string odaTelephely)
        {
            // 3. lépés:
            // 1) keressük ki az objektum referenciát
            // 2) Törljük ahol most dolgozik
            // 3) Adjuk hozzá az új helyhez

            Munkavezeto m = ceg.keresMunkavezetotNevAlapjat(munkavezetoNeve, innenTelephely);
            ceg.torolMunkavezeto(munkavezetoNeve, innenTelephely);
            ceg.hozzaadMunkavezeto(m, odaTelephely);
        }

        public void hozzaadTelephely(Telephely t)
        {
            ceg.hozzaadTelephely(t);
        }

        public void hozzaadMunkavezeto(Munkavezeto munkavezeto, string telephelyNeve)
        {
            ceg.hozzaadMunkavezeto(munkavezeto, telephelyNeve);
        }
    }
}
