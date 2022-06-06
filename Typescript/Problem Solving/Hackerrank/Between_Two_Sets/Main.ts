let _GCD = function(A,B):number
{
    if(A == 0)
        return B;
    else
        return _GCD(B % A ,A);
};
let GetLCM = function(Arr , Index):number
{
    if(Index == Arr.length - 1)
        return Arr[Index];
    else
    {
        let A = Arr[Index],
            B = GetLCM(Arr, Index + 1);
        return ((A * B) / _GCD(A,B));
    }
};
let GetGCD = function(Arr)
{
    let Result = Arr[0];
    for(let i = 1; i < Arr.length; i++)
    {
        Result = _GCD(Arr[i], Result);
        if(Result == 1)
            return 1;
    }
    return Result;
};
let BetweenTwoSets = function(Arr1, Arr2)
{
    let LCM = GetLCM(Arr1, 0),
        GCD = GetGCD(Arr2),
        Count = 0;
    for(let i = LCM, j = 2; i <= GCD; i =LCM * j, j++)
    {
        if(GCD % i == 0)
            Count++;
    }
    return Count;
}