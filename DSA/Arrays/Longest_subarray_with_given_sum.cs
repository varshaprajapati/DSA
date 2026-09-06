/*
    Problem:
    Given an array A of size N and an integer K,
    find the length of the longest subarray whose sum is K.

    Example:
    A = [1, 2, 3, 1, 1, 1, 1]
    K = 3

    Output:
    3


    ==================================================
    Brute Force
    ==================================================

    Generate every possible subarray and maintain a
    running sum.

    Time Complexity: O(N²)
    Space Complexity: O(1)


    ==================================================
    Sliding Window
    ==================================================

    Can be used when the array contains only positive
    numbers (or non-negative numbers, with appropriate
    handling).

    Use left and right pointers to maintain a window.

    Time Complexity: O(N)
    Space Complexity: O(1)


    ==================================================
    Optimal General Approach
    ==================================================

    Prefix Sum + HashMap.

    At every index:

        currentSum = prefix sum

    We need:

        previousSum = currentSum - K

    If previousSum was seen before, the elements between
    that index and the current index have sum K.

    Store only the earliest index for each prefix sum
    because we want the longest subarray.

    Time Complexity: O(N) average
    Space Complexity: O(N)


    Pattern:
    Prefix Sum + HashMap
*/

using System;
using System.Collections.Generic;

namespace DSA.Arrays
{
    public class Longest_subarray_with_given_sum
    {
        public int FindLongest(int[] nums, int k)
        {
            // --------------------------------------------------
            // Brute Force
            // --------------------------------------------------


            //int maxLength = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int sum = 0;

            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        sum += nums[j];

            //        if (sum == k)
            //        {
            //            int length = j - i + 1;
            //            maxLength = Math.Max(maxLength, length);
            //        }
            //    }
            //}

            //return maxLength;

            // --------------------------------------------------
            // Optimal - Prefix Sum + HashMap
            // Works with positive, negative and zero values
            // -----------------------------------------------------


            Dictionary<int, int> mp = new Dictionary<int, int>();
            int res = 0;
            int prefSum = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                prefSum += nums[i];

                // Check if the entire prefix sums to k
                if (prefSum == k)
                    res = i + 1;

                // If prefixSum - k exists in the map then there exist such 
                // subarray from (index of previous prefix + 1) to i.
                else if (mp.ContainsKey(prefSum - k))
                    res = Math.Max(res, i - mp[prefSum - k]);

                // Store only first occurrence index of prefSum
                if (!mp.ContainsKey(prefSum))
                    mp[prefSum] = i;
            }

            return res;

        }
    }
}
