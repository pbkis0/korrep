using Gyakorlati.modell;
using System.Collections.Generic;

namespace Gyakorlati.repository
{
    public class Telephely
    {
        private string name;
        private List<Munkavezeto> munkavezetok;
        //private Munkavezeto[] munkavezetokTomb;

        public Telephely(string name)
        {
            this.name = name;
            munkavezetok = new List<Munkavezeto>();
            //munkavezetokTomb = new Munkavezeto[2];
        }

        public void hozzaadMunkavezeto(Munkavezeto munkavezeto)
        {
            munkavezetok.Add(munkavezeto);
        }

        public void modositMunkavezeto(string oldName, string newName)
        {
            foreach (Munkavezeto munkavezeto in munkavezetok)
            {
                if (munkavezeto.getName() == oldName)
                {
                    munkavezeto.setName(newName);
                    //munkavezeto.frissit(munkavezeto.getId(), newName);
                    return;
                }
            }

            throw new System.Exception("Nincs ilyen nevű dolgozó");
        }
    }
}
