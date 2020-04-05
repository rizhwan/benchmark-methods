using System;

namespace Test
{
    public class ReverseCharacters
    {

        public static string WithoutFramework(string characters)
        {
            int characterLength = characters.Length - 1;
            char[] stringArray = new char[characters.Length];
            int i = 0;
            int j = characterLength;

            while (i <= characterLength)
            {
                stringArray[i] = characters[j];
                i++;
                j--;
            }

            return new string(stringArray);
        }


        public static string WithFramework(string characters)
        {
            char[] stringArray = characters.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);

            return reverseString;
        }
    }
}
