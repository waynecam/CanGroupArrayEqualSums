using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CanGroupArrayEqualSums
{
    public class ValidationHelper
    {
        public static bool ValidateArrayInput(string input)
        {
            var isValid = false;

            var pattern = @"^[0-9,]*$";

            Regex validInput = new Regex(pattern);

            isValid = validInput.IsMatch(input);

            return isValid;


        }
    }
}
