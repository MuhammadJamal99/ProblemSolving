let insertionSort = function(arr)
{
    let Array = arr.slice();
    for(let i = 1; i < Array.length; i ++){
        for(let j = i; j > 0 ; j--){
            if(Array[j] < Array[j - 1])
                [Array[j], Array[j - 1]] = [Array[j - 1], Array[j]];
            else
                break;
        }
    }
    return Array;
};
console.log(insertionSort([1,50,10,30,60,235,140,120,100,14,30, 111,110]));