using System.Collections.Generic;

namespace OOP_MINDEN
{
    public class Team // Repository
    {
        private string name;
        private List<Racer> racers;

        public Team(string name)
        {
            this.name = name;
            racers = new List<Racer>();
        }

        public string getName()
        {
            return name;
        }

        public void update(string name)
        {
            this.name = name;
        }

        public List<Racer> getRacers()
        {
            return racers;
        }

        public void updateRacer(Racer racer)
        {
            foreach (Racer r in racers)
            {
                if (r.getId() == racer.getId())
                {
                    r.updateRacer(racer);
                    //r.setId(racer.getId());
                    //r.setName(racer.getName());
                    //r.setAge(racer.getAge());
                    //r.setSalary(racer.getSalary());
                    return;
                }
            }

            throw new System.Exception("Nincs meg a versenyző!");
        }

        public void deleteRacer(int id)
        {
            foreach (Racer r in racers)
            {
                if (r.getId() == id)
                {
                    racers.Remove(r);
                    return;
                }
            }
            throw new System.Exception("Nincs meg a versenyző");
        }

        public void addRacer(Racer racer)
        {
            racers.Add(racer); // listaNév.Add() metódus
        }

        public Racer getRacerByName(string name)
        {
            foreach (Racer r in racers)
            {
                if (r.getName() == name)
                {
                    return r;
                }
            }

            throw new System.Exception("Nincs meg a versenyző!");
        }
    }
}
