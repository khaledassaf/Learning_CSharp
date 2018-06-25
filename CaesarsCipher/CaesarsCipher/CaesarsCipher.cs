using System;
using System.Linq;

namespace CaesarsCipherHelper
{
    public static class CaesarsCipher
    {
        static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public static string Decode(string encodedString, int shiftAmount)
        {
            string decodedString = "";
             

            for(int i = 0; i < encodedString.Length; i++)
            {
                char c = encodedString[i];
                
                if (alphabet.Contains(c))
                {
                    int j = Array.IndexOf(alphabet, c);
                    j = (j + shiftAmount) % (alphabet.Length);

                    c = alphabet[j];
                }

                decodedString += c;
            }

            return decodedString;
        }
    }
}
