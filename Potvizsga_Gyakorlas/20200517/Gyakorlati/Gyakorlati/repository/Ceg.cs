using Gyakorlati.modell;
using System;
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

        public List<Telephely> GetTelephelyek()
        {
            return telephelyek;
        }

        public void hozzaadTelephely(Telephely telephely)
        {
            telephelyek.Add(telephely);
        }

        public void hozzaadMunkavezeto(Munkavezeto munkavezeto, string telephelyNeve)
        {
            foreach (Telephely telephely in telephelyek)
            {
                if (telephely.getName() == telephelyNeve)
                {
                    telephely.hozzaadMunkavezeto(munkavezeto);
                    return;
                }
            }

            throw new System.Exception("Nincs ilyen telephely");
        }

        public Munkavezeto keresMunkavezetotNevAlapjat(string munkavezetoNeve, string telephelyNeve)
        {
            foreach (Telephely telephely in telephelyek)
            {
                if (telephely.getName() == telephelyNeve)
                {
                    //foreach (Munkavezeto munkavezeto in telephely.GetMunkavezetok())
                    //{
                    //    if (munkavezeto.getName() == munkavezetoNeve)
                    //    {
                    //        return munkavezeto;
                    //    }
                    //}
                    return telephely.keresMunkavezetotNevAlapajan(munkavezetoNeve);
                }
            }

            throw new Exception("Nincs ilyen telephely!");
        }

        public void torolMunkavezeto(string munkavezetoNeve, string innenTelephely)
        {
            foreach (Telephely telephely in telephelyek)
            {
                if (telephely.getName() == innenTelephely)
                {
                    telephely.torolMunkavezeto(munkavezetoNeve);
                    return;
                    //foreach (Munkavezeto munkavezeto in telephely.GetMunkavezetok())
                    //{
                    //    if (munkavezeto.getName () == munkavezetoNeve)
                    //    {
                    //        telephely.GetMunkavezetok().Remove(munkavezeto);
                    //    }
                    //}
                }
            }

            throw new Exception("Nincs ilyen telephely!");
        }
    }
}
