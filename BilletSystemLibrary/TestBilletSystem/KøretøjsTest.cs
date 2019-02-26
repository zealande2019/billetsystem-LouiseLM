using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemLibrary;

namespace TestBilletSystem
{
    [TestClass]
    public class KøretøjstestTest
    {

        [TestMethod]
        public void TestBilPris()
        {
            var result = Bil.Pris();
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void TestKøretøjBil()
        {
            var result = Bil.Køretøj();
            Assert.AreEqual("Bil", result);
        }

        public void TestMCPris()
        {
            var result = Motorcykel.Pris();
            Assert.AreEqual(125, result);
        }

        public void TestKøretøjMotorcykel()
        {
            var result = Motorcykel.Køretøj();
            Assert.AreEqual("Motorcykel", result);
        }

    }
}
