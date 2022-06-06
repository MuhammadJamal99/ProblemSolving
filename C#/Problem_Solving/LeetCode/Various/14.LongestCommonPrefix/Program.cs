public class Solution
{
    static void Main(string [] args)
    {
        Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
        Console.WriteLine(LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
    }
    static string LongestCommonPrefix(string [] Strs)
    {
        if (Strs.Length == 0)
            return "";
        else
        {
            string Prefix = Strs[0];
            for (int i = 0; i < Strs.Length; i++)
            {
                while (Strs[i].IndexOf(Prefix) != 0)
                    Prefix = Prefix.Substring(0, Prefix.Length - 1);
            }
            return Prefix;
        }
    }
}