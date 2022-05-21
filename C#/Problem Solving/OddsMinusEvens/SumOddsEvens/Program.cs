public class SumOddsMinusSumEven
{
    static void Main(string[] args)
    {
        Console.Write("Please Enter The Size of The Array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] Numbers = new int[n];
        Console.Write("Please Enter The Numbers in The Array:");
        for (int i = 0; i < Numbers.Length; i++)
        {
            Numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"[{string.Join(", ", Numbers)}]");
        Console.WriteLine($"The Difference Between Odds and Even: {GetDifference(Numbers)}");
    }
    static int GetDifference(int[] arr)
    {
        if (arr.Length == 0)
            return 0;
        else
        {
            int OddSum = 0, EvenSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    EvenSum += arr[i];
                else
                    OddSum += arr[i];
            }
            return OddSum - EvenSum;
        }

    }
}
