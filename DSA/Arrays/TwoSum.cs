/*
 * Problem: Two Sum - Pair with Given Sum
 *
 * Given an array of integers and a target value,
 * determine whether there exists a pair whose sum equals the target.
 *
 * Example:
 * Input:  arr = [0, -1, 2, -3, 1], target = -2
 * Output: true
 *
 * --------------------------------------------------
 * Approach: HashSet
 * --------------------------------------------------
 *
 * For every number `num`, we need another number:
 *
 *     required = target - num
 *
 * We maintain a HashSet containing numbers we have
 * already seen.
 *
 * If `required` exists in the HashSet, we found a pair.
 * Otherwise, add the current number to the HashSet.
 *
 * Why HashSet?
 * HashSet provides O(1) average-time lookup, allowing
 * us to solve the problem in a single pass.
 *
 * Time Complexity: O(n) average
 * Space Complexity: O(n)
 * 
 * 
 *  Two-Pointer Technique -----------
 *  
 *  Time Complexity: O(n × log(n))
 *  Space Complexity: O(1)
 *  
 *  Naive Approach (Brute Force) ----------
 *  
 *  Time Complexity: O(n2)
 *  Space Complexity: O(1)
 *
 * --------------------------------------------------
 * Key Concept:
 * Hashing / HashSet
 *
 * Important C# Concept:
 * HashSet<T> is useful when we need fast existence checks
 * and do not need to store an associated value.
 */

using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA.Arrays
{
    public class TwoSum
    {
        public bool twoSum(int[] arr, int target)
        {

            // Brute Force Approach
            //int n = arr.Length;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] + arr[j] == target)
            //        {
            //            return true;
            //        }
            //    }
            //}

            //return false;


            // --------------------------------------------------------------------------------------------------------------'

            // Two Pointer Approach

            //Array.Sort(arr);

            //int left = 0, right = arr.Length - 1;

            //while (left < right)
            //{
            //    int sum = arr[left] + arr[right];

            //    if (sum == target)
            //        return true;
            //    else if (sum < target)

            //        left++;
            //    else

            //        right--;
            //}
            //return false;


            // --------------------------------------------------------------------------------------------------------------'


            // Optimized Approach

            HashSet<int> seen = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (seen.Contains(complement))
                {
                    return true;
                }
                seen.Add(arr[i]);
            }
            return false;
        }

    }

}

