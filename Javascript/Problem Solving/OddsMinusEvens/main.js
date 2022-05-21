let FilterArrayByAnthorArray = function(arr1, arr2) {
    if(arr1.length == 0)
        return -1;
    else
    {
        if(arr2.length === 0)
            return arr1;
        else
        {
            for(let i = 0; i < arr1.length; i++)
            {
                if(arr2.includes(arr1[i]))
                    arr1.splice(i,1);
                else
                    continue;
            }
            return arr1;
        }
    }
    
};
console.log(FilterArrayByAnthorArray([1,2],[1]));
//[2]
console.log(FilterArrayByAnthorArray([],[1]));
// -1
console.log(FilterArrayByAnthorArray([1,2,2],[1]));
//[2,2]
console.log(FilterArrayByAnthorArray([1,2,2],[]));
//[1,2,2]
console.log(FilterArrayByAnthorArray([1,2,3,4,5,6,7,8],[1,3,5,7]));
//[2,4,6,8]