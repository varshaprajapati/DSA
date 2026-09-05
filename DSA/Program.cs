using DSA.Arrays;


int[] arr = [1, -2, 1, 0, 5];
int target = 0;

int[] arr2 = [3, 4, 5, 1, 2];

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
Console.WriteLine(solution5.Check(arr2));