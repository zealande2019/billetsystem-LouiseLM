using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemLibrary;

namespace TestBilletSystem
{
    [TestClass]
    public class BilTest
    {

        [TestMethod]
        public void TestBilPris()
        {
            var result = Bil.Pris();
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void TestK�ret�j()
        {
            var result = Bil.K�ret�j();
            Assert.AreEqual("Bil", result);
        }
    }
}
