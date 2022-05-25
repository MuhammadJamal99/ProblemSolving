let DivisibleSumPairs = function(N, K, Arr){
    let Counter = 0;
    MainLoop: for(let i = 0; i < N; i++)
    {
        SubLoop: for(let j = i + 1; j < N; j++)
        {
            if(((Arr[i] + Arr[j]) % K) == 0)
                Counter++;
            else
                continue SubLoop;
        }
    }
    return Counter;
};
let OptimizationDivisibleSumPairs = function(N, K, Arr){
    let Counter = 0;
    const HashMod = new Map();
    MainLoop: for(let i = 0; i < N ; i++)
    {
        let Mod = Arr[i] % K,
            Com = K - Mod == 0 ? 0 : K - Mod;
        if([...HashMod.keys()].includes(Com))
            Counter = Counter + HashMod.get(Com);
        if([...HashMod.keys()].includes(Mod))
            HashMod.set(Mod,HashMod.get(Mod) + 1);
        else
            HashMod.set(Mod,1);
    }
    console.log(HashMod);
    return Counter;
};
//console.log(DivisibleSumPairs(6,5,[1,2,3,4,5,6]));//3
//console.log(DivisibleSumPairs(6,3,[1,3,2,6,1,2]));//5

console.log(OptimizationDivisibleSumPairs(6,5,[1,2,3,4,5,6]));//3
console.log(OptimizationDivisibleSumPairs(6,3,[1,3,2,6,1,2]));//5