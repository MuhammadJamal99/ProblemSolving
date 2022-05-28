public class Solution
{
    static void Main(string [] args)
    {
        Console.WriteLine(BinarySearch(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
        Console.WriteLine(BinarySearch(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
        Console.WriteLine(BinarySearch(new int[] { -1, 0, 3, 5, 9, 12 }, 0));
        Console.WriteLine(BinarySearch(new int[] { -1, 0, 3, 5, 9, 12 }, 5));
    }
    static int BinarySearch(int [] Arr, int Target)
    {
        if (Arr.Length == 0)
            return 0;
        else
        {
            int Low = 0,
            High = Arr.Length - 1;
            while (Low <= High)
            {
                int Mid = (Low + High) / 2;
                if (Arr[Mid] == Target)
                    return Mid;
                if (Arr[Mid] < Target)
                    Low = Mid + 1;
                else
                    High = Mid - 1;
            }
        }
        return -1;
    }
}
