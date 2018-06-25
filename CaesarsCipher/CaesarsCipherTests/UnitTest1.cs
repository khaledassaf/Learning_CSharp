using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaesarsCipherHelper;
namespace CaesarsCipherTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string o = "SERR PBQR PNZC";
            string r = "FREE CODE CAMP";
            var a = CaesarsCipher.Decode(o, 13);
            Assert.IsTrue(a == r, "{0} should equal {1}, got {2} instead", o, r, a);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string o = "SERR YBIR?";
            string r = "FREE LOVE?";
            var a = CaesarsCipher.Decode(o, 13);
            Assert.IsTrue(a == r, "{0} should equal {1}, got {2} instead", o, r, a);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string o = "S";
            string r = "F";
            var a = CaesarsCipher.Decode(o, 13);
            Assert.IsTrue(a == r, "{0} should equal {1}, got {2} instead", o, r, a);
        }
    }
}
