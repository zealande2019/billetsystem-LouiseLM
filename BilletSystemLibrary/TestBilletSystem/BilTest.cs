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
        public void TestKøretøj()
        {
            var result = Bil.Køretøj();
            Assert.AreEqual("Bil", result);
        }
    }
}
