using System;
public class LongestCommenPrefix
{
    static void Main(string [] args)
    {
        Console.Write("Please Enter The Size Of String Array:");
        int n = Convert.ToInt32(Console.ReadLine());
        string [] Words = new string[n];
        Console.Write("Please Enter The Words (Don't Add Empty Strings):");
        for (int i = 0; i < Words.Length; i++)
            Words[i] = Console.ReadLine();
        Console.WriteLine($"The Longest Commen Prefix Is: {GetLongestCommenPrefix(Words)}");

    }
    static string GetLongestCommenPrefix(string [] Arr)
    {

    }
}
