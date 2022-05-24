public class RemoveDuplicatesClass
{
    static void Main(string [] args)
    {
        int [] nums1 = {1,1,2};
        Console.WriteLine(RemoveDuplicates(nums1));
        int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        Console.WriteLine(RemoveDuplicates(nums2));
        int[] nums3 = { 1, 1, 2, 2, 5 , 10 , 10, 15, 15 ,20, 20 };
        Console.WriteLine(RemoveDuplicates(nums3));
    }
    static int RemoveDuplicates(int [] Arr)
    {
        var LastPosition = 1;
        for(int i = 1; i < Arr.Length; i++)
        {
            if(Arr[i] != Arr[i - 1])
            {
                Arr[LastPosition] = Arr[i];
                LastPosition++;
            }
            else
                continue;
        }
        Arr = Arr.Where((source, index) => index <= LastPosition - 1).ToArray();
        Console.WriteLine(string.Join(",", Arr));
        return LastPosition;
    }
}