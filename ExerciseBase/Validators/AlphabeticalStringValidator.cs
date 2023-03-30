using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts.ExerciseBase.Validators
{
    public static class AlphabeticalStringValidator
    {
        

        private static bool IsNeitherLetterNorSpace(char c)
        {
            return true; //TODO
        }

        public static bool IsOnlyAlphabetical(this string inputString)
        {
            //TODO

            return true;
        }

        #region Default
        public static bool IsValidPalindrome(this string inputString)
        {
            //TODO

            return true;
        }

        #endregion


        #region out keyword
        public static void IsValidPalindrome_Out(this string inputString, out bool output)
        {
            //TODO

            output = true;
        }

        #endregion

        #region ref keyword

        public static void IsValidPalindrome_Ref(this string inputString, ref bool output)
        {
            //TODO

            output = true;
        }

        #endregion

        private static string StringFilter(string inputString)
        {
            //TODO

            string outputString = string.Empty;

            return outputString;
        }
    }
}
