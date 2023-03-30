using CSharpConcepts.ExerciseBase;
using CSharpConcepts.ExerciseBase.Validators;
using System;

namespace CSharpConcepts.Exercises
{
    public class ExerciseOne : BaseExercise
    {
        public ExerciseOne() : base() { }

        private bool isValidInput = false;

        private bool isFirstTry = true;
        private string userInput = "";

        //Run this Exercise
        public override void Run()
        {

            while (!isValidInput)
            {
                if (!isFirstTry)
                {
                    Console.WriteLine("Invalid input. Only alphabets and spaces are allowed. \n");
                }

                DisplayInstructions(BaseInstructions.ExerciseOne);

                Console.WriteLine("Enter a string with alphabets and spaces only:");

                userInput = Console.ReadLine();

                isValidInput = userInput.IsOnlyAlphabetical();

                if (isFirstTry)
                {
                    isFirstTry = false;
                }
            }

            if (isValidInput)
            {
                MainFunction(userInput);
            }
        }

        //Answer to Exercise One goes in this Function
        private static void MainFunction(string input)
        {
            Console.WriteLine($"You have entered: {input} \n");

            #region Default

            //string result = input.IsValidPalindrome() ? string.Empty : "not ";

            #endregion


            #region out keyword

            //bool isValidPalindrome = false;

            //input.IsValidPalindrome_Out(out isValidPalindrome);

            //string result = isValidPalindrome ? string.Empty : "not ";
            #endregion


            #region ref keyword

            bool isValidPalindrome = false;

            input.IsValidPalindrome_Ref(ref isValidPalindrome); //assigning outside that's why it works...

            string result = isValidPalindrome ? string.Empty : "not ";
            #endregion

            //Next Step: Difference between Out & Ref

            Console.WriteLine($"{input} is " + result + "a valid Palindrome.") ;
        }
    }
}
