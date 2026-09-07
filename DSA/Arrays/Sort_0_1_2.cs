/*
QUESTION:
Given an array containing only 0, 1, and 2,
sort the array in-place without using the library's sort function.

Example:
Input:  [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]


APPROACH 1 - COUNTING:
Count the number of 0s, 1s, and 2s,
then overwrite the array in sorted order.

Time Complexity: O(n)
Space Complexity: O(1)


APPROACH 2 - DUTCH NATIONAL FLAG (OPTIMAL):
Use three pointers:
- low  -> position for 0
- mid  -> current element
- high -> position for 2

Rules:
- nums[mid] == 0:
    Swap with low
    low++, mid++

- nums[mid] == 1:
    mid++

- nums[mid] == 2:
    Swap with high
    high--
    Do NOT increment mid because the swapped element
    still needs to be processed.

Time Complexity: O(n)
Space Complexity: O(1)

Test Cases 🧪

| #  | Input           | Expected Output |
| -- | --------------- | --------------- |
| 1  | `[2,0,2,1,1,0]` | `[0,0,1,1,2,2]` |
| 2  | `[2,0,1]`       | `[0,1,2]`       |
| 3  | `[0]`           | `[0]`           |
| 4  | `[1]`           | `[1]`           |
| 5  | `[2]`           | `[2]`           |
| 6  | `[0,0,0]`       | `[0,0,0]`       |
| 7  | `[1,1,1]`       | `[1,1,1]`       |
| 8  | `[2,2,2]`       | `[2,2,2]`       |
| 9  | `[2,2,1,1,0,0]` | `[0,0,1,1,2,2]` |
| 10 | `[1,2,0,2,1,0]` | `[0,0,1,1,2,2]` |



*/

namespace DSA.Arrays
{
    public class Sort_0_1_2
    {
        public int[] SortColors(int[] nums)
        {
            // Approach 1 - Counting

            //int count0 = 0;
            //int count1 = 0;
            //int count2 = 0;

            //foreach (int num in nums)
            //{
            //    if (num == 0)
            //        count0++;
            //    else if (num == 1)
            //        count1++;
            //    else
            //        count2++;
            //}

            //int index = 0;

            //while (count0 > 0)
            //{
            //    nums[index++] = 0;
            //    count0--;
            //}

            //while (count1 > 0)
            //{
            //    nums[index++] = 1;
            //    count1--;
            //}

            //while (count2 > 0)
            //{
            //    nums[index++] = 2;
            //    count2--;
            //}

            //return nums;

            // --------------------------------------------------------------------------------------------------------------


            // Approach 2 - Dutch National Flag

            int n = nums.Length;
            int lo = 0, mid = 0, high = n-1;

            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    (nums[lo], nums[mid]) = (nums[mid], nums[lo]);
                    lo++;
                    mid++;

                } else if (nums[mid] == 1)
                {
                    mid++;

                }else
                {
                    (nums[mid], nums[high]) = (nums[high], nums[mid]);
                    high--;
                }
            }

            return nums;

        }
    }
}
