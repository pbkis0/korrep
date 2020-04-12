using Forma1.myexeption;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    class Racer
    {
        private int id;
        private string name;
        private int age;
        private int salary;


        public Racer(int id, string name, int age, int salary)
        {
            this.id = id;

            //1, NameValidator bekötése konstruktorba és set metódusban 
            try
            {
                NameValidator nv = new NameValidator(name);
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException ex)
            {
                Debug.WriteLine(ex.Message); // outputra loggolás
                throw new RacerException(ex.Message);
            }
            catch (NameNotValidFirstLetterProblemException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new RacerException(ex.Message);
            }

            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void setName(string name)
        {
            //1, NameValidator bekötése konstruktorba és set metódusban 
            try
            {
                NameValidator nv = new NameValidator(name);
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new RacerException(ex.Message);
            }
            catch (NameNotValidFirstLetterProblemException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new RacerException(ex.Message);
            }

            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public int getSalary()
        {
            return salary;
        }

        public int getId()
        {
            return id;
        }

        //1,  -  - update metódus
        public void update(Racer racer)
        {
            this.id = racer.id;
            this.name = racer.name;
            this.age = racer.age;
            this.salary = racer.salary;

            //this.id = racer.getId();
            //this.name = racer.getName();
            //this.age = racer.getAge();
            //this.salary = racer.getSalary();


        }

        //1,  - ToString metódus megírása
        public override string ToString()
        {
            return id + " " + name + " " + age + " " + salary;
        }
    }
}
