let BinarySearch = function(arr, target) 
{
    if(arr.length == 0)
        return 0;
    else 
    {
        let low = 0,
        high = arr.length - 1;
        while(low <= high)
        {
            let mid = Math.floor((high + low) / 2);
            if(arr[mid] == target)
                return mid;
            else if(arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }
};
console.log(BinarySearch([-1,0,3,5,9,12] , 9));
console.log(BinarySearch([-1,0,3,5,9,12] , 2));
console.log(BinarySearch([-1,0,3,5,9,12] , 0));