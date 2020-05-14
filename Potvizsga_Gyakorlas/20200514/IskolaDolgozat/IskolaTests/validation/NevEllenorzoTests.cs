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
    public class NevEllenorzoTests
    {
        [TestMethod()]
        public void ellenorzesTestUresNev()
        {
            try
            {
                NevEllenorzo nv = new NevEllenorzo("");
                nv.ellenorzes();
            }
            catch
            {
                return;
            }
            Assert.Fail("Üres névre nem dob kivételt!");                            
        }
        [TestMethod()]
        public void ellenorzesTestNevNemNagybetuvelKezdodik()
        {
            try
            {
                NevEllenorzo nv = new NevEllenorzo("nemecsek");
                nv.ellenorzes();
            }
            catch
            {
                return;
            }
            Assert.Fail("Kis betűbel kezdődő névbre nem dob kivételt!");            
        }
        [TestMethod()]
        public void ellenorzesTestNevHelyes()
        {
            NevEllenorzo nv = new NevEllenorzo("Nemecsek");
            try
            {
                nv.ellenorzes();
            }
            catch (Exception e)
            {
                Assert.Fail("Jó névre kivételt dob!");
            }
        }
    }
}