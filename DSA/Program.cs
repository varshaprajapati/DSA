using DSA.Arrays;


int[] arr = [1, -2, 1, 0, 5];
int target = 0;

TwoSum solution = new();
if (solution.twoSum(arr, target))
    Console.WriteLine("true");
else
    Console.WriteLine("false");

StockBuyandSell solution2 = new();
int[] prices = { 7, 10, 1, 3, 6, 9, 2 };
Console.WriteLine(solution2.maxProfit(prices));

Largest_element_in_array solution3 = new();
Console.WriteLine(solution3.FindLargest(arr));

SecondLargest solution4 = new();
Console.WriteLine(solution4.FindSecondLargest(arr));

Check_if_array_is_sorted_and_rotated solution5 = new();
int[] arr2 = [3, 4, 5, 1, 2];
Console.WriteLine(solution5.Check(arr2));

Remove_duplicates_from_sorted_array solution6 = new();
int[] arr3 = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
Console.WriteLine(solution6.RemoveDuplicatesFromSortedArray(arr3));

Rotate_array_left_by_1place solution7 = new();
int[] arr4 = [1, 2, 3, 4, 5];
int[] result = solution7.LeftRotate(arr4);
Console.WriteLine(string.Join(", ", result));


Rotate_array_left_right_by_k_places solution8 = new();
int[] arr5 = [1, 2, 3, 4, 5, 6, 7];
int[] result2 = solution8.Rotate(arr5, 3);
Console.WriteLine(string.Join(", ", result2));


Move_0_s_to_end solution9 = new();
int[] arr6 = [1, 1, 0, 0, 3, 12];
int[] result3 = solution9.Move(arr6);
Console.WriteLine(string.Join(", ", result3));


Union_of_2_sorted_arrays solution10 = new();
int[] arr7 = [2, 2, 3, 4, 5];
int[] arr8 = [1, 1, 2, 3, 4];

List<int> result4 = solution10.FindUnion(arr7,arr8);
Console.WriteLine(string.Join(", ", result4));

