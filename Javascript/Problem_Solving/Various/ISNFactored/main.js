let GetNumberFactors = function(Num) {
    if(Num < 0)
        return -1;
    else
    {
        let FactorsArray = [];
        MainLoop: for(let i = 1; i < Num; i++)
        {
            if(Num % i == 0)
                FactorsArray.push(i);
            else
                continue MainLoop;
        } 
        return FactorsArray;
    }
};
console.log(GetNumberFactors(100));
// [1, 2, 4, 5, 10, 20, 25, 50]
console.log(GetNumberFactors(15));
// [1, 3, 5]
console.log(GetNumberFactors(24));
// [1, 2, 3, 4, 6, 8, 12]
console.log(GetNumberFactors(48));
// [1, 2, 3, 4, 6, 8, 12, 16, 24]
console.log(GetNumberFactors(200));
// [1, 2, 4, 5, 8, 10, 20, 25, 40, 50, 100]