using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace CanGroupArrayEqualSums.Tests
{
    public class InputFormatterTests
    {
        [Theory]
        [InlineData("1,2,3,4,5,6", new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData("1,2,3,,4,5,,6", new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(",1,2,3,,4,5,,6,", new int[] { 1, 2, 3, 4, 5, 6 })]
        public void ConvertCSVStringToNumericalArrayTest(string input, int[] expectedOutput)
        {
            int[] arr= InputFormatterHelper.ConvertCSVStringToNumericalArray(input);

            arr.ShouldBeEquivalentTo(expectedOutput);

        }


    }
}
