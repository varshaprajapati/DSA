/*
 * Problem: Left Rotate Array by One
 *
 * Given an array, rotate it left by one position.
 * This means the first element moves to the last position
 * and all other elements shift one position to the left.
 *
 * Example:
 * Input:  [1, 2, 3, 4, 5]
 * Output: [2, 3, 4, 5, 1]
 *
 * --------------------------------------------------
 * Brute Force Approach:
 * --------------------------------------------------
 *
 * Create a new array and copy each element one position
 * to the left. Finally, place the original first element
 * at the last position.
 *
 * Time Complexity: O(n)
 * Space Complexity: O(n)
 *
 * --------------------------------------------------
 * Optimal Approach: In-Place
 * --------------------------------------------------
 *
 * Store the first element in a temporary variable.
 *
 * Shift every remaining element one position to the left.
 *
 * Finally, place the saved first element at the last
 * position.
 *
 * This avoids creating another array.
 *
 * --------------------------------------------------
 * Key Concepts:
 * - Array Traversal
 * - In-Place Array Modification
 * - Constant Extra Space
 * - Saving Data Before Overwriting
 *
 * --------------------------------------------------
 * 
 * Optimal Solution Implementation:
 * Time Complexity: O(n)
 * Space Complexity: O(1)
 * 
 * Brute Force Solution Implementation:
 * Time Complexity: O(n)
 * Space Complexity: O(n)
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays
{
    public class Rotate_array_left_by_1place
    {
        public int[] LeftRotate(int[] arr)
        {

            // Brute Force Approach

            //int n = arr.Length;

            //if (n <= 1)
            //{
            //    return arr;
            //}

            //int[] result = new int[n];

            //for (int i = 0; i < n - 1; i++)
            //{
            //    result[i] = arr[i + 1];
            //}

            //result[n - 1] = arr[0];

            //return result;

            // ---------------------------------------------------------------------------------------------

            // Optimal Approach: In-Place

            if (arr.Length <= 1)
            {
                return arr;
            }

            int temp = arr[0];
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[n-1] = temp;
            return arr;
        }
    }
}
