using CSharpConcepts.ExerciseBase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpConcepts.Exercises
{
    public class ExerciseTwo : BaseExercise
    {
        public ExerciseTwo() : base() { }

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
                    Console.WriteLine("Invalid input. Only an array of numbers and commas without spaces is allowed. \n");
                }

                DisplayInstructions(BaseInstructions.ExerciseTwo);

                Console.WriteLine("Enter an array of integers without spaces:");

                userInput = Console.ReadLine();

                isValidInput = ValidateNumericalArrayInput(userInput);

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

        //Answer to Exercise Two goes in this Function
        private static void MainFunction(string input)
        {
            Console.WriteLine($"You have entered: {input}");

            int[] intArray = ConvertStringInputToIntArray(input);

            Console.WriteLine("Output: { " + PrintCumulativeArray(intArray) + " }");
        }

        private static int[] ConvertStringInputToIntArray(string inputString)
        {
            var output = new List<int>();

            //TODO

            return output.ToArray();
        }

        private static string PrintCumulativeArray(int[] inputArray)
        {
            string output = "";
            
            //TODO

            return output;
        }
    }
}
