public class Solution
{
    static void Main(string [] args)
    {
        Console.WriteLine("Please Enter Number:");
        int Num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The Numbers of Steps To Reduce {Num} To Zero Is: {NumberOfSteps(Num)}");
    }
    static int NumberOfSteps(int Num)
    {
        if (Num == 0)
            return 0;
        else
        {
            int Counter = 0;
            while(Num > 0)
            {
                if (Num % 2 == 0)
                    Num /= 2;
                else
                    Num -= 1;
                Counter++;
            }
            return Counter;
        }
    }
}
