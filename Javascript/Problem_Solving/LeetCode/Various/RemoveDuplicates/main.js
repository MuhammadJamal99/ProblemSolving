let RemoveDuplicates = function(nums) {
    let lastPosition = 1;
    for(let i = 1; i < nums.length; i++)
    {
        if(nums[i] != nums[i - 1])
        {
            nums[lastPosition] = nums[i];
            lastPosition++;
        }
        else
            continue;
    }

    console.log(nums);
    return lastPosition;
};
console.log(RemoveDuplicates([1,1,2]));
//console.log(RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]));
//console.log(RemoveDuplicates([ 1, 1, 2, 2, 5 , 10 , 10, 15, 15 ,20, 20]));