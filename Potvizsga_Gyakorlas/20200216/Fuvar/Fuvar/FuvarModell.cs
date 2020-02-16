using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    public class FuvarModell
    {
        public int taxi_id { get; set; }
        public string indulas { get; set; }
        public int idotartam { get; set; }
        public double megtettTavolsag { get; set; }
        public double viteldij { get; set; }
        public double borravalo { get; set; }
        public string fizetesModja { get; set; }

        public override string ToString()
        {
            return taxi_id + " " + indulas + " " + idotartam + " " + megtettTavolsag + " " + viteldij + " " + borravalo + " " + fizetesModja;
        }
    }
}
