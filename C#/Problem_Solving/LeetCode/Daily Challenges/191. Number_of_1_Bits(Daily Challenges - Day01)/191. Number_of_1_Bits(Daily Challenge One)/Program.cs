public class HammingWeightClass
{
    static void Main(string [] args)
    {
        Console.WriteLine("Please Enter Unsigned Number:");
        uint Num = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine($"The Numbers of Ones in {Num} Is: {HammingWeight(Num)}");

    }
    static int HammingWeight(string n)
    {
        int Counter = 0;
        char [] BitsArr = n.ToCharArray();
        foreach(var Item in BitsArr)
        {
            if (Item == '1')
                Counter++;
            else
                continue;
        }
        return Counter;
    }
    static int HammingWeight(uint n)
    {
        return Convert.ToString(n, 2).ToCharArray().Count(c => c == '1');
    }
}
