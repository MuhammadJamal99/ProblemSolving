let OddsMinusEvens = function(arr) {
    if(arr.length == 0)
        return 0;
    else
    {
        let SumOdds = 0,
            SumEvens = 0;
        for(let i = 0; i < arr.length; i++){
            if(arr[i] % 2 == 0)
                SumEvens += arr[i];
            else
                SumOdds += arr[i];
        }
        return SumOdds - SumEvens;
    }
};
console.log(OddsMinusEvens([1,2]));
//[2]
console.log(OddsMinusEvens([1]));
// -1
console.log(OddsMinusEvens([1,2,2]));
//[2,2]
console.log(OddsMinusEvens([1,2,2]));
//[1,2,2]
console.log(OddsMinusEvens([1,2,3,4,5,6,7,8]));
//[2,4,6,8]