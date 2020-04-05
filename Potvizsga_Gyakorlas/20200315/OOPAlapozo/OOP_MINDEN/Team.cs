using System.Collections.Generic;

namespace OOP_MINDEN
{
    public partial class Team // Repository
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

        public override string ToString()
        {
            return name;
        }
    }
}
