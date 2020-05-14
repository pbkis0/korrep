using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.myexeption
{
    class NevNemMegfeleloElsoBetuNemNagyException : Exception
    {
        public NevNemMegfeleloElsoBetuNemNagyException(string message)
           : base(message)
        { }
    }
}
