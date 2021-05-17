using System;
using System.Text.RegularExpressions;

namespace CanGroupArrayEqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display Title and Instructions
            Console.WriteLine("Split Array into 2 equal groups Example#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Please input a comma seperated array values (e.g. 1,5,10,12) and press ENTER");
            Console.WriteLine("------------------------\n");

            //Get User Input
            var input = Console.ReadLine();

            //Ensure the input is valid
            while(!ValidationHelper.ValidateArrayInput(input))
            {
                Console.WriteLine("Invalid Input. Please input a comma seperated array values (e.g. 1,5,10,12) and press ENTER");
            }

            //convert valid string into an array
            var numArray = InputFormatterHelper.ConvertCSVStringToNumericalArray(input);

            //check the array can be split into equally summed groups
            var result = CanSplitArray.CanSplitArrayIntoEqualSummedGroups(numArray);


            //display the result
            Console.WriteLine("\n");

            Console.WriteLine("--RESULT--");
           
            Console.WriteLine($"Can Split: {result.CanSplit}, Message:  {result.Message}");


        }

    }
}
