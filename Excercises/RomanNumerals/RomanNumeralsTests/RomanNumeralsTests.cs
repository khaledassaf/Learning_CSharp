using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsHelper;
using System.Collections.Generic;

namespace RomanNumeralsTests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void Test_Convert()
        {
            Dictionary<int, string> inputOutput = new Dictionary<int, string>
            {
                {2000, "MM"},
                {2500, "MMD" },
                {500, "D" },
                {21, "XXI" },
                {24, "XXIV" },
                {4, "IV" },
                {44, "XLIV" },
                {88, "LXXXVIII" },
                {98, "XCVIII" }
            };

            foreach (var KV in inputOutput)
            {
                var v = RomanNum.Convert(KV.Key);
                Assert.IsTrue(v == KV.Value, "{0} should convert to {1}, got {2} instead.", KV.Key, KV.Value, v);
            }
        }
    }
}
