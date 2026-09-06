/*
    Problem:
    Find the union of two sorted arrays.
    The union should contain every distinct element
    from both arrays.

    Example:
    arr1 = [2, 2, 3, 4, 5]
    arr2 = [1, 1, 2, 3, 4]

    Output:
    [1, 2, 3, 4, 5]

    Brute Force:
    Use a HashSet to store elements from both arrays.
    Time: O(n + m) average
    Space: O(n + m)

    Optimal Approach:
    Since both arrays are sorted, use two pointers.
    Compare the current elements and add the smaller one.
    If both are equal, add it only once and move both pointers.

    Time Complexity: O(n + m)
    Auxiliary Space: O(1)
    Output Space: O(n + m)

    Pattern:
    Two Pointers / Merge of Sorted Arrays
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays
{
    public class Union_of_2_sorted_arrays
    {
        public List<int> FindUnion(int[] arr1, int[] arr2)
        {

            // Brute Force Approach

            //HashSet<int> set = new();

            //foreach (int num in arr1)
            //{
            //    set.Add(num);
            //}

            //foreach (int num in arr2)
            //{
            //    set.Add(num);
            //}

            //// HashSet does not guarantee sorted order,
            //// so sort the result.
            //List<int> union = set.ToList();
            //union.Sort();

            //return union;

            // ---------------------------------------------------------------------------------------------

            // Optimal Approach - Two Pointers

            int i =0, j = 0;

            List<int> list = new List<int>();

            while(i<arr1.Length && j<arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    AddIfUnique(list, arr1[i]);
                    i++;

                }else if(arr2[j] < arr1[i])
                {
                    AddIfUnique(list, arr2[j]);
                    j++;
                }
                else
                {
                    AddIfUnique(list, arr1[i]);
                    i++;
                    j++;
                }
            }

            while(i<arr1.Length)
            {
                AddIfUnique(list, arr1[i]);
                i++;
            }


            while (j < arr2.Length)
            {
                AddIfUnique(list, arr2[j]);
                j++;
            }

            return list;

        }

        // Add only if the value is different from
        // the last value already added.
        private void AddIfUnique(List<int> union, int value)
        {
            if (union.Count == 0 || union[^1] != value)
            {
                union.Add(value);
            }
        }
    }
}
