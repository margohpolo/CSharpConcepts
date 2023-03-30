using CSharpConcepts.ExerciseBase.Validators;
using System;

namespace CSharpConcepts.ExerciseBase
{
    public class BaseExercise
    {
        public BaseExercise() { }

        protected static void DisplayInstructions(string exerciseName)
        {
            Console.WriteLine(BaseInstructions.BaseCommand);
            Console.WriteLine(exerciseName);
        }

        public virtual void Run()
        {
            Console.WriteLine("Uh oh! Base Class Run method not overridden!");
        }

        #region Simple Array Validator
        //protected bool ValidateNumericalArrayInput(string input)
        //{
        //    char[] inputArray = input.ToCharArray();
        //    foreach (char c in inputArray)
        //    {
        //        if (!SingleCharacterValidation(c))
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        //private bool SingleCharacterValidation(char inputChar) => Char.IsDigit(inputChar) || inputChar == ',';
        #endregion

        #region Complex Numerical Array Validator
        protected bool ValidateNumericalArrayInput(string input)
        {
            return NumericalArrayValidator.Array_UpToRuleFour(input);
        }
        #endregion

        #region Alphabetical-Only String Validator
        protected bool ValidateAlphabeticalStringInput(string input)
        {
            return input.IsOnlyAlphabetical();
        }
        #endregion

    }
}
