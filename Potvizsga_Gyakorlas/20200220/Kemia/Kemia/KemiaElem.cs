using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemia
{
    public class KemiaElem
    {
        public string ev { get; set; }
        public string elem { get; set; }
        public string vegyjel { get; set; }
        public int rendszam { get; set; }
        public string felfedezo { get; set; }

        public override string ToString()
        {
            return ev + " " + elem + " " + vegyjel + " " + rendszam + " " + felfedezo;
        }
    }
}
