using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsHelper
{
    public static class RomanNum
    {
        public static string Convert(int num)
        {
            var numMap = new Dictionary<string, int>
            {
                {"M", 1000 },
                {"CM", 900 },
                {"D", 500 },
                {"CD", 400 },
                {"C", 100 },
                {"XC", 90 },
                {"L", 50 },
                {"XL", 40 },
                {"X", 10 },
                {"IX", 9 },
                {"V", 5 },
                {"IV", 4 },
                {"I", 1 }
            };

            string rn = "";

            foreach (var n in numMap)
            {
                rn += string.Concat(Enumerable.Repeat(n.Key, num / n.Value));
                num = num % n.Value;
            }

            return rn;
        }
    }
}
