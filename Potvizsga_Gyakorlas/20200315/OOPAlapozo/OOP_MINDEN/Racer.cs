using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MINDEN
{
    public class Racer : Object
    {
        // Adattag/mező/attribútum:
        // jellemzi az adott osztály tulajdonságait,
        // és ami objektum llétrejön belőle ŐT IS!

        // CSUPASZOK FEL KELL ŐKET SOROLNI ÉS SEMMI MÁST NEM TUDSZ VELE CSINÁLNI
        private int id;
        private string name;
        private int age;
        private int salary;

        // ALGORITMUS: LÉPÉSEK VÉGES SOROZATA
        // CSAK METÓDUSBAN LEHET "ALGORITMIZÁLNI"
        // MINDIG A KONSTRUKTOR FUT LE ELŐSZÖR
        /// <summary>
        /// Konstruktor
        /// Feladatai:
        /// 1. Objektumot inicializáljon
        /// 2. Adattagot inicializáljon
        /// </summary>
        public Racer(int id, string name, int age, int salary)
        {
            if (id > 0)
            {
                this.id = id;
            }

            if (name != "")
            {
                this.name = name;
            }

            if (age > 0)
            {
                this.age = age;
            }

            if (salary > 0)
            {
                this.salary = salary;
            }
        }

        public void setId(int id)
        {
            if (id > 0)
            {
                this.id = id;
            }
        }

        public void setName(string name)
        {
            if (name != "")
            {
                this.name = name;
            }
        }

        public void setAge(int age)
        {
            if (age>0)
            {
                this.age = age;
            }
        }

        public void setSalary(int salary)
        {
            if (salary > 0)
            {
                this.salary = salary;
            }
        }

        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }

        public int getSalary()
        {
            return this.salary;
        }


        public override string ToString()
        {
            return
                "A versenyző azonosítója: " + id
                + ", neve: " + name +
                ", életkora: " + age +
                ", fizetése: " + salary;
        }
    }
}
