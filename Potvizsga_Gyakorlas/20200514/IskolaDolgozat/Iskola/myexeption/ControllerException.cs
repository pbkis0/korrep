﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.myexeption
{
    class ControllerException :Exception
    {
        public ControllerException(string message)
            : base(message)
        { }
    }
}
