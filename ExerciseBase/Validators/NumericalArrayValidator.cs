using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts.ExerciseBase.Validators
{
    public static class NumericalArrayValidator
    {
        //Rule 1 Input cannot be null
        public static bool InputCannotBeNull(string? input)
        {
            return true; //TODO
        }

        //Rule 2: Array can only contain digits and commas
        public static bool ArrayHasDigitsAndCommasOnly(string? input)
        {
            //TODO

            return true;
        }
        
        
        //-> Almost there. If this is the rule, then (only digits) OR (only commas) will be accepted. But we need at least one comma
        //Therefore, Rule 3: Array must contain at least one comma
        
        public static bool ArrayHasDigitsAndCommasOnly_Good_AndAtLeastOneComma(string? input)
        {
            //TODO

            return true;
        }

        //Rule 4: Array cannot start or end with a comma
        public static bool Array_UpToRuleFour(string? input)
        {
            //TODO

            return true;
        }

    }
}
