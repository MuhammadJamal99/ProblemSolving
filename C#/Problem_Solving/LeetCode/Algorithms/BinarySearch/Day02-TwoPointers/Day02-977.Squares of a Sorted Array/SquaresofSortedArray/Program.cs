public class Solution
{
    static void Main(string [] args)
    {
        DateTime StartTime1 = DateTime.Now;
        Console.WriteLine(String.Join(",", SquaresOfSortedArray(new int[] { -4, -1, 0, 3, 10 })));
        DateTime EndTime1 = DateTime.Now;
        Console.WriteLine(EndTime1.Subtract(StartTime1).ToString());
        DateTime StartTime2 = DateTime.Now;
        Console.WriteLine(String.Join(",", SquaresOfSortedArray(new int[] { -7, -3, 2, 3, 11 })));
        DateTime EndTime2 = DateTime.Now;
        Console.WriteLine(EndTime2.Subtract(StartTime2).ToString());
        DateTime StartTime3 = DateTime.Now;
        Console.WriteLine(String.Join(",", OptimizationSquaresOfSortedArray(new int[] { -4, -1, 0, 3, 10 })));
        DateTime EndTime3 = DateTime.Now;
        Console.WriteLine(EndTime3.Subtract(StartTime3).ToString());
        DateTime StartTime4 = DateTime.Now;
        Console.WriteLine(String.Join(",", OptimizationSquaresOfSortedArray(new int[] { -7, -3, 2, 3, 11 })));
        DateTime EndTime4 = DateTime.Now;
        Console.WriteLine(EndTime4.Subtract(StartTime4).ToString());
    }
    static int [] SquaresOfSortedArray(int [] Arr)
    {
        int[] SortedArray = new int[Arr.Length];
        int i = 0,
            j = Arr.Length - 1;
        for(int k = Arr.Length - 1; k >= 0; k--)
        {
            if(Math.Abs(Arr[i]) > Math.Abs(Arr[j]))
            {
                SortedArray[k] = (int)Math.Pow(Arr[i], 2);
                i++;
            }
            else
            {
                SortedArray[k] = (int)Math.Pow(Arr[j], 2);
                j--;
            }
        }
        return SortedArray;
    }
    static int [] OptimizationSquaresOfSortedArray(int [] Arr)
    {
        for(int i = 0; i < Arr.Length; i++)
            Arr[i] = (int)Math.Pow(Arr[i], 2);
        Array.Sort(Arr);
        return Arr;
    }
}