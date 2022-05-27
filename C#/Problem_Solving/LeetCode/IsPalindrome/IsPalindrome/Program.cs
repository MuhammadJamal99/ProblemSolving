using System;
public class PalindromeNumber
{
    static void Main(string [] args)
    {
        Console.Write("Please Enter The Number To Check It:");
        int Num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{(IsPalindromeLoopWay(Num) ? $"The Number {Num} Is Palindrome!": $"The Number {Num} Is Not Palindrome!")}");
    }
    static bool IsPalindromeLoopWay(int Num)
    {
        if (Num < 0)
            return false;
        else
        {
            int ReverseNum = 0;
            for(double i = (double) Num; i >= 1; i = Math.Floor(i / 10))
                ReverseNum = (int)(ReverseNum * 10 + (i % 10));
            return ReverseNum == Num;
        }
    }
    static bool IsPalindromeStrWay(int Num)
    {
        var NumString = Num.ToString();
        var orginalStr = NumString.ToCharArray();
        Array.Reverse(orginalStr);
        var ReversedStr = new string(orginalStr);
        if (NumString == ReversedStr)
            return true;
        else
            return false;
    }
}
