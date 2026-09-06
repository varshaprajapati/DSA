/*
 * Problem: Rotate Array to the Right by K Steps
 *
 * Given an integer array, rotate it to the right by k
 * positions.
 *
 * Example:
 * Input:  nums = [1, 2, 3, 4, 5, 6, 7], k = 3
 * Output: [5, 6, 7, 1, 2, 3, 4]
 *
 * --------------------------------------------------
 * Brute Force Approach:
 * --------------------------------------------------
 *
 * Rotate the array one position to the right and repeat
 * this process k times.
 *
 * Each rotation takes O(n), and we perform it k times.
 *
 * Time Complexity: O(n * k)
 * Space Complexity: O(1)
 *
 * --------------------------------------------------
 * Better Approach:
 * --------------------------------------------------
 *
 * Create a new array and calculate the new position of
 * every element:
 *
 *     newIndex = (i + k) % n
 *
 * This solves the problem in one traversal but requires
 * an additional array.
 *
 * Time Complexity: O(n)
 * Space Complexity: O(n)
 *
 * --------------------------------------------------
 * Optimal Approach: Reversal Algorithm
 * --------------------------------------------------
 *
 * Divide the array into two parts:
 *
 *     A B
 *
 * where B contains the last k elements.
 *
 * We want:
 *
 *     B A
 *
 * Perform three reversals:
 *
 * 1. Reverse the entire array
 * 2. Reverse the first k elements
 * 3. Reverse the remaining elements
 *
 * Example:
 *
 *     [1, 2, 3, 4, 5, 6, 7]
 *
 * Reverse entire:
 *     [7, 6, 5, 4, 3, 2, 1]
 *
 * Reverse first k:
 *     [5, 6, 7, 4, 3, 2, 1]
 *
 * Reverse remaining:
 *     [5, 6, 7, 1, 2, 3, 4]
 *
 * `k %= n` is used because rotating an array by n positions
 * produces the original array.
 *
 * --------------------------------------------------
 * Key Concepts:
 * - Two Pointers
 * - Array Reversal
 * - In-Place Array Modification
 * - Modulo Operator
 * - Tuple Deconstruction in C#
 *
 * --------------------------------------------------
 * Time Complexity: O(n)
 * Space Complexity: O(1)
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays
{
    public class Rotate_array_left_right_by_k_places
    {
        public int[] Rotate(int[] nums, int k)
        {

            // Brute force approach

            //if (nums.Length <= 1)
            //{
            //    return nums;
            //}

            //for (int step = 0; step < k; step++)
            //{
            //    int last = nums[^1];

            //    for (int i = nums.Length - 1; i > 0; i--)
            //    {
            //        nums[i] = nums[i - 1];
            //    }

            //    nums[0] = last;
            //}

            //return nums;


            // --------------------------------------------------------------------------------------------

            //Better Approach — Extra Array

            //int n = nums.Length;

            //if (n <= 1)
            //{
            //    return nums;
            //}

            //k %= n;

            //int[] result = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    int newIndex = (i + k) % n;
            //    result[newIndex] = nums[i];
            //}

            //return result;

            // --------------------------------------------------------------------------------------------

            // Optimal Approach — Reversal Algorithm

            if (nums == null || k == 0)
            {
                return nums;
            }

            int n = nums.Length;
            k %= n;

            // rotate right by k steps

            Reverse(nums, 0, n - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, n - 1);



            // rotate left by k steps

            //Reverse(nums, 0, k - 1);
            //Reverse(nums, k, n - 1);
            //Reverse(nums, 0, n - 1);


            return nums;
        }

        private void Reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
                right--;
            }
        }
    }
}
