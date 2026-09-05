using DSA.Arrays;


int[] arr = [1, -2, 1, 0, 5];
int target = 0;

TwoSum solution = new();

    if (solution.twoSum(arr, target))
        Console.WriteLine("true");
    else
        Console.WriteLine("false");