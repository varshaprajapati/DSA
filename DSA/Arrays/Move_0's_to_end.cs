/*
    Problem:
    Move all zeroes to the end of the array while maintaining
    the relative order of non-zero elements.

    Example:
    Input:  [0, 1, 0, 3, 12]
    Output: [1, 3, 12, 0, 0]

    Approach:
    Use two pointers:
    - i scans the array.
    - j tracks the position where the next non-zero element
      should be placed.

    First, move all non-zero elements to the front.
    Then fill the remaining positions with zeroes.

   // Optimal Approach — Two Pointers

    Time Complexity: O(n)
    Space Complexity: O(1)

   // Brute Force Approach

    Time Complexity: O(n)
    Space Complexity: O(n)

    Pattern:
    Two Pointers / In-Place Array Manipulation
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays
{
    public class Move_0_s_to_end
    {
        public int[] Move(int[] nums)
        {
            int i = 0;

            for(int j=0; j<nums.Length; j++)
            {
                if (nums[j] != 0)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                    i++;
                }
            }

            return nums;
        }
    }
}
