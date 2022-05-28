#include <iostream>
#include <vector>
using namespace std;

int binarySearch(vector<int>& nums, int target)
{
    
    if(nums.size() == 0)
    {
        return 0;
    }
    else 
    {
        int Low = 0,
        High = nums.size() - 1;
        while (Low <= High)
        {
            int Mid = (Low + High) / 2;
            if(nums[Mid] == target)
            {
                return Mid;
            }
            else if (nums[Mid] < target)
            {
                Low = Mid + 1;
            }
            else {
                High = Mid - 1;
            }
            
        }
        
    }
}
int main(void)
{
    vector<int> arr{ 2, 3, 4, 10, 40 };
    int result = binarySearch(arr, 10);
    (result == -1)
        ? cout << "Element is not present in array"
        : cout << "Element is present at index " << result;
    return 0;
}