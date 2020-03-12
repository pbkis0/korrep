using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHCP
{
    public class DHCP
    {
        public string muvelet { get; set; }
        public string mac { get; set; }
        public string ip { get; set; }

        public override string ToString()
        {
            return muvelet + " " + mac + " " + ip;
        }
    }
}
