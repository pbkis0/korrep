using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.myexeption
{
    class IskolaException : Exception
    {
        public IskolaException(string message)
            : base(message)
        { }
    }
}
