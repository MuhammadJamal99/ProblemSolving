public class Solution
{
    static void Main(string [] args)
    {
        Console.WriteLine(StringLength(""));
        Console.WriteLine(StringLength("Elzero"));
        Console.WriteLine(StringLength("Elzero Web"));
        Console.WriteLine("Elzero Web".Length);
    }
    static int StringLength(string Str)
    {
        int Length = 0;
        while(true)
        {
            if(Str[Length] == null)
                break;
            else
                Length++;
        }
        return Length;
    }
}
