/*
QUESTION:
Given an array of integers nums and an integer k,
return the total number of subarrays whose sum equals k.

Example:
Input:  nums = [1,1,1], k = 2
Output: 2


APPROACH 1 - BRUTE FORCE:
Generate every possible subarray using two loops.
Maintain a running sum and increase the count whenever
the sum equals k.

Time Complexity: O(n²)
Space Complexity: O(1)


APPROACH 2 - PREFIX SUM + DICTIONARY (OPTIMAL):

Prefix Sum:
Current Prefix Sum - Previous Prefix Sum = K

Therefore:

Previous Prefix Sum = Current Prefix Sum - K

Store:
prefix sum → frequency

Unlike the Longest Subarray problem, we store the
frequency because every occurrence of the required
prefix sum represents a different valid subarray.

Initialize:
{ 0, 1 }

This handles subarrays that start at index 0.

Time Complexity: O(n)
Space Complexity: O(n)

Test Cases

| #  | Input                |    K | Expected |
| -- | -------------------- | ---: | -------: |
| 1  | `[1,1,1]`            |  `2` |      `2` |
| 2  | `[1,2,3]`            |  `3` |      `2` |
| 3  | `[1,-1,0]`           |  `0` |      `3` |
| 4  | `[0,0,0]`            |  `0` |      `6` |
| 5  | `[1]`                |  `1` |      `1` |
| 6  | `[1]`                |  `2` |      `0` |
| 7  | `[-1,-1,1]`          |  `0` |      `1` |
| 8  | `[3,4,7,2,-3,1,4,2]` |  `7` |      `4` |
| 9  | `[1,2,1,2,1]`        |  `3` |      `4` |
| 10 | `[-1, -1, 1]`        | `-1` |      `2` |

*/

namespace DSA.Arrays
{
    public class Number_of_subarray_sum_equal_k
    {
        public int SubarraySum(int[] nums, int k)
        {

            // Brute Force

            //int count = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int sum = 0;

            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        sum += nums[j];

            //        if (sum == k)
            //        {
            //            count++;
            //        }
            //    }
            //}

            //return count;


            // -----------------------------------------------------------------------------------------------

            // Prefix Sum + Dictionary - Optimal

            int result = 0;
            int prefixSum = 0;

            Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                prefixSum += i;

                if(prefixSum == k)
                {
                    result++;
                }

                if (prefixSumCount.ContainsKey(prefixSum - k))
                {
                    result += prefixSumCount[prefixSum - k];
                }

                if (prefixSumCount.ContainsKey(prefixSum))
                {
                    prefixSumCount[prefixSum]++;

                }
                else
                {
                    prefixSumCount[prefixSum] = 1;
                }

            }
            return result;
        }
    }
}
