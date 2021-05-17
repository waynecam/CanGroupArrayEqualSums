using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CanGroupArrayEqualSums
{
    public class InputFormatterHelper
    {
        public static int[] ConvertCSVStringToNumericalArray(string input)
        {

            var cleanCsvInput = CleanUpCSV(input);

            int[] result = cleanCsvInput.Split(",").Select(x => int.Parse(x)).ToArray();

            return result;

        }



        private static string CleanUpCSV(string input)
        {
            var cleanCSV = input.Trim(',');

            cleanCSV = Regex.Replace(cleanCSV, @",+", ",");

            return cleanCSV;
        }
    }
}
