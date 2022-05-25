public class SequenceEquationClass
{
    static void Main(string [] args)
    {
        List<int> List1 = new();
        List<int> List2 = new();
        List1.AddRange(new int[] { 5, 2, 1, 3, 4 });
        List2.AddRange(new int[] { 2, 3, 1 });
        Console.WriteLine(String.Join(",", PermutationEquation(List1).ToArray()));
        Console.WriteLine(String.Join(",", PermutationEquation(List2).ToArray()));
    }
    static List<int> PermutationEquation(List<int> Numbers)
    {
        int[] Result = new int[Numbers.Count()];
        foreach (int Ele in Numbers)
            Result[Numbers[Numbers[Ele - 1] - 1] - 1] = Ele;
        return Result.ToList();
    }
}
