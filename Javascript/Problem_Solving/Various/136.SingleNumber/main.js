let singleNumber = function(Arr) {
    if(Arr == null || Arr.length % 2 == 0)
        return 0;
    else {
        Arr.sort((a,b) => a - b);
        for(let i = 0; i < Arr.length; i += 2)
        {
            if(i == Arr.length - 1)
                return Arr[i];
            if(Arr[i] != Arr[i + 1])
                return Arr[i];
        }
        return 0;
    }
};
let optimizationSingleNumber = function(Arr) 
{
    let SingleValue = 0;
    for(let item of Arr)
        SingleValue ^= item;
    return SingleValue;
};
console.log(singleNumber([2,2,1]));
console.log(singleNumber([4,1,2,1,2]));
console.log(singleNumber([1]));
console.log(optimizationSingleNumber([2,2,1]));
console.log(optimizationSingleNumber([4,1,2,1,2]));
console.log(optimizationSingleNumber([1]));