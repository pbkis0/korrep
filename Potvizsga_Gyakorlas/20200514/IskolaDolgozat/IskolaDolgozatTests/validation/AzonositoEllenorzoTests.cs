using Microsoft.VisualStudio.TestTools.UnitTesting;
using IskolaProjekt.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IskolaProjekt.validation.Tests
{
    [TestClass()]
    public class AzonositoEllenorzoTests
    {
        [TestMethod()]
        public void ellenorzesTestElsoKetoKarakterSzam() // függvénynév_elsőkettőkarakternemszám_kivételtkelldobjon
        {
            try
            {
                // kivételtkelldobjon -> catch -> return
                AzonositoEllenorzo azonositoEllenorzo = new AzonositoEllenorzo("AB.B");
                azonositoEllenorzo.ellenorzes();
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Nem dob kivételt az első két karakterre, ami nem szám!");
        }

        [TestMethod()]
        public void ellenorzesTestHarmadikKarakterPont() // függvénynév_harmadikkarakternempont_kivételtkelldobjon
        {
            try
            {
                // kivételtkelldobjon -> catch -> return
                AzonositoEllenorzo azonositoEllenorzo = new AzonositoEllenorzo("12_B");
                azonositoEllenorzo.ellenorzes();
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Nem dob kivételt a harmadik karakteren lévő NEM pont karakterre!");
        }

        [TestMethod()]
        public void ellenorzesTestNegyedikKarakterKisbetu()
        {
            try
            {
                // kivételtkelldobjon -> catch -> return
                AzonositoEllenorzo azonositoEllenorzo = new AzonositoEllenorzo("12.b");
                azonositoEllenorzo.ellenorzes();
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Nem dob kivételt a negyedik karakteren lévő NEM nagybetűs karakterre!");
        }
    }
}
