/*
 * Problem: Remove Duplicates from Sorted Array
 *
 * Given a sorted array in non-decreasing order, remove
 * duplicates in-place so that each unique element appears
 * only once.
 *
 * Return the number of unique elements, k.
 *
 * The first k elements of the array must contain the
 * unique elements in their original relative order.
 * Elements after index k - 1 are not important.
 *
 * Example:
 * Input:  [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
 * Output: 5
 * Result: [0, 1, 2, 3, 4, _, _, _, _, _]
 *
 * --------------------------------------------------
 * Approach: Two Pointers
 * --------------------------------------------------
 *
 * Use two pointers:
 *
 * k -> slow pointer that represents the position of the
 *      last unique element.
 *
 * j -> fast pointer that traverses the array.
 *
 * Since the array is sorted, duplicate values are always
 * next to each other.
 *
 * For every nums[j]:
 *
 *     If nums[j] == nums[k]:
 *         It is a duplicate, so skip it.
 *
 *     If nums[j] != nums[k]:
 *         It is a new unique value.
 *         Move k forward and place nums[j] at nums[k].
 *
 * We do not need to swap elements because everything after
 * the first k unique elements is irrelevant.
 *
 * --------------------------------------------------
 * Key Concepts:
 * - Two Pointers
 * - Slow and Fast Pointer
 * - In-place Array Modification
 * - Sorted Array Property
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
    public class Remove_duplicates_from_sorted_array
    {
        public int RemoveDuplicatesFromSortedArray(int[] nums)
        {
            if(nums.Length==0)
            {               
                return 0;
            }

            int len = nums.Length;
            int k = 0;

            for(int j = 1; j < len; j++)
            {
                if (nums[k] != nums[j])
                {
                    k++;
                    nums[k] = nums[j];
                }
            }

            return k + 1;
        }
    }
}
