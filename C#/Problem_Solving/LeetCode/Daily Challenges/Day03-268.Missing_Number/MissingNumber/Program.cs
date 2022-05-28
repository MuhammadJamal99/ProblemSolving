public class Solution
{
    static void Main(string [] args)
    {
        Console.WriteLine(optimizationMissingNumber(new int[] { 3, 0, 1}));
        Console.WriteLine(optimizationMissingNumber(new int[] { 0, 1 }));
        Console.WriteLine(optimizationMissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
    }
    static int optimizationMissingNumber(int [] Arr)
    {
        int Sum = Arr.Length;
        for (int i = 0; i < Arr.Length; i++)
            Sum += i - Arr[i];
        return Sum;
    }
}