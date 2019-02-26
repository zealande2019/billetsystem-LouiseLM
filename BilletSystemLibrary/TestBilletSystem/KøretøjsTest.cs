using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemLibrary;
using System;

namespace TestBilletSystem
{
    [TestClass]
    public class K�ret�jstestTest
    {

        [TestMethod]
        public void TestBilPris()
        {
            Bil b1 = new Bil();
            var result = b1.Pris();
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void TestK�ret�jBil()
        {
            Bil b1 = new Bil();
            var result = b1.K�ret�jType();
            Assert.AreEqual("Bil", result);
        }

        [TestMethod]
        public void TestMCPris()
        {
            Motorcykel m1 = new Motorcykel();
            var result = m1.Pris();
            Assert.AreEqual(125, result);
        }

        [TestMethod]
        public void TestK�ret�jMotorcykel()
        {
            Motorcykel m1 = new Motorcykel();
            var result = m1.K�ret�jType();
            Assert.AreEqual("Motorcykel", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNummerplade()
        {
            Motorcykel m1 = new Motorcykel();
            m1.Nummerplade = "12345678";
            Assert.Fail();
        }

    }
}
