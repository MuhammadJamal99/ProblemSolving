public class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(OptimizationSingleNumber(new int[] { 2, 2, 1 }));
        Console.WriteLine(OptimizationSingleNumber(new int[] { 4, 1, 2, 1, 2 }));
        Console.WriteLine(OptimizationSingleNumber(new int[] { 1 }));
        Console.WriteLine(SingleNumber(new int[] { 2, 2, 1 }));
        Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));
        Console.WriteLine(SingleNumber(new int[] { 1 }));
    }
    static int SingleNumber(int [] Arr)
    {
        if (Arr == null || Arr.Length % 2 == 0)
            return 0;
        else
        {
            Array.Sort(Arr);
            for(int i = 0; i < Arr.Length; i += 2)
            {
                if (i == Arr.Length - 1)
                    return Arr[i];
                if (Arr[i] != Arr[i + 1])
                    return Arr[i];
            }
            return 0;
        }
    }
    static int OptimizationSingleNumber(int [] Arr)
    {
        int SingleValue = 0;
        foreach (var Item in Arr)
            SingleValue ^= Item;
        return SingleValue;
    }
}