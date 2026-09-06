/*
    Problem:
    Given an array containing n distinct numbers in the range [0, n],
    return the only number missing from the array.

    Example:
    Input:  [3, 0, 1]
    Output: 2

    --------------------------------------------------
    Brute Force Approach:
    --------------------------------------------------
    For every number from 0 to n, search for that number
    in the array using Contains().

    Time Complexity: O(n²)
    Space Complexity: O(1)

    --------------------------------------------------
    Better Approach:
    --------------------------------------------------
    Store all elements in a HashSet and check which number
    from 0 to n is missing.

    Time Complexity: O(n) average
    Space Complexity: O(n)

    --------------------------------------------------
    Optimal Approach:
    --------------------------------------------------
    Calculate the expected sum of numbers from 0 to n
    using the formula:

        n * (n + 1) / 2

    Subtract the actual sum of the array from the expected sum.
    The difference is the missing number.

    Time Complexity: O(n)
    Space Complexity: O(1)

    Pattern:
    Array / Math / Sum Formula
*/

namespace DSA.Arrays
{
    public class Missing_number
    {
        public int FindMissingOptimal(int[] nums)
        {

            // Brute Force

            //int n = nums.Length;

            //for (int number = 0; number <= n; number++)
            //{
            //    if (!nums.Contains(number))
            //    {
            //        return number;
            //    }
            //}

            //return -1;

            // --------------------------------------------------------------------------------------------

            // Optimal - Sum Formula

            int n = nums.Length;
            int expected_sum = n*(n + 1) / 2;
            int sum = 0;

            for(int i=0; i < n; i++)
            {
                sum += nums[i];
            }

            return expected_sum - sum;
        }
    }
}
