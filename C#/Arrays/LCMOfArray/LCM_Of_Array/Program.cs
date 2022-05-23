public class LCM
{
    /********** The Formal **********/
    /*
     LCM(a,b,c) = (a*b*c) / GCD(a,b,c)
     */
    static void Main(string [] args)
    {
        Console.WriteLine("Please Enter Sizes Of Arrays:");
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int Size1 = Convert.ToInt32(firstMultipleInput[0]);
        int Size2 = Convert.ToInt32(firstMultipleInput[1]);

        List<int> Arr1 = new List<int>();
        List<int> Arr2 = new List<int>();

        Console.WriteLine("Please Enter Numbers in Array One:");
        for (int i = 0; i < Size1; i++)
            Arr1.Add(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Please Enter Numbers in Array One:");
        for (int i = 0; i < Size2; i++)
            Arr2.Add(Convert.ToInt32(Console.ReadLine()));
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
    static long GetLCMArr(int [] Arr)
    {
        long LCM = 1;
        int Divisor = 2;
        while (true)
        {
            int Counter = 0;
            bool Divisible = false;
            for(int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 0)
                    return 0;
                else if (Arr[i] < 0)
                    Arr[i] *= -1;
                if (Arr[i] == 1)
                    Counter++;
                if(Arr[i] % Divisor == 0)
                {
                    Divisible = true;
                    Arr[i] = Arr[i] / Divisor;
                }
            }
            if (Divisible)
                LCM *= Divisor;
            else
                Divisor++;
            if (Counter == Arr.Length)
                return LCM;
        }
    }
}