using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CanGroupArrayEqualSums
{
    public class CanSplitArray
    {

        public static Result CanSplitArrayIntoEqualSummedGroups(int[] arr)
        {

            var result = new Result(canSplit: false, "");

            //convert array into a list - easier to manipulate
            var fullList = arr.ToList();

            //an array with less than 2 elements cant be split into 2 groups
            if (fullList.Count() < 2)
            {
                result.Message = "Cannot split an array with less than 2 elements";
                return result;
            }

            //an array that doesnt sum to an even number cant be group equally (whole numbers)
            if (fullList.Sum() % 2 != 0)
            {
                result.Message = "Array does not sum to even number so cannot group equally based on sum";
                return result;
            }

            //get half the sum of the array values
            var halfFullArraySum = fullList.Sum() / 2;

            //counter for when we have checked all fulllist array elements
            var counter = 0;

            //this list will hold enough values to equal half the sum of the full List
            List<int> runningHalfSumList = new List<int>();

            while (runningHalfSumList.Sum() != halfFullArraySum && counter < fullList.Count() - 1)
            {
                foreach (var val in fullList.OrderByDescending(x => x))
                {
                    //cant have a value that is bigger than of the 'half of the full array sum' so this array cant be split equally
                    if (val > halfFullArraySum)
                    {
                        result.Message = "Contains a single value too large to split";
                        return result;
                    }

                    //if a single value equals 'half of the full array sum' then the array can be split
                    if (val == halfFullArraySum)
                    {
                        result.CanSplit = true;
                        result.Message = "Contains a single value that is half the sum of the entire array";
                        return result;
                    }

                    //add the value if its less then 'half of the full array sum '
                    if (val < halfFullArraySum)
                    {
                        runningHalfSumList.Add(val);

                        //if adding the current value exceeds 'half of the full array sum' remove it
                        // and move onto the next value
                        if (runningHalfSumList.Sum() > halfFullArraySum)
                        {
                            runningHalfSumList.Remove(val);
                            counter++;
                            continue;
                        }

                        //if adding the new value to the running half array sum equals 'half of the full array sum'
                        //we have two equal sub groups so exit the loop
                        if (runningHalfSumList.Sum() == halfFullArraySum)
                        {
                            result.CanSplit = true;
                            result.Message = "Contains enough values to split the array into 2 equally summed groups";
                            return result;
                        }
                    }
                }
            }

            
            result.Message = "Does not contain enough equally split values to split the array fairly into 2 equally summed groups";
            return result;

        }


    }
}
