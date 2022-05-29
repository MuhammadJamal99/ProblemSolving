let SquaresOfSortedArray = function(Arr) 
{
    let i = 0,
        j = Arr.length - 1,
        SortedArray = new Array(Arr.length);
    for(let k = Arr.length - 1; k >= 0; k--)
    {
        if(Math.abs(Arr[i]) > Math.abs(Arr[j]))
        {
            SortedArray[k] = Math.pow(Arr[i],2);
            i++;
        }
        else 
        {
            SortedArray[k] = Math.pow(Arr[j],2);
            j--;
        }
    }
    return SortedArray;
};
let OptimizationSquaresOfSortedArray = function(Arr)
{
    for(let i = 0; i < Arr.length; i++)
        Arr[i] = Math.pow(Arr[i],2);
    return Arr.sort((a,b) => a - b);
};
console.log(SquaresOfSortedArray([ -4, -1, 0, 3, 10]));
console.log(SquaresOfSortedArray([ -7, -3, 2, 3, 11]));
console.log(OptimizationSquaresOfSortedArray([ -4, -1, 0, 3, 10]));
console.log(OptimizationSquaresOfSortedArray([ -7, -3, 2, 3, 11]));