using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemLibrary;

namespace TestBilletSystem
{
    [TestClass]
    public class K�ret�jstestTest
    {

        [TestMethod]
        public void TestBilPris()
        {
            var result = Bil.Pris();
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void TestK�ret�jBil()
        {
            var result = Bil.K�ret�j();
            Assert.AreEqual("Bil", result);
        }

        public void TestMCPris()
        {
            var result = Motorcykel.Pris();
            Assert.AreEqual(125, result);
        }

        public void TestK�ret�jMotorcykel()
        {
            var result = Motorcykel.K�ret�j();
            Assert.AreEqual("Motorcykel", result);
        }

    }
}
