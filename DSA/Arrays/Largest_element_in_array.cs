/*
 * Problem: Find Largest Element in an Array
 *
 * Given an array of integers, find the largest element.
 *
 * Example:
 * Input:  [1, 8, 7, 56, 90]
 * Output: 90
 *
 * --------------------------------------------------
 * Approach: Maximum So Far
 * --------------------------------------------------
 *
 * Keep track of the largest element encountered while
 * traversing the array.
 *
 * Start with the first element as the current maximum.
 * For every remaining element:
 *
 *     if current element > maximum
 *         update maximum
 *
 * At the end of the traversal, maximum contains the
 * largest element in the array.
 *
 * --------------------------------------------------
 * Key Concept:
 * Maximum/Minimum So Far Pattern
 *
 * Important:
 * Initialize max with arr[0] instead of 0 so that the
 * solution also works when all elements are negative.
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
    public class Largest_element_in_array
    {
        public int FindLargest(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
}
