let IsPalindromeLoopWay = function(Num) {
    if (Num < 0) {
        return false;
    }
    let reverseNumber = 0;
    for (let i = Num; i >= 1; i = Math.floor(i / 10)) 
        reverseNumber = reverseNumber * 10 + i % 10;
    return reverseNumber === Num;
};
let IsPalindromeStrWay = function(Num) {
    if(Num < 0)
        return false;
    else
    {
        if(String(Num) === String(Num).split("").reverse().join(""))
            return true;
        else
            return false;
    }
};

console.log(IsPalindromeLoopWay(121));
// true
console.log(IsPalindromeLoopWay(123));
// false
console.log(IsPalindromeLoopWay(555));
// true
console.log(IsPalindromeLoopWay(44));
// true
console.log(IsPalindromeLoopWay(8888));
// true