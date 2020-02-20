using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekocsi
{
    public class Igeny
    {
        public string azonosito { get; set; }
        public string indulas { get; set; }
        public string cel { get; set; }
        public int szemelyek { get; set; }

        public override string ToString()
        {
            return azonosito + " " + indulas + " " + cel + " " + szemelyek;
        }

    }
}
