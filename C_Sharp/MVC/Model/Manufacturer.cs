namespace MVC.Model
{
    public class Manufacturer
    {
        private string name;

        public Manufacturer(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
