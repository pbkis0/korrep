using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.myexeption
{
    class NevNemMegfeleloNevUresException : Exception
    {
        public NevNemMegfeleloNevUresException(string message)
            :base(message)
        { }
    }
}
