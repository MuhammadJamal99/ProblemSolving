public class BetweenTwoSets
{
    static void Main(string [] args)
    {
        Console.WriteLine("Please Enter The Size Of First Array:");
        int Size1 = Convert.ToInt32(Console.ReadLine());
        List<int> Arr1 = new List<int>();
        Console.WriteLine("Please Enter The Size Of Second Array:");
        int Size2 = Convert.ToInt32(Console.ReadLine());
        List<int> Arr2 = new List<int>();
        Console.WriteLine("Please Enter The Elements of First Array:");
        for (int i = 0; i < Size1; i++)
            Arr1.Add(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Please Enter The Elements of Second Array:");
        for (int i = 0; i < Size2; i++)
            Arr2.Add(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine(string.Join(",",Arr1));
        Console.WriteLine(string.Join(",",Arr2));

        int TotalIntegers = BetweenTwoSet(Arr1, Arr2);

        Console.WriteLine(TotalIntegers);
    }
    static int BetweenTwoSet(List<int> Arr1, List<int> Arr2)
    {
        int LCM = GetLCM(Arr1, 0),
            GCD = GetGCD(Arr2),
            Count = 0;
        for (int i = LCM, j = 2; i <= GCD; i = LCM * j, j++)
        {
            if (GCD % i == 0)
                Count++;
        }
        return Count;
    }
    static int _GCD(int A, int B)
    {
        if (A == 0)
            return B;
        else
            return _GCD(B % A, A);
    }
    static int GetLCM(List<int> Arr, int index)
    {

        if (index == Arr.Count() - 1)
            return Arr[index];
        else
        {
            int A = Arr[index];
            int B = GetLCM(Arr, index + 1);
            return (A * B / _GCD(A, B));
        }
    }
    static int GetGCD(List<int> Arr)
    {
        int Result = Arr[0];
        for (int i = 1; i < Arr.Count(); i++)
        {
            Result = _GCD(Arr[i], Result);
            if (Result == 1)
                return 1;

        }
        return Result;
    }
}
