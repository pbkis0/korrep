using System.Collections.Generic;

namespace Gyakorlati.repository
{
    public class Ceg
    {
        private string name;
        private List<Telephely> telephelyek;

        public Ceg(string name)
        {
            this.name = name;
            telephelyek = new List<Telephely>();
        }

        public void hozzaadTelephely(Telephely telephely)
        {
            telephelyek.Add(telephely);
        }
    }
}
