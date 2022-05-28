let searchInsertPosition = function(arr, target) {
    let low = 0,
        high = arr.length - 1;
    while(low <= high)
    {
        let mid = Math.floor(low + (high - low) / 2);
        if(arr[mid] == target)
            return mid;
        if(arr[mid] < target)
            low = mid + 1;
        else
            high = mid - 1;
    }
    return low;
};
console.log(searchInsertPosition([-1, 0, 3, 5, 9, 12], 9));
console.log(searchInsertPosition([-1, 0, 3, 5, 9, 12], 2));
console.log(searchInsertPosition([-1, 0, 3, 5, 9, 12], 0));
console.log(searchInsertPosition([-1, 0, 3, 5, 9, 12], 5));
console.log(searchInsertPosition([-1, 0, 3, 5, 9, 12], 10));
console.log(searchInsertPosition([-1, 0, 3, 5, 9, 12], 15));