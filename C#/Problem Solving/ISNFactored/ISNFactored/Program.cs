using System;
public class ISNFactored
{
    static void Main(string [] args)
    {
        Console.Write("Please Enter The Number You Want It's Factors:");
        int Num = Convert.ToInt32(Console.ReadLine());
        var Factors = GetFactors(Num);
        Console.WriteLine($"The Factors Of {Num} IS : [{string.Join(", ", Factors)}]");
    }
    static int [] GetFactors(int n)
    {
        List<int> Factors = new List<int>();
        for(int i = 1 ; i < n; i++)
        {
            if (n % i == 0)
                Factors.Add(i);
            else
                continue;
        }
        Factors.Remove(1);
        return Factors.ToArray();
    }
}
