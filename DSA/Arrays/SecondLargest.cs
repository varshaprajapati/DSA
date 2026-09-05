/*
 * Problem: Find Second Largest Distinct Element
 *
 * Given an array of integers, find the second largest
 * distinct element.
 *
 * Example:
 * Input:  [12, 35, 1, 10, 34, 1]
 * Output: 34
 *
 * --------------------------------------------------
 * Approach: Track Two Maximums
 * --------------------------------------------------
 *
 * Maintain two variables:
 *
 *     largest
 *     secondLargest
 *
 * While traversing the array:
 *
 * 1. If current number is greater than largest:
 *      - Previous largest becomes secondLargest
 *      - Current number becomes largest
 *
 * 2. Otherwise, if current number is greater than
 *    secondLargest and different from largest:
 *      - Update secondLargest
 *
 * The `num != largest` condition ensures that duplicate
 * values are not considered as the second largest element.
 *
 * This avoids sorting the array and solves the problem
 * in a single traversal.
 *
 * --------------------------------------------------
 * Key Concept:
 * Maximum So Far / Maintaining Multiple Best Values
 *
 * Important:
 * Use int.MinValue instead of 0 so the solution works
 * correctly when the array contains negative numbers.
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
    public class SecondLargest
    {
        public int? FindSecondLargest(int[] arr)
        {
            int largest = int.MinValue;
            int? secondLargest = null;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest == int.MinValue
                        ? null
                        : largest;

                    largest = num;
                }
                else if (num != largest &&
                         (secondLargest is null || num > secondLargest))
                {
                    secondLargest = num;
                }
            }

            return secondLargest;
        }
    }
}
