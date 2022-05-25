public class DivisibleSumPairsClass
{
    static void Main(string [] args)
    {
        List<int> List1 = new();
        List<int> List2 = new();
        List1.AddRange(new[] { 1, 2, 3, 4, 5, 6 });
        List2.AddRange(new[] { 1, 3, 2, 6, 1, 2 });
        Console.WriteLine(DivisibleSumPairs(6, 5, List1));
        Console.WriteLine(DivisibleSumPairs(6, 3, List2));
        Console.WriteLine(OptimizationDivisibleSumPairs(6, 3, List2));
        Console.WriteLine(OptimizationDivisibleSumPairs(6, 3, List2));
    }
    static int DivisibleSumPairs(int N, int K, List<int> Arr)
    {
        int Counter = 0;
        for(int i = 0; i < N; i++)
        {
            for(int j = i + 1;j < N; j++)
            {
                if ((Arr.ElementAt(i) + Arr.ElementAt(j)) % K == 0)
                    Counter++;
                else
                    continue;
            }
        }
        return Counter;
    }
    static int OptimizationDivisibleSumPairs(int N, int K, List<int> Arr)
    {
        Dictionary<int, int> Table = new Dictionary<int, int>();
        int Counter = 0;
        foreach (var ele in Arr)
        {
            int Mod = ele % K;
            int Coml = K - Mod == 0 ? 0 : K - Mod;
            var Model = Table.ContainsKey(Coml);
            if (Table.ContainsKey(Coml))
                Counter = Counter + Table[Coml];
            if (Table.ContainsKey(Mod))
                Table[Mod] = Table[Mod] + 1;
            else
                Table[Mod] = 1;
        }
        Console.WriteLine(Table);
        return Counter;
    }
}
