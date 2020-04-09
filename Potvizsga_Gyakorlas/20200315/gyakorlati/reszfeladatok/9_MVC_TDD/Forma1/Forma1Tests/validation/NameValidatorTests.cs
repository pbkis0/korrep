using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1Test.validation.Tests
{
    [TestClass()]
    public class NameValidatorTests
    {
        [TestMethod()]
        public void validationTestNameEmpty()
        {
            try
            {
                NameValidator nv = new NameValidator("");
                nv.validation();
            }
            catch
            {
                return;
            }
            Assert.Fail("Üres névre nem dob kivételt!");
        }

        [TestMethod()]
        public void validationTestNameNotBeginWithUpperCase()
        {
            try
            {
                NameValidator nv = new NameValidator("nemecsek");
                nv.validation();
            }
            catch
            {
                return;
            }

            Assert.Fail("Nem dob kivételt kisbetűvel kezdődő névre!");
        }

        [TestMethod()]
        public void validationTestNameIsNull()
        {
            try
            {
                NameValidator nv = new NameValidator(null);
                nv.validation();
            }
            catch(Forma1.myexeption.NameNotValidNameIsEmptyException)
            {
                return;
            }

            Assert.Fail("Nem dob kivételt kisbetűvel null névre!");
        }

        [TestMethod()]
        public void validationTestNameValid() // itt már jó inputtal kell bombázni a validátort
        {
            try
            {
                NameValidator nv = new NameValidator("Balázs");
                nv.validation();
            }
            catch
            {
                Assert.Fail("Kivétel képződött!");
            }
        }
    }
}
