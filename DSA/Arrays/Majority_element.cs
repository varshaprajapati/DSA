/*
QUESTION:
Given an array nums of size n, return the majority element.

The majority element is the element that appears more than
floor(n / 2) times.

The problem guarantees that a majority element always exists.

Example:
Input:  [2,2,1,1,1,2,2]
Output: 2


APPROACH 1 - BRUTE FORCE:
For every element, count how many times it appears.

Time Complexity: O(n²)
Space Complexity: O(1)


APPROACH 2 - DICTIONARY:
Store each number and its frequency.

Time Complexity: O(n) average
Space Complexity: O(n)


APPROACH 3 - BOYER-MOORE VOTING (OPTIMAL):
Maintain a candidate and a count.

Rules:
- If count == 0, choose current number as candidate.
- If current number == candidate, increase count.
- Otherwise, decrease count.

Because the majority element appears more than n/2 times,
it will survive the cancellation process.

Time Complexity: O(n)
Space Complexity: O(1)
*/

namespace DSA.Arrays
{
    public class Majority_element
    {
        public int MajorityElement(int[] nums)
        {
            // Brute Force

            //int n = nums.Length;

            //for (int i = 0; i < n; i++)
            //{
            //    int count = 0;

            //    for (int j = 0; j < n; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            count++;
            //        }
            //    }

            //    if (count > n / 2)
            //    {
            //        return nums[i];
            //    }
            //}

            //return -1;

            // ----------------------------------------------------------------------------------------------

            // Dictionary

            //Dictionary<int, int> frequency = new();

            //foreach (int num in nums)
            //{
            //    if (frequency.ContainsKey(num))
            //    {
            //        frequency[num]++;
            //    }
            //    else
            //    {
            //        frequency[num] = 1;
            //    }

            //    if (frequency[num] > nums.Length / 2)
            //    {
            //        return num;
            //    }
            //}

            //return -1;

            // ----------------------------------------------------------------------------------------------


            // Boyer-Moore Voting Algorithm - Optimal

            int candidate = -1, count = 0;

            foreach(int num in nums)
            {
                if(count ==0)
                {
                    candidate = num;
                    count++;

                } else if (num == candidate)
                {
                    count++;

                }else
                {
                    count--;
                }
            }

            return candidate;
        }
    }
}
