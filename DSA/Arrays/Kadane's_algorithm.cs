/*
QUESTION:
Given an integer array nums, find the subarray with the largest sum
and return its sum.

Example:
Input:  [-2,1,-3,4,-1,2,1,-5,4]
Output: 6

The subarray [4,-1,2,1] has the largest sum.


APPROACH 1 - BRUTE FORCE:
Generate every possible subarray and calculate its sum
using a running sum.

Time Complexity: O(n²)
Space Complexity: O(1)


APPROACH 2 - KADANE'S ALGORITHM (OPTIMAL):
For every element, decide whether to:

1. Start a new subarray from the current element
2. Continue the previous subarray

currentSum = Math.Max(nums[i], currentSum + nums[i])

Keep track of the largest sum seen so far.

Time Complexity: O(n)
Space Complexity: O(1)

Test Cases 🧪

| #  | Input                     | Expected |
| -- | ------------------------- | -------: |
| 1  | `[-2,1,-3,4,-1,2,1,-5,4]` |      `6` |
| 2  | `[1]`                     |      `1` |
| 3  | `[5]`                     |      `5` |
| 4  | `[-5,-2,-8,-1]`           |     `-1` |
| 5  | `[1,2,3,4]`               |     `10` |
| 6  | `[-1,-2,-3]`              |     `-1` |
| 7  | `[5,-2,3,4]`              |     `10` |
| 8  | `[-2,1]`                  |      `1` |
| 9  | `[2,-1,2,3,-9,4]`         |      `6` |
| 10 | `[-2,1,-3,4,-1,2,1]`      |      `6` |

*/

namespace DSA.Arrays
{
    public class Kadane_s_algorithm
    {
        public int MaxSubArray(int[] nums)
        {

            // Brute Force

            //int maxSum = int.MinValue;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int currentSum = 0;

            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        currentSum += nums[j];

            //        maxSum = Math.Max(maxSum, currentSum);
            //    }
            //}

            //return maxSum;


            // -----------------------------------------------------------------------------------------------------

            // Kadane's Algorithm - Optimal
            int currentSum = nums[0];
            int result = nums[0];


            for(int i =1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);

                result = Math.Max(result, currentSum);
                
            }
            return result;
        }

    }
}
