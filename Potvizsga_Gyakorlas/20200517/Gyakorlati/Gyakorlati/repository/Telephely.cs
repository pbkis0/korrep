using Gyakorlati.modell;
using System;
using System.Collections.Generic;

namespace Gyakorlati.repository
{
    public class Telephely
    {
        private string name;
        private List<Munkavezeto> munkavezetok;
        //private Munkavezeto[] munkavezetokTomb;

        public List<Munkavezeto> GetMunkavezetok()
        {
            return munkavezetok;
        }

        public Telephely(string name)
        {
            this.name = name;
            munkavezetok = new List<Munkavezeto>();
            //munkavezetokTomb = new Munkavezeto[2];
        }

        public string getName()
        {
            return name;
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

        public Munkavezeto keresMunkavezetotNevAlapajan(string munkavezetoNeve)
        {
            foreach (Munkavezeto munkavezeto in munkavezetok)
            {
                if (munkavezeto.getName() == munkavezetoNeve)
                {
                    return munkavezeto;
                }
            }

            throw new System.Exception("Nincs ilyen nevű dolgozó!");
        }

        public void torolMunkavezeto(string munkavezetoNeve)
        {
            foreach (Munkavezeto munkavezeto in munkavezetok)
            {
                if (munkavezeto.getName() == munkavezetoNeve)
                {
                    munkavezetok.Remove(munkavezeto);
                    return;
                }
            }

            throw new Exception("Nincs ilyen nevű dolgozó!");
        }
    }
}
