using System;
public class SecondLargest
{

    static void Main(string[] args)
    {
        Console.Write("Please Enter The Size of The Array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] Numbers = new int[n];
        Console.Write("Please Enter The Numbers in The Array:");
        for(int i = 0; i < Numbers.Length; i++)
        {
            Numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"[{string.Join(", ", Numbers)}]");
        Console.WriteLine($"The Secound Largest Number In Above Array IS: {GetSecondLargest(Numbers)}");
    }
    static int GetSecondLargest(int [] arr)
    {
        if (arr.Length == 1)
            return -1;
        else
        {
            int Largest = -1, SecondLargest = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Largest)
                {
                    SecondLargest = Largest;
                    Largest = arr[i];
                }
                else if (arr[i] > SecondLargest)
                {
                    if (arr[i] == Largest)
                        continue;
                    else
                        SecondLargest = arr[i];
                }
            }
            return SecondLargest;
        }
    }
}
