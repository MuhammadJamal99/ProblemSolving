public class Solution
{
    static void Main(string [] args)
    {

    }
    public int FirstBadVersion(int n)
    {
        if (n == 1) 
            return 1;
        int Low = 1, 
            High = n;
        while (Low < High)
        {
            int Mid = Low + (High - Low) / 2;
            if (IsBadVersion(Mid)) High = Mid;
            else if (!IsBadVersion(Mid) && IsBadVersion(Mid + 1)) return Mid + 1;
            else Low = Mid + 1;
        }
        if (Low != n && IsBadVersion(Low)) return Low;
        return -1;
    }
}