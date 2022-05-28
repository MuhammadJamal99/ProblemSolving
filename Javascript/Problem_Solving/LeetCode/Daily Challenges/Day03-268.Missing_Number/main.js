let missingNumber = function(Arr)
{
    let Sum = Arr.length;
    for(let i = 0; i < Arr.length; i++)
        Sum += i - Arr[i];
    return Sum;
}
console.log(missingNumber([3, 0, 1]));
console.log(missingNumber([ 0, 1 ]));
console.log(missingNumber([ 9, 6, 4, 2, 3, 5, 7, 0, 1 ]));