using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.myexeption
{
    class DiakException : Exception
    {
        public DiakException(string message) 
            :base(message)
        { }
    }
}
