using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    public class NobelModel
    {
        public int evszam { get; set; }
        public string típus { get; set; }
        public string keresztnev { get; set; }
        public string vezeteknev { get; set; }

        public override string ToString()
        {
            return evszam + " " + típus + " " + keresztnev + " " + vezeteknev;
        }
    }
}
