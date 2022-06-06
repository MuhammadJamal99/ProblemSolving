let singleNumber = function(arr)
{
    if(arr.length % 2 == 0)
        return 0;
    else
    {
        arr.sort((a,b) => a - b);
        for(let i = 0; i < arr.length; i +=2)
        {
            if(i == arr.length - 1)
                return arr[i];
            if(arr[i] != arr[i+1])
                return arr[i];
        }
        return 0;
    }
};
let optimizationSingleNumber = function(arr){
    let singleNumber = 0;
    for(let num of arr)
        singleNumber ^= num;
    return singleNumber;
};
console.log(singleNumber([2, 2, 1 ]));
console.log(singleNumber([ 4, 1, 2, 1, 2]));
console.log(singleNumber([1]));
console.log(optimizationSingleNumber([2, 2, 1 ]));
console.log(optimizationSingleNumber([ 4, 1, 2, 1, 2]));
console.log(optimizationSingleNumber([1]));