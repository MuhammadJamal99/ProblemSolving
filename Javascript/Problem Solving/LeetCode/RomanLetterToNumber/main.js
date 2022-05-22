let romanToInt = function(s) {       
    let result = 0;
    let romanConversion;
    (function (romanConversion) {
        romanConversion[romanConversion["I"] = 1] = "I";
        romanConversion[romanConversion["IV"] = 4] = "IV";
        romanConversion[romanConversion["V"] = 5] = "V";
        romanConversion[romanConversion["IX"] = 9] = "IX";
        romanConversion[romanConversion["X"] = 10] = "X";
        romanConversion[romanConversion["XL"] = 40] = "XL";
        romanConversion[romanConversion["L"] = 50] = "L";
        romanConversion[romanConversion["XC"] = 90] = "XC";
        romanConversion[romanConversion["C"] = 100] = "C";
        romanConversion[romanConversion["CD"] = 400] = "CD";
        romanConversion[romanConversion["D"] = 500] = "D";
        romanConversion[romanConversion["CM"] = 900] = "CM";
        romanConversion[romanConversion["M"] = 1000] = "M";
    })(romanConversion || (romanConversion = {}));
    
    for (let a = 0, b = 1; a < s.length; a++, b++) {
        const romanOne = s[a];
        const romanTwo = s[b];
        const numOne = romanConversion[romanOne];
        const numTwo = romanConversion[romanTwo];
        if (numOne >= numTwo) 
            result += numOne;
        else if (numOne < numTwo) 
        {
            const combinedRomanNums  = romanOne + romanTwo;
            result += romanConversion[combinedRomanNums];
            a++;
            b++;
        } 
        else
            result += numOne;
    }
    return result;
};
//console.log(romanToInt("III"));
//console.log(romanToInt("LVIII"));
//58
console.log(romanToInt("MCMXCIV"));