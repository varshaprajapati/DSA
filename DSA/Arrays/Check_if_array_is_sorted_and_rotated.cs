/*
 * Problem: Check if Array Is Sorted and Rotated
 *
 * Given an array, return true if it was originally sorted
 * in non-decreasing order and then rotated some number
 * of positions.
 *
 * Duplicates are allowed.
 *
 * Example:
 * Input:  [3, 4, 5, 1, 2]
 * Output: true
 *
 * Input:  [2, 1, 3, 4]
 * Output: false
 *
 * --------------------------------------------------
 * Approach: Count Decreasing Pairs
 * --------------------------------------------------
 *
 * In a non-decreasing sorted array:
 *
 *     nums[i] <= nums[i + 1]
 *
 * A sorted array that has been rotated can have at most
 * one position where this ordering is violated.
 *
 * Example:
 *
 *     [3, 4, 5, 1, 2]
 *           ↑
 *        5 > 1
 *
 * We count the number of times:
 *
 *     nums[i] > nums[next]
 *
 * If the count is greater than 1, the array cannot be
 * sorted and rotated.
 *
 * We use circular indexing so that the last element is
 * also compared with the first element:
 *
 *     next = (i + 1) % n
 *
 * The `>` comparison is important because the array is
 * allowed to contain duplicates (non-decreasing order).
 *
 * --------------------------------------------------
 * Key Concepts:
 * - Circular Array / Circular Indexing
 * - Modulo Operator (%)
 * - Counting Violations
 * - Non-decreasing Order
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
    public class Check_if_array_is_sorted_and_rotated
    {
        public bool Check(int[] nums)
        {
            int count = 0;
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                int next = (i + 1) % n;    // mod n to limit the index within the array length

                if (nums[i] > nums[next])
                {
                    count++;
                }

                if (count > 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
