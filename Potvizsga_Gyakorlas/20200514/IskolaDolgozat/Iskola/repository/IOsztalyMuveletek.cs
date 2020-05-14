using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaProjekt.repository
{
    interface IOsztalyMuveletek
    {
        /// <summary>
        /// Osztály törlésének előkészítése
        /// A listából minden diákot törlünk
        /// </summary>
        void torolMindenDikotAzOsztalybol();
        
        /// <summary>
        /// Osztályban lévő tanulok átlagaiból meghatározza az osztályátlagot
        /// </summary>
        /// <returns>osztályátlag</returns>
        double getOsztalyAtlag();
    }
}
