using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Palindrome
{
    public class PalindromeChecker
    {
        public static string FilterString(string _unfiltered)
        {
            string unfiltered = _unfiltered;
            string filtered = "";

            MatchCollection matches = new Regex("[a-zA-Z0-9]").Matches(unfiltered);

            foreach (Match match in matches)
            {
                filtered += match.Value;
            }

            filtered = filtered.ToLower();
            return filtered;
        }

        public static bool IsPalindrome(string s)
        {
            string candidate = FilterString(s);

            char[] c = candidate.ToCharArray();
            Array.Reverse(c);
            string reversedCandidate = new string(c);

            if (candidate == reversedCandidate)
                return true; else return false;

        }
    }
}

