using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class KutyaFajta
    {
        public int id { get; set; }
        public string magyarNev { get; set; }
        public string eredetiNev { get; set; }

        public override string ToString()
        {
            return id + " " + magyarNev + " " + eredetiNev;
        }
    }
}
