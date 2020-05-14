using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.validation
{
    public class AzonositoEllenorzo
    {
        private string azonosito;

        public AzonositoEllenorzo(string azonosito)
        {
            this.azonosito = azonosito;
        }

        public void ellenorzes()
        {
            if (ellenorizElsoKetoKarakterSzam())
                throw new ElsoKetBetuNemSzamException("Az azonosító első két karaktere szám kell legyen!");
            if (ellenorizHarmadikKarakterPont())
                throw new HarmadikKarakterNemPontException("Az azonosító harmadik karaktere pont kell legyen");
            if (ellenorizNegyedikKarakterKisbetu())
                throw new NegyedikKarakerNemKisBetuException("A negyedik karakternek kisbetűnek kell lennie!");
        }

        private bool ellenorizNegyedikKarakterKisbetu()
        {
            return false;
        }

        private bool ellenorizHarmadikKarakterPont()
        {
            return false;
        }

        private bool ellenorizElsoKetoKarakterSzam()
        {
            return false;
        }
    }
}
