public class Solution
{
    static void Main(string [] args)
    {
        Console.WriteLine(MaxProduct(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" }));
        Console.WriteLine(MaxProduct(new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" }));
        Console.WriteLine(MaxProduct(new string[] { "a", "aa", "aaa", "aaaa" }));
    }
    static int MaxProduct(string[] Words)
    {
        int n = Words.Length;
        int[] Masks = new int[n];

        for (int i = 0; i < n; i++)
        {
            foreach (char Ch in Words[i].ToCharArray())
                Masks[i] |= (1 << (Ch - 'a'));
        }

        int Largest = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (i != j && (Masks[i] & Masks[j]) == 0)
                    Largest = Math.Max(Largest, Words[i].Length * Words[j].Length);

        return Largest;
    }
}