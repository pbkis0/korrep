using System;
using System.CodeDom;

namespace Gyakorlati.modell
{
    public class Munkavezeto : Object
    {
        private int id;
        private string name;

        public Munkavezeto(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="munkavezeto"></param>
        public Munkavezeto(Munkavezeto munkavezeto)
        {
            this.id = munkavezeto.id;
            this.name = munkavezeto.name;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        // ToString

        public override string ToString()
        {
            return $"A munkavezető azonosítója: {id}, neve: {name}.";
        }

        // Frissit

        public void frissit(Munkavezeto munkavezeto)
        {
            this.id = munkavezeto.id;
            this.name = munkavezeto.name;
        }

        public void frissit(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
