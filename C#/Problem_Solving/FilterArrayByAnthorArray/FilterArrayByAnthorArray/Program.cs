using System;
public class FilterArrayByAnthorArray
{
    static void Main(string[] args)
    {
        int [] Arr1 = {1,2};
        int [] Arr2 = {1};
        int [] Arr3 = {};
        int [] Arr4 = {1};
        int [] Arr5 = {1,2,2};
        int [] Arr6 = {1};
        int [] Arr7 = {1,2,2};
        int [] Arr8 = {};
        int [] Arr9 = {1,2,3,4,5,6,7,8};
        int [] Arr10 = {1,3,5,7};
        Console.WriteLine($"The Filtered Array one IS: [{(FilterArrayByAnthor(Arr1, Arr2) != null ? string.Join(", ", FilterArrayByAnthor(Arr1, Arr2)) : string.Empty)}]");
        Console.WriteLine($"The Filtered Array Two IS: [{(FilterArrayByAnthor(Arr3, Arr4) != null? string.Join(", ", FilterArrayByAnthor(Arr4, Arr5)) : string.Empty)}]");
        Console.WriteLine($"The Filtered Array There IS: [{(FilterArrayByAnthor(Arr5, Arr6) != null ? string.Join(", ", FilterArrayByAnthor(Arr6, Arr7)) : string.Empty)}]");
        Console.WriteLine($"The Filtered Array Four IS: [{(FilterArrayByAnthor(Arr7, Arr8) != null ? string.Join(", ", FilterArrayByAnthor(Arr7, Arr8)) : string.Empty)}]");
        Console.WriteLine($"The Filtered Array Five IS: [{(FilterArrayByAnthor(Arr9, Arr10) != null ? string.Join(", ", FilterArrayByAnthor(Arr9, Arr10)) : string.Empty)}]");
    }
    static int[] FilterArrayByAnthor(int [] arr1, int [] arr2)
    {
        if (arr1.Length == 0)
            return null;
        else
        {
            if (arr2.Length == 0)
                return arr1;
            else
            {
               for(var i = 0; i < arr1.Length; i++)
               {
                    if (arr2.Contains(arr1[i]))
                        arr1 = arr1.Where((source, index) => index != i).ToArray();
                    else
                        continue;
               }
                return arr1;
            }
        }
    }
}
