﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forma1.Model;

namespace Forma1.Repository
{
    class TestData
    {
        public F1 getTestData()
        {
            F1 f1 = new F1();

            Racer r1 = new Racer(1, "Hamilton", 34, 245);
            Racer r2 = new Racer(2, "Raikonen", 39, 45);
            Racer r3 = new Racer(3, "Bottas", 27, 50);
            Racer r4 = new Racer(4, "Vettel", 31, 182);
            Racer r5 = new Racer(5, "Verstappen", 21, 70);

            Team t1 = new Team("Ranult");
            Team t2 = new Team("Ferrari");

            t1.add(r1);
            t1.add(r3);
            t2.add(r2);
            t2.add(r4);
            t2.add(r5);

            f1.add(t1);
            f1.add(t2);
            return f1;
        }
    }
}
