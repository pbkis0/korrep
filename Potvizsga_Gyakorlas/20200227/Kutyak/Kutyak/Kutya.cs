using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Kutya
    {
        public int id { get; set; }
        public int fajtaID { get; set; }
        public int nevID { get; set; }
        public int eletkor { get; set; }
        public DateTime utolsoOrvosiEllenorzes { get; set; }

        public override string ToString()
        {
            return id + " " + fajtaID + " " + nevID + " " + eletkor + " " + utolsoOrvosiEllenorzes;
        }


    }
}
