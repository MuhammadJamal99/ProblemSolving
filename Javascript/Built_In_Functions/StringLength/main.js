let StringLength = function(str)
{
    let Length = 0;
    while(str[Length] !== undefined)
        Length++;

    return Length;
};
console.log(StringLength(""));
console.log(StringLength("Elzero"));
console.log(StringLength("Elzero Web"));