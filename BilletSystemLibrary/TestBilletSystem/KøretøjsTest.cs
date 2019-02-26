using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemLibrary;
using System;

namespace TestBilletSystem
{
    [TestClass]
    public class KøretøjstestTest
    {

        [TestMethod]
        public void TestBilPris()
        {
            Bil b1 = new Bil();
            var result = b1.Pris();
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void TestKøretøjBil()
        {
            Bil b1 = new Bil();
            var result = b1.KøretøjType();
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
        public void TestKøretøjMotorcykel()
        {
            Motorcykel m1 = new Motorcykel();
            var result = m1.KøretøjType();
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
