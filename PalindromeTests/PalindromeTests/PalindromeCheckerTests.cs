using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace PalindromeTests
{
    [TestClass]
    public class PalindromeCheckerTests
    {
        [TestMethod]
        public void TestIsPalindrome()
        {
            Assert.IsFalse(PalindromeChecker.IsPalindrome("Hello"), "Hello is not a palindrome");

            Assert.IsTrue(PalindromeChecker.IsPalindrome("race car"), "race car is a palindrome");
            Assert.IsTrue(PalindromeChecker.IsPalindrome("never odd or even"), "never is odd or even is a palindrome");
            Assert.IsTrue(PalindromeChecker.IsPalindrome("A man, a plan, a canal. Panama"), "A man, a plan, a canal. Panama is a palindrome");
            Assert.IsTrue(PalindromeChecker.IsPalindrome("_eye"), "_eye is a palindrome");
        }

        [TestMethod]
        public void TestStringFilter()
        {
            Equals(PalindromeChecker.FilterString("23.;]-abc"), "23abc");
        }
    }
}