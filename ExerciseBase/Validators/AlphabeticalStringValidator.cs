using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts.ExerciseBase.Validators
{
    public static class AlphabeticalStringValidator
    {
        //public static bool IsOnlyAlphabetical()
        //{


        //    return false;
        //}

        private static bool IsNeitherLetterNorSpace(char c)
        {
            return !Char.IsLetter(c) && !Char.IsSeparator(c);
        }

        public static bool IsOnlyAlphabetical(this string inputString)
        {
            if (inputString != null)
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (IsNeitherLetterNorSpace(inputString[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        #region Default
        public static bool IsValidPalindrome(this string inputString)
        {
            string initialInput = StringFilter(inputString);
            string reversedInput = string.Empty;

            for (int i = initialInput.Length - 1; i >= 0; i--)
            {
                reversedInput += initialInput[i];
            }

            return reversedInput == initialInput;
        }

        #endregion


        #region out keyword
        public static void IsValidPalindrome_Out(this string inputString, out bool output)
        {
            string initialInput = StringFilter(inputString);
            string reversedInput = string.Empty;

            for (int i = initialInput.Length - 1; i >= 0; i--)
            {
                reversedInput += initialInput[i];
            }

            output = reversedInput == initialInput;
        }

        #endregion

        #region ref keyword

        public static void IsValidPalindrome_Ref(this string inputString, ref bool output)
        {
            string initialInput = StringFilter(inputString);
            string reversedInput = string.Empty;

            for (int i = initialInput.Length - 1; i >= 0; i--)
            {
                reversedInput += initialInput[i];
            }

            output = reversedInput == initialInput;
        }

        #endregion

        private static string StringFilter(string inputString)
        {
            string outputString = string.Empty;
            foreach (char c in inputString.ToLower())
            {
                if (Char.IsLetter(c)) outputString += c;
            }

            return outputString;
        }
    }
}
