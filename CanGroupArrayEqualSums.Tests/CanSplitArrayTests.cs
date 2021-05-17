using System;
using Xunit;

namespace CanGroupArrayEqualSums.Tests
{
    public class CanSplitArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 3, 4, 5 }, true)]
        [InlineData(new int[] { 1, 4, 5, 8 }, true)]
        [InlineData(new int[] { 2, 2, 4, 6 }, false)]
        [InlineData(new int[] { 2, 14 }, false)]
        public void CanSplitArrayInto2equallySummedGroupsTests(int[] arr, bool expectedResult)
        {
            var result = CanSplitArray.CanSplitArrayIntoEqualSummedGroups(arr);

            Assert.Equal(result.CanSplit, expectedResult);
        }
    }
}
