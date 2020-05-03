using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeningWeekend
{
    public class NyitoHetvege
    {
        public string eredetiCim { get; set; }
        public string magyarCim { get; set; }
        public string date { get; set; }
        public string forgalmazo { get; set; }
        public double bevel { get; set; }
        public int latogato { get; set; }

        public override string ToString()
        {
            return $"{eredetiCim} {magyarCim} {date} {forgalmazo} {bevel} {latogato}";
        }
    }
}
