public class Solution
{
    static void Main(string [] args)
    {
        var Nums1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        RotateArray(Nums1, 3);
        var Nums2 = new int[] { -1, -100, 3, 99 };
        RotateArray(Nums2, 2);
        Console.WriteLine(String.Join(",", RotateArray(3, new int[] { 1, 2, 3, 4, 5, 6, 7 })));
        Console.WriteLine(String.Join(",", RotateArray(2, new int[] { -1, -100, 3, 99 })));
        Console.WriteLine(String.Join(",", Nums1));
        Console.WriteLine(String.Join(",", Nums2));
    
    }
    static int [] RotateArray(int K, int [] Nums)
    {
        int N = Nums.Length;
        K = K % N;
        int [] SliceArr = Nums[(N - K)..(N)];
        List<int> NumsList = Nums.ToList();
        NumsList.RemoveRange((N - K), K);
        for (int i = 0; i < K; i++)
            NumsList.Insert(i, SliceArr[i]);
        return NumsList.ToArray();
    }
    static void RotateArray(int[] Nums, int K)
    {
        int N = Nums.Length;
        K = K % N;
        int[] SliceArr = Nums[(N - K)..(N)];
        List<int> NumsList = Nums.ToList();
        NumsList.RemoveRange((N - K), K);
        NumsList.ToArray();
        for (int i = 0; i < K; i++)
            NumsList.Insert(i, SliceArr[i]);
        for (int i = 0; i < N; i++)
            Nums[i] = NumsList[i];
    }
}