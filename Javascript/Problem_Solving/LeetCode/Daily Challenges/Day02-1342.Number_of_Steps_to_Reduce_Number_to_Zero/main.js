let numberOfSteps = function(num) {
    if(Num == 0)
        return 0;
    else 
    {
        let Counter = 0;
        while(num > 0)
        {
            if(num % 2 == 0)
                num /= 2;
            else 
                num -= 1;
            Counter++;
        };
        return Counter;
    }
};
console.log(numberOfSteps(14));
console.log(numberOfSteps(8));
console.log(numberOfSteps(123));