public class Solution
{
    static void Main(string [] args)
    {
        Console.WriteLine(SearchInsertPosition(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
        Console.WriteLine(SearchInsertPosition(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
        Console.WriteLine(SearchInsertPosition(new int[] { -1, 0, 3, 5, 9, 12 }, 0));
        Console.WriteLine(SearchInsertPosition(new int[] { -1, 0, 3, 5, 9, 12 }, 5));
        Console.WriteLine(SearchInsertPosition(new int[] { -1, 0, 3, 5, 9, 12 }, 10));
        Console.WriteLine(SearchInsertPosition(new int[] { -1, 0, 3, 5, 9, 12 }, 15));
    }
    static int SearchInsertPosition(int [] Arr, int Target)
    {
        int Low = 0,
            High = Arr.Length - 1;
        while(Low <= High)
        {
            int Mid = Low + (High - Low) / 2;
            if (Arr[Mid] == Target)
                return Mid;
            if (Arr[Mid] < Target)
                Low = Mid + 1;
            else
                High = Mid - 1;
        }
        return Low;
    }
}
