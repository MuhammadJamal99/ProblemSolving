let permutationEquation = function(Arr){
    let result = new Array(Arr.length);
    MainLoop: for(let i of Arr)
        result[Arr[Arr[i - 1] - 1] - 1] = i;
    return result;
};

console.log(permutationEquation([5,2,1,3,4]));
console.log(permutationEquation([2,3,1]));