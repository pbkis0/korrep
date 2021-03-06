﻿using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    /// <summary>
    /// Nevet validáló osztály
    /// </summary>
    public class NameValidator
    {
        // név adattag
        private string name;


        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Paraméterül bejövő név</param>
        public NameValidator(string name)
        {
            this.name = name; // a paraméter nevet értékül adja aaz adattagnak, így az az osztályon belül bárhol elérhető
        }

        /// <summary>
        /// NAGY VALIDÁTOR
        /// </summary>
        public void validation()
        {
            if (isEmtyName())
                throw new NameNotValidNameIsEmptyException("A név nem lehet üres!");
            if (isFistLetterNotUppercase())
                throw new NameNotValidFirstLetterProblemException("A név nagy kezdőbetűvel kell kezdőjön!");
        }


        private bool isFistLetterNotUppercase()
        {
            return false;
        }

        private bool isEmtyName()
        {
            return false;
        }
    }
}
