public class RomanLettersToInteger
{
    
    static void Main(string [] args)
    {
        Console.Write("Please Enter Roman String To Get It's Value:");
        string RomanStr = Console.ReadLine().Replace(" ", "");
        Console.WriteLine($"The Value Of {RomanStr} Is : {ConvertRomanStrToInt(RomanStr)} !");
    }
    static int ConvertRomanStrToInt(string RomanStr)
    {
        int Result = 0;
        RomanStr = RomanStr.Replace(" ", "");
        Dictionary<string, int> RomanLetters = new Dictionary<string, int>();
        RomanLetters.Add("I", 1);
        RomanLetters.Add("IV", 4);
        RomanLetters.Add("V", 5);
        RomanLetters.Add("IX", 9);
        RomanLetters.Add("X", 10);
        RomanLetters.Add("XL", 40);
        RomanLetters.Add("L", 50);
        RomanLetters.Add("XC", 90);
        RomanLetters.Add("C", 100);
        RomanLetters.Add("CD", 400);
        RomanLetters.Add("D", 500);
        RomanLetters.Add("CM", 900);
        RomanLetters.Add("M", 1000);
        for (int i = 0, j = 1; i < RomanStr.Length; i++, j++)
        {
            if(j == RomanStr.Length)
                Result += RomanLetters[RomanStr[i].ToString()];
            else
            {
                char RomanOne = RomanStr[i],
                     RomanTwo = RomanStr[j];
                int NumOne = RomanLetters[RomanOne.ToString()],
                    NumTwo = RomanLetters[RomanTwo.ToString()];
                if (NumOne >= NumTwo)
                    Result += NumOne;
                else if (NumOne < NumTwo)
                {
                    string CombinedRomanNums = RomanOne + "" + RomanTwo;
                    Result += RomanLetters[CombinedRomanNums];
                    i++;
                    j++;
                }
                else
                    Result += NumOne;
            }
        }
        return Result;
    }
}
