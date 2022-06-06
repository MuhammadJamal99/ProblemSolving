var _GCD = function (A, B) {
    if (A == 0)
        return B;
    else
        return _GCD(B % A, A);
};
var GetLCM = function (Arr, Index) {
    if (Index == Arr.length - 1)
        return Arr[Index];
    else {
        var A = Arr[Index], B = GetLCM(Arr, Index + 1);
        return ((A * B) / _GCD(A, B));
    }
};
var GetGCD = function (Arr) {
    var Result = Arr[0];
    for (var i = 1; i < Arr.length; i++) {
        Result = _GCD(Arr[i], Result);
        if (Result == 1)
            return 1;
    }
    return Result;
};
var BetweenTwoSets = function (Arr1, Arr2) {
    var LCM = GetLCM(Arr1, 0), GCD = GetGCD(Arr2), Count = 0;
    for (var i = LCM, j = 2; i <= GCD; i = LCM * j, j++) {
        if (GCD % i == 0)
            Count++;
    }
    return Count;
};
