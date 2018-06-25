using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidPhoneNumberTests
{
    [TestClass]
    public class UnitTest1
    {
        string[] validNums =
            {
                "555-555-5555", //10 nums \d\d\d\-\d\d\d-\d\d\d\d
                "1-555-555-5555", //can be 11 with a single digit at the start by itself
                "1 (555) 555-5555", //the second set of numbers can have brackets
                "5555555555", //no spaces/hyphens is fine
                "(555)555-5555",
                "1(555)555-5555",
                "1 555 555 5555",
                "1 456 789 4444"
            };

        string[] invalidNums =
            {
                "1 555)555-5555",
                "5555555",
                "123**&!!asdf#",
                "555-5555",
                "(6054756961)",
                "2 (757) 622-7382",
                "-1 (757) 622-7382",
                "10 (757) 622-7382",
                "27576227382",
                "2(757)622-7382",
                "555)-555-5555",
                "(555)5(55?)-5555"
            };


        [TestMethod]
        public void TestValidNumbers()
        {
            foreach(string num in validNums)
            {
                var r = PhoneService.PhoneNumber.IsValid(num);
               // Assert.IsInstanceOfType(r, typeof(bool), "Does not return true or false");
                Assert.IsTrue(r, "{0} was validated to {1}, it should be {2}", num, r, true);
            }
        }

        [TestMethod]
        public void TestInvalidNumbers()
        {
            foreach (string num in invalidNums)
            {
                var r = PhoneService.PhoneNumber.IsValid(num);
                //Assert.IsInstanceOfType(r, typeof(bool), "Does not return true or false");
                Assert.IsFalse(r, "{0} was validated to {1}, it should be {2}", num, r, false);
            }
        }
    }
}
