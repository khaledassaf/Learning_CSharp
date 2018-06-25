using System;
using System.Text.RegularExpressions;

namespace PhoneService
{
    public class PhoneNumber
    {
        public static bool IsValid(string num)
        {
            //    "555-555-5555", //10 nums \d{3}-d{3}-d{4}
            //    "1-555-555-5555", //can be 11 with a single digit at the start by itself
            //    "1 (555) 555-5555", //the second set of numbers can have brackets
            //    "5555555555", //no spaces/hyphens is fine
            //    "(555)555-5555",
            //    "1(555)555-5555",
            //    "1 555 555 5555",
            //    "1 456 789 4444"

            //check all characters in string are legal [0-9()- ] (including space)
            //check for 10 nums

            //if 11 nums, check that first num == 1 and evaluate the string of nums to 10.

            //first 3 nums may or may not be e in brackets
            string pattern = @"^1?[-\s]?(\(\d{3}\)|\d{3})[-\s]?\d{3}[-\s]?\d{4}$";
            return Regex.IsMatch(num, pattern);
        }
    }
}
