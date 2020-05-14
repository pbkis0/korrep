using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.myexeption
{
    class OsztalySzolgaltatasExeption : Exception
    {
        public OsztalySzolgaltatasExeption(string message)
            : base(message)
        { }
    }
}
