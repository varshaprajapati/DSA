using DSA.Arrays;

int[] arr = [1, -2, 1, 0, 5];
int target = 0;

TwoSum solution = new();
Console.WriteLine($"Two Sum - Result: {solution.twoSum(arr, target)}");


StockBuyandSell solution2 = new();
int[] prices = { 7, 10, 1, 3, 6, 9, 2 };
Console.WriteLine($"Stock Buy and Sell - Result: {solution2.maxProfit(prices)}");


Largest_element_in_array solution3 = new();
Console.WriteLine($"Largest Element in Array - Result: {solution3.FindLargest(arr)}");


SecondLargest solution4 = new();
Console.WriteLine($"Second Largest Element - Result: {solution4.FindSecondLargest(arr)}");


Check_if_array_is_sorted_and_rotated solution5 = new();
int[] arr2 = [3, 4, 5, 1, 2];
Console.WriteLine($"Check if Array is Sorted and Rotated - Result: {solution5.Check(arr2)}");


Remove_duplicates_from_sorted_array solution6 = new();
int[] arr3 = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
Console.WriteLine($"Remove Duplicates from Sorted Array - Result: {solution6.RemoveDuplicatesFromSortedArray(arr3)}");


Rotate_array_left_by_1place solution7 = new();
int[] arr4 = [1, 2, 3, 4, 5];
int[] result = solution7.LeftRotate(arr4);
Console.WriteLine($"Left Rotate Array by 1 Place - Result: {string.Join(", ", result)}");


Rotate_array_left_right_by_k_places solution8 = new();
int[] arr5 = [1, 2, 3, 4, 5, 6, 7];
int[] result2 = solution8.Rotate(arr5, 3);
Console.WriteLine($"Rotate Array by K Places - Result: {string.Join(", ", result2)}");


Move_0_s_to_end solution9 = new();
int[] arr6 = [1, 1, 0, 0, 3, 12];
int[] result3 = solution9.Move(arr6);
Console.WriteLine($"Move Zeroes to End - Result: {string.Join(", ", result3)}");


Union_of_2_sorted_arrays solution10 = new();
int[] arr7 = [2, 2, 3, 4, 5];
int[] arr8 = [1, 1, 2, 3, 4];

List<int> result4 = solution10.FindUnion(arr7, arr8);
Console.WriteLine($"Union of 2 Sorted Arrays - Result: {string.Join(", ", result4)}");


Missing_number solution11 = new();
int[] arr9 = [3, 0, 1];
Console.WriteLine($"Missing Number - Result: {solution11.FindMissingOptimal(arr9)}");


Longest_subarray_with_given_sum solution12 = new();
Console.WriteLine($"Longest Subarray with Given Sum - Result: {solution12.FindLongest(
    new[] { 1, -1, 5, -2, 3 }, 3)}");


Find_element_present_only_once solution13 = new();
int[] arr10 = [4, 1, 2, 1, 2];
Console.WriteLine($"Find Element Present Only Once - Result: {solution13.SingleNumber(arr10)}");


Sort_0_1_2 solution14 = new();
int[] arr11 = [2, 0, 2, 1, 1, 0];
int[] result5 = solution14.SortColors(arr11);
Console.WriteLine($"Sort_0_1_2 - Result: {string.Join(", ", result5)}");

Majority_element solution15 = new();
int[] arr12 = [4, 1, 2, 1, 2];
Console.WriteLine($"Majority element - Result: {solution15.MajorityElement(arr12)}");