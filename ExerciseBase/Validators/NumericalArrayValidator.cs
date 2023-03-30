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
            return !string.IsNullOrWhiteSpace(input);
        }

        //Rule 2: Array can only contain digits and commas
        public static bool ArrayHasDigitsAndCommasOnly_Bad(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            char[] characters = input.ToCharArray();
            bool isValidCharacter = false;
            foreach (char c in characters)
            {
                if (Char.IsDigit(c) || c == ',')
                {
                    isValidCharacter = true;
                }
                else
                {
                    break;
                }
            }
            return isValidCharacter;
        }
        public static bool ArrayHasDigitsAndCommasOnly_Good(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            char[] characters = input.ToCharArray();
            foreach (char c in characters)
            {
                if (!Char.IsDigit(c) || c != ',')
                {
                    return false;
                }
            }
            return true;
        }
        
        
        //-> Almost there. If this is the rule, then (only digits) OR (only commas) will be accepted. But we need at least one comma
        //Therefore, Rule 3: Array must contain at least one comma
        
        public static bool ArrayHasDigitsAndCommasOnly_Good_AndAtLeastOneComma(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            char[] characters = input.ToCharArray();

            int commaCounter = 0;

            foreach (char c in characters)
            {
                if (c == ',')
                {
                    commaCounter++; //
                }

                if (!Char.IsDigit(c) || c != ',') //
                {
                    return false;
                }
            }

            if (commaCounter == 0)
            {
                return false;
            }

            return true;
        }

        public static bool ArrayHasDigitsAndCommasOnly_Good_AndAtLeastOneComma_EvenBetter(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            char[] characters = input.ToCharArray();

            int commaCounter = 0;

            foreach (char c in characters)
            {
                if (commaCounter.Equals(0) && c.Equals(',')) //
                {
                    commaCounter++;
                }

                else if (!Char.IsDigit(c)) //
                {
                    return false;
                }
            }

            if (commaCounter.Equals(0))
            {
                return false;
            }

            return true;
        }



        //Rule 4: Array cannot start or end with a comma
        public static bool Array_UpToRuleFour(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            char[] characters = input.ToCharArray();

            int commaCounter = 0;

            for (int i = 0; i < characters.Length; i++)
            {
                if (!Char.IsDigit(characters[i])) // if we default to returning true, we only need to handle the return false scenarios
                {
                    if (characters[i].Equals(','))
                    {
                        if (i.Equals(0) || i.Equals(characters.Length - 1))
                        {
                            return false;
                        }
                        else
                        {
                            commaCounter++; //don't really have to ++ every time...how to optimize this? same thing if it's a bool instead, right...?
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

                if (i.Equals(characters.Length - 1) && commaCounter.Equals(0))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
