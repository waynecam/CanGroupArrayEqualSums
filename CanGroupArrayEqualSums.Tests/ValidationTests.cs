using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;
using Xunit;

namespace CanGroupArrayEqualSums.Tests
{
    public class ValidationTests
    {

        [Theory]
        [InlineData("1,2,3,4,5,6", true)]
        [InlineData("e,4,5", false)]
        public void ValidateInputTests(string input, bool expectedResult)
        {
            var result = false;
            
            result = ValidationHelper.ValidateArrayInput(input);

            result.ShouldBe(expectedResult);
        }



    }
}
