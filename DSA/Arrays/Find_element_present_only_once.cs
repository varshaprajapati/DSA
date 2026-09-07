using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays
{
    public class Find_element_present_only_once
    {
        public int SingleNumber(int[] nums)
        {

            // Brute Force

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int count = 0;

            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            count++;
            //        }
            //    }

            //    if (count == 1)
            //    {
            //        return nums[i];
            //    }
            //}

            //return -1;

            // --------------------------------------------------------------------------------------------------

            // HashSet

            //HashSet<int> set = new();

            //foreach (int num in nums)
            //{
            //    if (set.Contains(num))
            //    {
            //        set.Remove(num);
            //    }
            //    else
            //    {
            //        set.Add(num);
            //    }
            //}

            //return set.First();

            // --------------------------------------------------------------------------------------------------

            // Optimal - XOR

            int result = 0;
             
            foreach (int num in nums )
            {
                result ^= num; // XOR operation

            }

            return result;
        }
    }
}
